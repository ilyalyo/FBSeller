using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using System.Drawing;

namespace FacebookSeller
{
    public partial class Form1 : Form
    {
        private readonly List<FbGroup> _fbGroups;
        private readonly FbRequest _fbRequest;
        private string _imgFileName;

        //вот это менять:
        private string plchldrMessage = "Enter message";
        private string plchldrName = "Enter name";
        private string plchldrDescription = "Enter description";
        public Form1()
        {
            InitializeComponent();
            _fbRequest = new FbRequest(Properties.Settings.Default.accessToken);
            _fbGroups = LoadGroups();
            BindData();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.textBoxMessage.Text = plchldrMessage;
            this.textBoxName.Text = plchldrName;
            this.richTextDescription.Text = plchldrDescription;
        }

        void BindData()
        {
            listBoxGroups.DataSource = null;
            listBoxGroups.DataSource = _fbGroups;
            listBoxGroups.DisplayMember = "Name";
            SaveGroups(_fbGroups);
        }

        private void buttonRemoveGroup_Click(object sender, EventArgs e)
        {
            var index = listBoxGroups.SelectedIndex;
            if (index <= 0) return;
            _fbGroups.RemoveAt(index);
            BindData();
        }

        private void buttonAddGroup_Click(object sender, EventArgs e)
        {
            var id = textBoxGroupID.Text;
            var group = _fbRequest.GetGroup(id);
            if (group != null)
            {
                _fbGroups.Add(group);
                BindData();
                errorProvider1.Clear();                                 
            }
            else
            {
                errorProvider1.SetError(buttonAddGroup, "Wrong id or token is invalid");                                
            }
        }

        private void buttonSaveToken_Click(object sender, EventArgs e)
        {
            var token = textBoxFBToken.Text;
            if (TokenValidation(token))
            {
                labelTokenSaved.Visible = true;
                _fbRequest.SetToken(token);
                Properties.Settings.Default.accessToken = token;
                Properties.Settings.Default.Save();
            }
        }

        private void button_add_post_Click(object sender, EventArgs e)
        {
            var link = textBoxImgLink.Text;
            string message = textBoxMessage.Text;
            string name;
            string description;
            if (textBoxMessage.Text == plchldrMessage)
                message = "";
            else
                message = textBoxMessage.Text;
            if (textBoxName.Text == plchldrName)
                name = "";
            else
                name = textBoxName.Text;
            if (richTextDescription.Text == plchldrDescription)
                description = "";
            else
                description = richTextDescription.Text;

            Properties.Settings.Default.link = link;
            Properties.Settings.Default.message = message;
            Properties.Settings.Default.name = name;
            Properties.Settings.Default.description = description;
            Properties.Settings.Default.Save();

            if (
                (!String.IsNullOrEmpty(_imgFileName) 
                || !String.IsNullOrEmpty(link) 
                || !String.IsNullOrEmpty(message)
                )
                && _fbRequest.IsValidToken())
            {
                errorProvider1.Clear();
                (new Form2(new FbPost(link, message, name, description, _imgFileName), _fbGroups, _fbRequest)).Show();
            }
            else
            {
                if (String.IsNullOrEmpty(link) && String.IsNullOrEmpty(message))
                    errorProvider1.SetError(button_add_post, "You should choose message or photo");                
                else
                    errorProvider1.SetError(button_add_post, "Token is invalid");
                textBoxMessage_Leave(this, e);
                textBoxName_Leave(this, e);
                richTextDescription_Leave(this, e);
            }
        }

        public bool TokenValidation(string token)
        {
            if (!_fbRequest.IsValidToken(token))
            {
                errorProvider1.SetError(textBoxFBToken, "Enter valid token");
                return false;
            }
            errorProvider1.Clear();
            return true;
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://developers.facebook.com/tools/explorer");
        }

        static void SaveGroups(List<FbGroup> groups)
        {
            using (var ms = new MemoryStream())
            {
                var bf = new BinaryFormatter();
                bf.Serialize(ms, groups);
                ms.Position = 0;
                var buffer = new byte[(int)ms.Length];
                ms.Read(buffer, 0, buffer.Length);
                Properties.Settings.Default.groups = Convert.ToBase64String(buffer);
                Properties.Settings.Default.Save();
            }
        }

        static List<FbGroup> LoadGroups()
        {
            if (String.IsNullOrEmpty(Properties.Settings.Default.groups))
                return new List<FbGroup>();

            using (var ms = new MemoryStream(Convert.FromBase64String(Properties.Settings.Default.groups)))
            {
                var bf = new BinaryFormatter();
                return (List<FbGroup>)bf.Deserialize(ms);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                //buttonUploadImg.Text = openFileDialog1.SafeFileName;
                textBoxImgLink.Text = "";
                Properties.Settings.Default.link = "";
                Properties.Settings.Default.Save();

                _imgFileName = openFileDialog1.FileName;
                buttonUploadImg.Image = Image.FromFile(_imgFileName).GetThumbnailImage(60, 60, null, IntPtr.Zero);
                buttonRemoveImg.Visible = true;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            _imgFileName = "";
            textBoxImgLink.Text = "";
            Properties.Settings.Default.link = "";
            Properties.Settings.Default.Save();
            buttonUploadImg.Image = FacebookSeller.Properties.Resources.photo_icon;
            buttonRemoveImg.Visible = false;
        }

        private void textBoxImgLink_TextChanged(object sender, EventArgs e)
        {
            _imgFileName = "";
            buttonUploadImg.Text = textBoxImgLink.Text;
            buttonUploadImg.Image = FacebookSeller.Properties.Resources.photo_icon;
            buttonRemoveImg.Visible = false;
            Properties.Settings.Default.Save();
            buttonRemoveImg.Visible = true;
        }

        private void textBoxMessage_Enter(object sender, EventArgs e)
        {
            if (textBoxMessage.Text == plchldrMessage)
            {
                textBoxMessage.Text = "";
            }
        }

        private void textBoxMessage_Leave(object sender, EventArgs e)
        {
            if (textBoxMessage.Text == "")
            {
                textBoxMessage.Text = plchldrMessage;
            }
        }

        private void textBoxName_Enter(object sender, EventArgs e)
        {
            if (textBoxName.Text == plchldrName)
            {
                textBoxName.Text = "";
            }
        }

        private void textBoxName_Leave(object sender, EventArgs e)
        {
            if (textBoxName.Text == "")
            {
                textBoxName.Text = plchldrName;
            }
        }

        private void richTextDescription_Enter(object sender, EventArgs e)
        {
            if (richTextDescription.Text == plchldrDescription)
            {
                richTextDescription.Text = "";
            }
        }

        private void richTextDescription_Leave(object sender, EventArgs e)
        {
            if (richTextDescription.Text == "")
            {
                richTextDescription.Text = plchldrDescription;
            }
        }
    }
}
