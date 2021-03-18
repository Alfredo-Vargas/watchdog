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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
<<<<<<< HEAD
            this.ADD_FBD = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.txtFolder = new System.Windows.Forms.TextBox();
            this.TOOLS_BUTTON = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.FILENAME_LABEL = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ADD_FBD
            // 
            this.ADD_FBD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ADD_FBD.BackColor = System.Drawing.Color.Black;
            this.ADD_FBD.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.ADD_FBD.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ADD_FBD.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ADD_FBD.Location = new System.Drawing.Point(22, 12);
            this.ADD_FBD.Name = "ADD_FBD";
            this.ADD_FBD.Size = new System.Drawing.Size(143, 63);
            this.ADD_FBD.TabIndex = 4;
            this.ADD_FBD.Text = "ADD";
            this.ADD_FBD.UseVisualStyleBackColor = false;
            this.ADD_FBD.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtFolder
            // 
            this.txtFolder.Location = new System.Drawing.Point(105, 95);
            this.txtFolder.Margin = new System.Windows.Forms.Padding(2);
            this.txtFolder.Multiline = true;
            this.txtFolder.Name = "txtFolder";
            this.txtFolder.Size = new System.Drawing.Size(560, 22);
            this.txtFolder.TabIndex = 5;
            this.txtFolder.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TOOLS_BUTTON
            // 
            this.TOOLS_BUTTON.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TOOLS_BUTTON.BackColor = System.Drawing.Color.Black;
            this.TOOLS_BUTTON.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.TOOLS_BUTTON.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TOOLS_BUTTON.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.TOOLS_BUTTON.Location = new System.Drawing.Point(220, 12);
            this.TOOLS_BUTTON.Name = "TOOLS_BUTTON";
            this.TOOLS_BUTTON.Size = new System.Drawing.Size(143, 63);
            this.TOOLS_BUTTON.TabIndex = 6;
            this.TOOLS_BUTTON.Text = "SECURITY";
            this.TOOLS_BUTTON.UseVisualStyleBackColor = false;
            this.TOOLS_BUTTON.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(416, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 63);
            this.button1.TabIndex = 7;
            this.button1.Text = "EVENTLOG";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.button2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(602, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 63);
            this.button2.TabIndex = 8;
            this.button2.Text = "WATCHDOG";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button4_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(272, 253);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(473, 123);
            this.listView1.TabIndex = 9;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // FILENAME_LABEL
            // 
            this.FILENAME_LABEL.AutoSize = true;
            this.FILENAME_LABEL.BackColor = System.Drawing.SystemColors.ControlText;
            this.FILENAME_LABEL.ForeColor = System.Drawing.SystemColors.Control;
            this.FILENAME_LABEL.Location = new System.Drawing.Point(102, 439);
            this.FILENAME_LABEL.Name = "FILENAME_LABEL";
            this.FILENAME_LABEL.Size = new System.Drawing.Size(51, 13);
            this.FILENAME_LABEL.TabIndex = 10;
            this.FILENAME_LABEL.Text = "FileName";
            this.FILENAME_LABEL.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(220, 439);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "--";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(407, 439);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "File Type";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(590, 438);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "--";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(22, 93);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 14;
            this.button3.Text = "Back";
            this.button3.UseVisualStyleBackColor = true;
=======
            this.add_fbd = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.txtFolder = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // add_fbd
            // 
            this.add_fbd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.add_fbd.BackColor = System.Drawing.Color.Black;
            this.add_fbd.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.add_fbd.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_fbd.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.add_fbd.Location = new System.Drawing.Point(30, 16);
            this.add_fbd.Name = "add_fbd";
            this.add_fbd.Size = new System.Drawing.Size(143, 63);
            this.add_fbd.TabIndex = 4;
            this.add_fbd.Text = "ADD";
            this.add_fbd.UseVisualStyleBackColor = false;
            this.add_fbd.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.button3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.Location = new System.Drawing.Point(623, 16);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(143, 63);
            this.button3.TabIndex = 4;
            this.button3.Text = "SETTINGS";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button5.BackColor = System.Drawing.Color.Black;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.button5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button5.Location = new System.Drawing.Point(475, 16);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(143, 63);
            this.button5.TabIndex = 4;
            this.button5.Text = "SECURITY";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button6.BackColor = System.Drawing.Color.Black;
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.button6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button6.Location = new System.Drawing.Point(326, 16);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(143, 63);
            this.button6.TabIndex = 4;
            this.button6.Text = "EVENTLOG";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
>>>>>>> 659c4eff640e98fc16368a843deb7111d727a50e
            // 
            // button4
            // 
<<<<<<< HEAD
            this.button4.Location = new System.Drawing.Point(670, 94);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 15;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
=======
            this.txtFolder.Location = new System.Drawing.Point(45, 133);
            this.txtFolder.Margin = new System.Windows.Forms.Padding(2);
            this.txtFolder.Multiline = true;
            this.txtFolder.Name = "txtFolder";
            this.txtFolder.Size = new System.Drawing.Size(375, 262);
            this.txtFolder.TabIndex = 5;
            this.txtFolder.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
>>>>>>> 659c4eff640e98fc16368a843deb7111d727a50e
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(179, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 63);
            this.button1.TabIndex = 6;
            this.button1.Text = "TOOLS";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(784, 487);
<<<<<<< HEAD
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FILENAME_LABEL);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TOOLS_BUTTON);
            this.Controls.Add(this.txtFolder);
            this.Controls.Add(this.ADD_FBD);
=======
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtFolder);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.add_fbd);
>>>>>>> 659c4eff640e98fc16368a843deb7111d727a50e
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WatchDog";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
<<<<<<< HEAD
        private System.Windows.Forms.Button ADD_FBD;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox txtFolder;
        private System.Windows.Forms.Button TOOLS_BUTTON;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label FILENAME_LABEL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
=======
        private System.Windows.Forms.Button add_fbd;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox txtFolder;
        private System.Windows.Forms.Button button1;
>>>>>>> 659c4eff640e98fc16368a843deb7111d727a50e
    }
}