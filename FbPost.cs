namespace FacebookSeller
{
    public class FbPost
    {
        public string Url { get; set; }
        public string Message { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Source { get; set; }

        public FbPost(string url, string message, string name, string description, string source)
        {
            Url = url;
            Message = message;
            Name = name;
            Description = description;
            Source = source;
        }
    }
}
