﻿namespace WatchDog_V1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.addButton = new System.Windows.Forms.Button();
            this.watchDogButton = new System.Windows.Forms.Button();
            this.securityButton = new System.Windows.Forms.Button();
            this.eventLogButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.goButton = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.iconList = new System.Windows.Forms.ImageList(this.components);
            this.filePathTextBox = new System.Windows.Forms.TextBox();
            this.fileName = new System.Windows.Forms.Label();
            this.fileType = new System.Windows.Forms.Label();
            this.fileTypeLabel = new System.Windows.Forms.Label();
            this.fileNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addButton.BackColor = System.Drawing.Color.Black;
            this.addButton.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.addButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.addButton.Location = new System.Drawing.Point(45, 25);
            this.addButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(214, 97);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "ADD";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // watchDogButton
            // 
            this.watchDogButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.watchDogButton.BackColor = System.Drawing.Color.Black;
            this.watchDogButton.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.watchDogButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.watchDogButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.watchDogButton.Location = new System.Drawing.Point(889, 25);
            this.watchDogButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.watchDogButton.Name = "watchDogButton";
            this.watchDogButton.Size = new System.Drawing.Size(214, 97);
            this.watchDogButton.TabIndex = 4;
            this.watchDogButton.Text = "WATCHDOG";
            this.watchDogButton.UseVisualStyleBackColor = false;
            this.watchDogButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // securityButton
            // 
            this.securityButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.securityButton.BackColor = System.Drawing.Color.Black;
            this.securityButton.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.securityButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.securityButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.securityButton.Location = new System.Drawing.Point(609, 25);
            this.securityButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.securityButton.Name = "securityButton";
            this.securityButton.Size = new System.Drawing.Size(214, 97);
            this.securityButton.TabIndex = 4;
            this.securityButton.Text = "SECURITY";
            this.securityButton.UseVisualStyleBackColor = false;
            this.securityButton.Click += new System.EventHandler(this.button5_Click);
            // 
            // eventLogButton
            // 
            this.eventLogButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.eventLogButton.BackColor = System.Drawing.Color.Black;
            this.eventLogButton.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.eventLogButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventLogButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.eventLogButton.Location = new System.Drawing.Point(329, 25);
            this.eventLogButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.eventLogButton.Name = "eventLogButton";
            this.eventLogButton.Size = new System.Drawing.Size(214, 97);
            this.eventLogButton.TabIndex = 4;
            this.eventLogButton.Text = "EVENTLOG";
            this.eventLogButton.UseVisualStyleBackColor = false;
            this.eventLogButton.Click += new System.EventHandler(this.button6_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(45, 141);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 26);
            this.backButton.TabIndex = 5;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // goButton
            // 
            this.goButton.Location = new System.Drawing.Point(1028, 141);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(75, 26);
            this.goButton.TabIndex = 6;
            this.goButton.Text = "Go";
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.LargeImageList = this.iconList;
            this.listView1.Location = new System.Drawing.Point(45, 183);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1058, 478);
            this.listView1.SmallImageList = this.iconList;
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView1_ItemSelectionChanged);
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // iconList
            // 
            this.iconList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iconList.ImageStream")));
            this.iconList.TransparentColor = System.Drawing.Color.Transparent;
            this.iconList.Images.SetKeyName(0, "Basic-Document-Blank.ico");
            this.iconList.Images.SetKeyName(1, "Folders-Windows-Folder.ico");
            this.iconList.Images.SetKeyName(2, "mp3.ico");
            this.iconList.Images.SetKeyName(3, "exe.ico");
            this.iconList.Images.SetKeyName(4, "mp4.ico");
            this.iconList.Images.SetKeyName(5, "pdf.ico");
            this.iconList.Images.SetKeyName(6, "doc.ico");
            this.iconList.Images.SetKeyName(7, "png.ico");
            // 
            // filePathTextBox
            // 
            this.filePathTextBox.Location = new System.Drawing.Point(126, 141);
            this.filePathTextBox.Name = "filePathTextBox";
            this.filePathTextBox.Size = new System.Drawing.Size(896, 26);
            this.filePathTextBox.TabIndex = 8;
            // 
            // fileName
            // 
            this.fileName.AutoSize = true;
            this.fileName.ForeColor = System.Drawing.SystemColors.Control;
            this.fileName.Location = new System.Drawing.Point(62, 678);
            this.fileName.Name = "fileName";
            this.fileName.Size = new System.Drawing.Size(80, 20);
            this.fileName.TabIndex = 9;
            this.fileName.Text = "File Name";
            // 
            // fileType
            // 
            this.fileType.AutoSize = true;
            this.fileType.ForeColor = System.Drawing.SystemColors.Control;
            this.fileType.Location = new System.Drawing.Point(751, 678);
            this.fileType.Name = "fileType";
            this.fileType.Size = new System.Drawing.Size(72, 20);
            this.fileType.TabIndex = 11;
            this.fileType.Text = "File Type";
            // 
            // fileTypeLabel
            // 
            this.fileTypeLabel.AutoSize = true;
            this.fileTypeLabel.ForeColor = System.Drawing.Color.White;
            this.fileTypeLabel.Location = new System.Drawing.Point(885, 678);
            this.fileTypeLabel.Name = "fileTypeLabel";
            this.fileTypeLabel.Size = new System.Drawing.Size(19, 20);
            this.fileTypeLabel.TabIndex = 12;
            this.fileTypeLabel.Text = "--";
            // 
            // fileNameLabel
            // 
            this.fileNameLabel.AutoSize = true;
            this.fileNameLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.fileNameLabel.Location = new System.Drawing.Point(212, 678);
            this.fileNameLabel.Name = "fileNameLabel";
            this.fileNameLabel.Size = new System.Drawing.Size(19, 20);
            this.fileNameLabel.TabIndex = 10;
            this.fileNameLabel.Text = "--";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(1176, 749);
            this.Controls.Add(this.fileTypeLabel);
            this.Controls.Add(this.fileType);
            this.Controls.Add(this.fileNameLabel);
            this.Controls.Add(this.fileName);
            this.Controls.Add(this.filePathTextBox);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.goButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.watchDogButton);
            this.Controls.Add(this.securityButton);
            this.Controls.Add(this.eventLogButton);
            this.Controls.Add(this.addButton);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WatchDog";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button watchDogButton;
        private System.Windows.Forms.Button securityButton;
        private System.Windows.Forms.Button eventLogButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button goButton;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox filePathTextBox;
        private System.Windows.Forms.Label fileName;
        private System.Windows.Forms.Label fileType;
        private System.Windows.Forms.Label fileTypeLabel;
        private System.Windows.Forms.ImageList iconList;
        private System.Windows.Forms.Label fileNameLabel;
    }
}