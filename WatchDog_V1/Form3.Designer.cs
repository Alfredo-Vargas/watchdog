
namespace WatchDog_V1
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.labelAbout = new System.Windows.Forms.Label();
            this.labelDevelopedby = new System.Windows.Forms.Label();
            this.labelHarun = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // labelAbout
            // 
            this.labelAbout.AutoSize = true;
            this.labelAbout.BackColor = System.Drawing.Color.Black;
            this.labelAbout.Font = new System.Drawing.Font("Arial Rounded MT Bold", 48F);
            this.labelAbout.ForeColor = System.Drawing.Color.Lime;
            this.labelAbout.Location = new System.Drawing.Point(18, 14);
            this.labelAbout.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAbout.Name = "labelAbout";
            this.labelAbout.Size = new System.Drawing.Size(532, 222);
            this.labelAbout.TabIndex = 0;
            this.labelAbout.Text = "About\r\nWatchDog";
            // 
            // labelDevelopedby
            // 
            this.labelDevelopedby.AutoSize = true;
            this.labelDevelopedby.BackColor = System.Drawing.Color.Black;
            this.labelDevelopedby.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDevelopedby.ForeColor = System.Drawing.Color.Lime;
            this.labelDevelopedby.Location = new System.Drawing.Point(32, 348);
            this.labelDevelopedby.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDevelopedby.Name = "labelDevelopedby";
            this.labelDevelopedby.Size = new System.Drawing.Size(223, 34);
            this.labelDevelopedby.TabIndex = 5;
            this.labelDevelopedby.Text = "Developed by:";
            this.labelDevelopedby.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelHarun
            // 
            this.labelHarun.AutoSize = true;
            this.labelHarun.BackColor = System.Drawing.Color.Black;
            this.labelHarun.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHarun.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.labelHarun.Location = new System.Drawing.Point(351, 348);
            this.labelHarun.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHarun.Name = "labelHarun";
            this.labelHarun.Size = new System.Drawing.Size(328, 68);
            this.labelHarun.TabIndex = 6;
            this.labelHarun.Text = "Alfredo Vargas\r\nHarun Kahramanoglu";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F);
            this.label1.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label1.Location = new System.Drawing.Point(351, 686);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(666, 34);
            this.label1.TabIndex = 8;
            this.label1.Text = "Email: alfredo.vargas-paredes@outlook.com";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.MediumVioletRed;
            this.linkLabel1.Location = new System.Drawing.Point(353, 759);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(664, 34);
            this.linkLabel1.TabIndex = 10;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "https://github.com/Alfredo-Vargas/watchdog";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.DarkMagenta;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(1176, 863);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelHarun);
            this.Controls.Add(this.labelDevelopedby);
            this.Controls.Add(this.labelAbout);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "WatchDog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAbout;
        private System.Windows.Forms.Label labelDevelopedby;
        private System.Windows.Forms.Label labelHarun;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}