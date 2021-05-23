namespace WatchDog_V1
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lockFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makeReadOnlyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filePathTextBox = new System.Windows.Forms.TextBox();
            this.fileName = new System.Windows.Forms.Label();
            this.fileType = new System.Windows.Forms.Label();
            this.fileTypeLabel = new System.Windows.Forms.Label();
            this.fileNameLabel = new System.Windows.Forms.Label();
            this.makeExecuteOnlyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encryptFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decryptFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.AutoSize = true;
            this.addButton.BackColor = System.Drawing.Color.Black;
            this.addButton.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.addButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.addButton.Location = new System.Drawing.Point(30, 16);
            this.addButton.Name = "addButton";
            this.addButton.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.addButton.Size = new System.Drawing.Size(140, 60);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "ADD";
            this.addButton.UseVisualStyleBackColor = false;
            // 
            // watchDogButton
            // 
            this.watchDogButton.AutoSize = true;
            this.watchDogButton.BackColor = System.Drawing.Color.Black;
            this.watchDogButton.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.watchDogButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.watchDogButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.watchDogButton.Location = new System.Drawing.Point(593, 16);
            this.watchDogButton.Name = "watchDogButton";
            this.watchDogButton.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.watchDogButton.Size = new System.Drawing.Size(140, 60);
            this.watchDogButton.TabIndex = 4;
            this.watchDogButton.Text = "WATCHDOG";
            this.watchDogButton.UseVisualStyleBackColor = false;
            this.watchDogButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // securityButton
            // 
            this.securityButton.AutoSize = true;
            this.securityButton.BackColor = System.Drawing.Color.Black;
            this.securityButton.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.securityButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.securityButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.securityButton.Location = new System.Drawing.Point(406, 16);
            this.securityButton.Name = "securityButton";
            this.securityButton.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.securityButton.Size = new System.Drawing.Size(140, 60);
            this.securityButton.TabIndex = 4;
            this.securityButton.Text = "SECURITY";
            this.securityButton.UseVisualStyleBackColor = false;
            // 
            // eventLogButton
            // 
            this.eventLogButton.AutoSize = true;
            this.eventLogButton.BackColor = System.Drawing.Color.Black;
            this.eventLogButton.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.eventLogButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventLogButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.eventLogButton.Location = new System.Drawing.Point(219, 16);
            this.eventLogButton.Name = "eventLogButton";
            this.eventLogButton.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.eventLogButton.Size = new System.Drawing.Size(140, 60);
            this.eventLogButton.TabIndex = 4;
            this.eventLogButton.Text = "EVENTLOG";
            this.eventLogButton.UseVisualStyleBackColor = false;
            this.eventLogButton.Click += new System.EventHandler(this.button6_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(30, 92);
            this.backButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(50, 23);
            this.backButton.TabIndex = 5;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // goButton
            // 
            this.goButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.goButton.Location = new System.Drawing.Point(685, 92);
            this.goButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(50, 23);
            this.goButton.TabIndex = 6;
            this.goButton.Text = "Go";
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.HideSelection = false;
            this.listView1.LargeImageList = this.iconList;
            this.listView1.Location = new System.Drawing.Point(30, 119);
            this.listView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(707, 312);
            this.listView1.SmallImageList = this.iconList;
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView1_ItemSelectionChanged);
            this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // iconList
            // 
            this.iconList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iconList.ImageStream")));
            this.iconList.TransparentColor = System.Drawing.Color.Transparent;
            this.iconList.Images.SetKeyName(0, "blank.ico");
            this.iconList.Images.SetKeyName(1, "folder.ico");
            this.iconList.Images.SetKeyName(2, "mp3.ico");
            this.iconList.Images.SetKeyName(3, "exe.ico");
            this.iconList.Images.SetKeyName(4, "mp4.ico");
            this.iconList.Images.SetKeyName(5, "pdf.ico");
            this.iconList.Images.SetKeyName(6, "doc.ico");
            this.iconList.Images.SetKeyName(7, "png.ico");
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lockFileToolStripMenuItem,
            this.makeReadOnlyToolStripMenuItem,
            this.encryptFileToolStripMenuItem,
            this.decryptFileToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 114);
            // 
            // lockFileToolStripMenuItem
            // 
            this.lockFileToolStripMenuItem.Name = "lockFileToolStripMenuItem";
            this.lockFileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.lockFileToolStripMenuItem.Text = "Lock File";
            this.lockFileToolStripMenuItem.Click += new System.EventHandler(this.lockFileToolStripMenuItem_Click);
            // 
            // makeReadOnlyToolStripMenuItem
            // 
            this.makeReadOnlyToolStripMenuItem.Name = "makeReadOnlyToolStripMenuItem";
            this.makeReadOnlyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.makeReadOnlyToolStripMenuItem.Text = "Unlock File";
            this.makeReadOnlyToolStripMenuItem.Click += new System.EventHandler(this.makeReadOnlyToolStripMenuItem_Click);
            // 
            // filePathTextBox
            // 
            this.filePathTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filePathTextBox.Location = new System.Drawing.Point(84, 92);
            this.filePathTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.filePathTextBox.Name = "filePathTextBox";
            this.filePathTextBox.Size = new System.Drawing.Size(599, 20);
            this.filePathTextBox.TabIndex = 8;
            // 
            // fileName
            // 
            this.fileName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.fileName.AutoSize = true;
            this.fileName.ForeColor = System.Drawing.SystemColors.Control;
            this.fileName.Location = new System.Drawing.Point(41, 441);
            this.fileName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fileName.Name = "fileName";
            this.fileName.Size = new System.Drawing.Size(54, 13);
            this.fileName.TabIndex = 9;
            this.fileName.Text = "File Name";
            // 
            // fileType
            // 
            this.fileType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fileType.AutoSize = true;
            this.fileType.ForeColor = System.Drawing.SystemColors.Control;
            this.fileType.Location = new System.Drawing.Point(501, 441);
            this.fileType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fileType.Name = "fileType";
            this.fileType.Size = new System.Drawing.Size(50, 13);
            this.fileType.TabIndex = 11;
            this.fileType.Text = "File Type";
            // 
            // fileTypeLabel
            // 
            this.fileTypeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fileTypeLabel.AutoSize = true;
            this.fileTypeLabel.ForeColor = System.Drawing.Color.White;
            this.fileTypeLabel.Location = new System.Drawing.Point(590, 441);
            this.fileTypeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fileTypeLabel.Name = "fileTypeLabel";
            this.fileTypeLabel.Size = new System.Drawing.Size(13, 13);
            this.fileTypeLabel.TabIndex = 12;
            this.fileTypeLabel.Text = "--";
            // 
            // fileNameLabel
            // 
            this.fileNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.fileNameLabel.AutoSize = true;
            this.fileNameLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.fileNameLabel.Location = new System.Drawing.Point(141, 441);
            this.fileNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fileNameLabel.Name = "fileNameLabel";
            this.fileNameLabel.Size = new System.Drawing.Size(13, 13);
            this.fileNameLabel.TabIndex = 10;
            this.fileNameLabel.Text = "--";
            // 
            // makeExecuteOnlyToolStripMenuItem
            // 
            this.makeExecuteOnlyToolStripMenuItem.Name = "makeExecuteOnlyToolStripMenuItem";
            this.makeExecuteOnlyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.makeExecuteOnlyToolStripMenuItem.Text = "Make Execute Only";
            // 
            // encryptFileToolStripMenuItem
            // 
            this.encryptFileToolStripMenuItem.Name = "encryptFileToolStripMenuItem";
            this.encryptFileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.encryptFileToolStripMenuItem.Text = "Encrypt File";
            this.encryptFileToolStripMenuItem.Click += new System.EventHandler(this.encryptFileToolStripMenuItem_Click);
            // 
            // decryptFileToolStripMenuItem
            // 
            this.decryptFileToolStripMenuItem.Name = "decryptFileToolStripMenuItem";
            this.decryptFileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.decryptFileToolStripMenuItem.Text = "Decrypt File";
            this.decryptFileToolStripMenuItem.Click += new System.EventHandler(this.decryptFileToolStripMenuItem_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(784, 487);
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
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WatchDog";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.contextMenuStrip1.ResumeLayout(false);
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
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem lockFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem makeReadOnlyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem makeExecuteOnlyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem encryptFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decryptFileToolStripMenuItem;
    }
}