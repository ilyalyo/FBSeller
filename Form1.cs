﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace FacebookSeller
{
    public partial class Form1 : Form
    {
        private readonly List<FbGroup> _fbGroups;
        private readonly FbRequest _fbRequest;
        private string _imgFileName;
        public Form1()
        {
            InitializeComponent();
            _fbRequest = new FbRequest(Properties.Settings.Default.accessToken);
            _fbGroups = LoadGroups();
            BindData();
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
            var message = textBoxMessage.Text;
            var name = textBoxName.Text;
            var description = richTextDescription.Text;

            Properties.Settings.Default.link = link;
            Properties.Settings.Default.message = message;
            Properties.Settings.Default.name = name;
            Properties.Settings.Default.description = description;
            Properties.Settings.Default.Save();

            if (
                (!String.IsNullOrEmpty(_imgFileName) 
                ||  !String.IsNullOrEmpty(link) 
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
                buttonUploadImg.Text = openFileDialog1.SafeFileName;
                textBoxImgLink.Text = "";
                Properties.Settings.Default.link = "";
                Properties.Settings.Default.Save();

                _imgFileName = openFileDialog1.FileName;
                buttonRemoveImg.Visible = true;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            _imgFileName = "";
            buttonUploadImg.Text = @"Upload Image:";
            buttonRemoveImg.Visible = false;
        }
    }
}
