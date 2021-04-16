
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
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelAbout
            // 
            this.labelAbout.AutoSize = true;
            this.labelAbout.BackColor = System.Drawing.Color.Black;
            this.labelAbout.Font = new System.Drawing.Font("Arial Rounded MT Bold", 48F);
            this.labelAbout.ForeColor = System.Drawing.Color.Lime;
            this.labelAbout.Location = new System.Drawing.Point(12, 9);
            this.labelAbout.Name = "labelAbout";
            this.labelAbout.Size = new System.Drawing.Size(356, 150);
            this.labelAbout.TabIndex = 0;
            this.labelAbout.Text = "About\r\nWatchDog";
            this.labelAbout.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelDevelopedby
            // 
            this.labelDevelopedby.AutoSize = true;
            this.labelDevelopedby.BackColor = System.Drawing.Color.Black;
            this.labelDevelopedby.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDevelopedby.ForeColor = System.Drawing.Color.Lime;
            this.labelDevelopedby.Location = new System.Drawing.Point(21, 226);
            this.labelDevelopedby.Name = "labelDevelopedby";
            this.labelDevelopedby.Size = new System.Drawing.Size(150, 23);
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
            this.labelHarun.Location = new System.Drawing.Point(234, 226);
            this.labelHarun.Name = "labelHarun";
            this.labelHarun.Size = new System.Drawing.Size(219, 46);
            this.labelHarun.TabIndex = 6;
            this.labelHarun.Text = "Alfredo Vargas\r\nHarun Kahramanoglu";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F);
            this.label1.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label1.Location = new System.Drawing.Point(234, 446);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(446, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Email: alfredo.vargas-paredes@outlook.com";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F);
            this.label2.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label2.Location = new System.Drawing.Point(234, 482);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(447, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "https://github.com/Alfredo-Vargas/watchdog";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelHarun);
            this.Controls.Add(this.labelDevelopedby);
            this.Controls.Add(this.labelAbout);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "WatchDog";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAbout;
        private System.Windows.Forms.Label labelDevelopedby;
        private System.Windows.Forms.Label labelHarun;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}