namespace FacebookSeller
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_add_post = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.pagePost = new System.Windows.Forms.TabPage();
            this.buttonRemoveImg = new System.Windows.Forms.Button();
            this.buttonUploadImg = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.richTextDescription = new System.Windows.Forms.RichTextBox();
            this.textBoxImgLink = new System.Windows.Forms.TextBox();
            this.pageGroups = new System.Windows.Forms.TabPage();
            this.buttonRemoveGroup = new System.Windows.Forms.Button();
            this.listBoxGroups = new System.Windows.Forms.ListBox();
            this.textBoxGroupID = new System.Windows.Forms.TextBox();
            this.buttonAddGroup = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.pageSettings = new System.Windows.Forms.TabPage();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.labelTokenSaved = new System.Windows.Forms.Label();
            this.labelCurrentToken = new System.Windows.Forms.Label();
            this.buttonSaveToken = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxFBToken = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1.SuspendLayout();
            this.pagePost.SuspendLayout();
            this.pageGroups.SuspendLayout();
            this.pageSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Or link Image:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Message:";
            // 
            // button_add_post
            // 
            this.button_add_post.Location = new System.Drawing.Point(270, 178);
            this.button_add_post.Name = "button_add_post";
            this.button_add_post.Size = new System.Drawing.Size(75, 23);
            this.button_add_post.TabIndex = 6;
            this.button_add_post.Text = "Add";
            this.button_add_post.UseVisualStyleBackColor = true;
            this.button_add_post.Click += new System.EventHandler(this.button_add_post_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.pagePost);
            this.tabControl1.Controls.Add(this.pageGroups);
            this.tabControl1.Controls.Add(this.pageSettings);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(364, 233);
            this.tabControl1.TabIndex = 1;
            // 
            // pagePost
            // 
            this.pagePost.Controls.Add(this.buttonRemoveImg);
            this.pagePost.Controls.Add(this.buttonUploadImg);
            this.pagePost.Controls.Add(this.label6);
            this.pagePost.Controls.Add(this.textBoxName);
            this.pagePost.Controls.Add(this.label5);
            this.pagePost.Controls.Add(this.textBoxMessage);
            this.pagePost.Controls.Add(this.richTextDescription);
            this.pagePost.Controls.Add(this.textBoxImgLink);
            this.pagePost.Controls.Add(this.button_add_post);
            this.pagePost.Controls.Add(this.label2);
            this.pagePost.Controls.Add(this.label1);
            this.pagePost.Location = new System.Drawing.Point(4, 22);
            this.pagePost.Name = "pagePost";
            this.pagePost.Padding = new System.Windows.Forms.Padding(3);
            this.pagePost.Size = new System.Drawing.Size(356, 207);
            this.pagePost.TabIndex = 0;
            this.pagePost.Text = "Post";
            this.pagePost.UseVisualStyleBackColor = true;
            // 
            // buttonRemoveImg
            // 
            this.buttonRemoveImg.Location = new System.Drawing.Point(166, 8);
            this.buttonRemoveImg.Name = "buttonRemoveImg";
            this.buttonRemoveImg.Size = new System.Drawing.Size(17, 21);
            this.buttonRemoveImg.TabIndex = 15;
            this.buttonRemoveImg.Text = "x";
            this.buttonRemoveImg.UseVisualStyleBackColor = true;
            this.buttonRemoveImg.Visible = false;
            this.buttonRemoveImg.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // buttonUploadImg
            // 
            this.buttonUploadImg.Image = global::FacebookSeller.Properties.Resources.photo_icon;
            this.buttonUploadImg.Location = new System.Drawing.Point(9, 6);
            this.buttonUploadImg.Name = "buttonUploadImg";
            this.buttonUploadImg.Size = new System.Drawing.Size(151, 69);
            this.buttonUploadImg.TabIndex = 1;
            this.buttonUploadImg.UseVisualStyleBackColor = true;
            this.buttonUploadImg.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(206, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Description:";
            // 
            // textBoxName
            // 
            this.textBoxName.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::FacebookSeller.Properties.Settings.Default, "name", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxName.Location = new System.Drawing.Point(8, 178);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(163, 20);
            this.textBoxName.TabIndex = 4;
            this.textBoxName.Text = global::FacebookSeller.Properties.Settings.Default.name;
            this.textBoxName.Enter += new System.EventHandler(this.textBoxName_Enter);
            this.textBoxName.Leave += new System.EventHandler(this.textBoxName_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Name:";
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::FacebookSeller.Properties.Settings.Default, "message", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxMessage.Location = new System.Drawing.Point(8, 136);
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.Size = new System.Drawing.Size(163, 20);
            this.textBoxMessage.TabIndex = 3;
            this.textBoxMessage.Text = global::FacebookSeller.Properties.Settings.Default.message;
            this.textBoxMessage.Enter += new System.EventHandler(this.textBoxMessage_Enter);
            this.textBoxMessage.Leave += new System.EventHandler(this.textBoxMessage_Leave);
            // 
            // richTextDescription
            // 
            this.richTextDescription.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::FacebookSeller.Properties.Settings.Default, "description", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.richTextDescription.Location = new System.Drawing.Point(209, 28);
            this.richTextDescription.Name = "richTextDescription";
            this.richTextDescription.Size = new System.Drawing.Size(136, 144);
            this.richTextDescription.TabIndex = 5;
            this.richTextDescription.Text = global::FacebookSeller.Properties.Settings.Default.description;
            this.richTextDescription.Enter += new System.EventHandler(this.richTextDescription_Enter);
            this.richTextDescription.Leave += new System.EventHandler(this.richTextDescription_Leave);
            // 
            // textBoxImgLink
            // 
            this.textBoxImgLink.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::FacebookSeller.Properties.Settings.Default, "link", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxImgLink.Location = new System.Drawing.Point(6, 93);
            this.textBoxImgLink.Name = "textBoxImgLink";
            this.textBoxImgLink.Size = new System.Drawing.Size(164, 20);
            this.textBoxImgLink.TabIndex = 2;
            this.textBoxImgLink.Text = global::FacebookSeller.Properties.Settings.Default.link;
            this.textBoxImgLink.TextChanged += new System.EventHandler(this.textBoxImgLink_TextChanged);
            // 
            // pageGroups
            // 
            this.pageGroups.Controls.Add(this.buttonRemoveGroup);
            this.pageGroups.Controls.Add(this.listBoxGroups);
            this.pageGroups.Controls.Add(this.textBoxGroupID);
            this.pageGroups.Controls.Add(this.buttonAddGroup);
            this.pageGroups.Controls.Add(this.label4);
            this.pageGroups.Location = new System.Drawing.Point(4, 22);
            this.pageGroups.Name = "pageGroups";
            this.pageGroups.Padding = new System.Windows.Forms.Padding(3);
            this.pageGroups.Size = new System.Drawing.Size(356, 207);
            this.pageGroups.TabIndex = 1;
            this.pageGroups.Text = "Groups";
            this.pageGroups.UseVisualStyleBackColor = true;
            // 
            // buttonRemoveGroup
            // 
            this.buttonRemoveGroup.Location = new System.Drawing.Point(181, 170);
            this.buttonRemoveGroup.Name = "buttonRemoveGroup";
            this.buttonRemoveGroup.Size = new System.Drawing.Size(75, 23);
            this.buttonRemoveGroup.TabIndex = 4;
            this.buttonRemoveGroup.Text = "Remove";
            this.buttonRemoveGroup.UseVisualStyleBackColor = true;
            this.buttonRemoveGroup.Click += new System.EventHandler(this.buttonRemoveGroup_Click);
            // 
            // listBoxGroups
            // 
            this.listBoxGroups.FormattingEnabled = true;
            this.listBoxGroups.Location = new System.Drawing.Point(6, 7);
            this.listBoxGroups.Name = "listBoxGroups";
            this.listBoxGroups.Size = new System.Drawing.Size(166, 186);
            this.listBoxGroups.TabIndex = 3;
            // 
            // textBoxGroupID
            // 
            this.textBoxGroupID.Location = new System.Drawing.Point(206, 23);
            this.textBoxGroupID.Name = "textBoxGroupID";
            this.textBoxGroupID.Size = new System.Drawing.Size(139, 20);
            this.textBoxGroupID.TabIndex = 1;
            // 
            // buttonAddGroup
            // 
            this.buttonAddGroup.Location = new System.Drawing.Point(206, 49);
            this.buttonAddGroup.Name = "buttonAddGroup";
            this.buttonAddGroup.Size = new System.Drawing.Size(75, 23);
            this.buttonAddGroup.TabIndex = 2;
            this.buttonAddGroup.Text = "Add";
            this.buttonAddGroup.UseVisualStyleBackColor = true;
            this.buttonAddGroup.Click += new System.EventHandler(this.buttonAddGroup_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(203, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Group ID:";
            // 
            // pageSettings
            // 
            this.pageSettings.Controls.Add(this.linkLabel1);
            this.pageSettings.Controls.Add(this.labelTokenSaved);
            this.pageSettings.Controls.Add(this.labelCurrentToken);
            this.pageSettings.Controls.Add(this.buttonSaveToken);
            this.pageSettings.Controls.Add(this.label3);
            this.pageSettings.Controls.Add(this.textBoxFBToken);
            this.pageSettings.Location = new System.Drawing.Point(4, 22);
            this.pageSettings.Name = "pageSettings";
            this.pageSettings.Padding = new System.Windows.Forms.Padding(3);
            this.pageSettings.Size = new System.Drawing.Size(356, 207);
            this.pageSettings.TabIndex = 2;
            this.pageSettings.Text = "Settings";
            this.pageSettings.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(11, 188);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(72, 13);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "follow this link";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.Blue;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // labelTokenSaved
            // 
            this.labelTokenSaved.AutoSize = true;
            this.labelTokenSaved.Location = new System.Drawing.Point(238, 23);
            this.labelTokenSaved.Name = "labelTokenSaved";
            this.labelTokenSaved.Size = new System.Drawing.Size(22, 13);
            this.labelTokenSaved.TabIndex = 7;
            this.labelTokenSaved.Text = "OK";
            this.labelTokenSaved.Visible = false;
            // 
            // labelCurrentToken
            // 
            this.labelCurrentToken.AutoSize = true;
            this.labelCurrentToken.Location = new System.Drawing.Point(71, 3);
            this.labelCurrentToken.Name = "labelCurrentToken";
            this.labelCurrentToken.Size = new System.Drawing.Size(0, 13);
            this.labelCurrentToken.TabIndex = 6;
            // 
            // buttonSaveToken
            // 
            this.buttonSaveToken.Location = new System.Drawing.Point(8, 46);
            this.buttonSaveToken.Name = "buttonSaveToken";
            this.buttonSaveToken.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveToken.TabIndex = 2;
            this.buttonSaveToken.Text = "Save";
            this.buttonSaveToken.UseVisualStyleBackColor = true;
            this.buttonSaveToken.Click += new System.EventHandler(this.buttonSaveToken_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "FB Token:";
            // 
            // textBoxFBToken
            // 
            this.textBoxFBToken.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::FacebookSeller.Properties.Settings.Default, "accessToken", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxFBToken.Location = new System.Drawing.Point(8, 20);
            this.textBoxFBToken.Name = "textBoxFBToken";
            this.textBoxFBToken.Size = new System.Drawing.Size(224, 20);
            this.textBoxFBToken.TabIndex = 1;
            this.textBoxFBToken.Text = global::FacebookSeller.Properties.Settings.Default.accessToken;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "All Images|*.BMP;*.DIB;*.RLE;*.JPG;*.JPEG;*.JPE;*.JFIF;*.GIF;*.TIF;*.TIFF;*.PNG";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 229);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(377, 268);
            this.MinimumSize = new System.Drawing.Size(377, 268);
            this.Name = "Form1";
            this.Text = "FBSeller";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.pagePost.ResumeLayout(false);
            this.pagePost.PerformLayout();
            this.pageGroups.ResumeLayout(false);
            this.pageGroups.PerformLayout();
            this.pageSettings.ResumeLayout(false);
            this.pageSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_add_post;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage pagePost;
        private System.Windows.Forms.TabPage pageGroups;
        private System.Windows.Forms.TabPage pageSettings;
        private System.Windows.Forms.TextBox textBoxFBToken;
        private System.Windows.Forms.Button buttonSaveToken;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextDescription;
        private System.Windows.Forms.TextBox textBoxImgLink;
        private System.Windows.Forms.Button buttonRemoveGroup;
        private System.Windows.Forms.ListBox listBoxGroups;
        private System.Windows.Forms.TextBox textBoxGroupID;
        private System.Windows.Forms.Button buttonAddGroup;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelCurrentToken;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxMessage;
        private System.Windows.Forms.Label labelTokenSaved;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button buttonUploadImg;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button buttonRemoveImg;


    }
}

