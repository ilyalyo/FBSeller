using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using Newtonsoft.Json.Linq;

namespace FacebookSeller
{
    public interface IFbRequestInterface
    {
        String CreatePost(FbPost fbPost, FbGroup fbGroup);
        FbGroup GetGroup(string id);
        bool IsValidToken(string token);
    }

    public class FbRequest : IFbRequestInterface
    {
        private String _accessToken;
        private const String FbBaseUrl = "https://graph.facebook.com";

        public FbRequest(String accessToken)
        {
            _accessToken = accessToken;
        }

        public void SetToken(string newToken)
        {
            _accessToken = newToken;
        }

        public bool IsValidToken()
        {
            var url = FbBaseUrl + "/me?fields=name&access_token=" + _accessToken;
            var o = MakeRequest(url, "GET");
            return o != null && o["name"] != null;
        }

        public bool IsValidToken( string token )
        {
            var url = FbBaseUrl + "/me?fields=name&access_token=" + token;
            var o = MakeRequest(url, "GET");
            return o != null && o["name"] != null;
        }

        public String CreatePost(FbPost fbPost, FbGroup fbGroup)
        {
            var url = FbBaseUrl + "/" + fbGroup.Id + "/feed" +
                "?message=" + Uri.EscapeDataString(fbPost.Message) +
                "&link=" + Uri.EscapeDataString(fbPost.Url) +
                "&name=" + Uri.EscapeDataString(fbPost.Name) +
                "&description=" + Uri.EscapeDataString(fbPost.Description) +
                "&access_token=" + _accessToken;
            var o = MakeRequest(url, "POST");
            if (o != null && o["id"] != null)
                return o["id"].ToString();
            return null;
        }

        public String CreatePostAndUploadPhoto(FbPost fbPost, FbGroup fbGroup)
        {
            var postUrl = FbBaseUrl + "/" + fbGroup.Id + "/photos" +
                "?message=" + fbPost.Message + 
                "&access_token=" + _accessToken;
            var client = new WebClient();
            try
            {
                var result = client.UploadFile(postUrl, "POST", @"C:\temp\images.jpg");
            }
            catch (Exception)
            {
                return null;
            }
            return "";
        }

        public FbGroup GetGroup( string id )
        {
            var url = FbBaseUrl + "/" + id + "?access_token=" + _accessToken;
            var o = MakeRequest(url, "GET");
            if (o != null && o["name"] != null)
                return new FbGroup(o["id"].ToString(), o["name"].ToString()); 

            url = FbBaseUrl + "/search" +
                  "?q=" + Uri.EscapeDataString(id) +
                  "&type=group" +
                  "&access_token=" + _accessToken;
            o = MakeRequest(url, "GET");
            if (o != null && o["data"] != null && o["data"].Any())
                return new FbGroup(o["data"][0]["id"].ToString(), o["data"][0]["name"].ToString()); 

            return null;
        }

        private static JObject MakeRequest(string url, string method)
        {
            var result = new JObject();
            var request = WebRequest.Create(url);
            request.Method = method;
            request.Credentials = CredentialCache.DefaultCredentials;
            try
            {
                using (var webresponse = (HttpWebResponse)request.GetResponse())
                {
                    if (webresponse.StatusCode == HttpStatusCode.OK)
                    {
                        var dataStream = webresponse.GetResponseStream();
                        if (dataStream != null)
                        {
                            var reader = new StreamReader(dataStream);
                            var responseStr = reader.ReadToEnd();

                            result = JObject.Parse(responseStr);
                        }
                    }
                }
            }
            catch
            {
            }

            return result;
        }
    }
}
