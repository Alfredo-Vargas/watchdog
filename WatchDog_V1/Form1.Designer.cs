
namespace test
{
    // comment test
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.Login_Lable = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Pass_Lable = new System.Windows.Forms.Label();
            this.LoginTxt = new System.Windows.Forms.TextBox();
            this.PassTxt = new System.Windows.Forms.TextBox();
            this.Login_Button = new System.Windows.Forms.Button();
            this.Exit_Button = new System.Windows.Forms.Button();
            this.Register_Lable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // Login_Lable
            // 
            this.Login_Lable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Login_Lable.AutoSize = true;
            this.Login_Lable.BackColor = System.Drawing.Color.Black;
            this.Login_Lable.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_Lable.ForeColor = System.Drawing.Color.Lime;
            this.Login_Lable.Location = new System.Drawing.Point(258, 200);
            this.Login_Lable.Name = "Login_Lable";
            this.Login_Lable.Size = new System.Drawing.Size(64, 23);
            this.Login_Lable.TabIndex = 1;
            this.Login_Lable.Text = "Login";
            this.Login_Lable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Login_Lable.Click += new System.EventHandler(this.Label2_Click);
            this.Login.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(629, 486);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 63);
            this.button1.TabIndex = 2;
            this.button1.Text = "Exit";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            this.Pass_Lable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Pass_Lable.AutoSize = true;
            this.Pass_Lable.BackColor = System.Drawing.Color.Black;
            this.Pass_Lable.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pass_Lable.ForeColor = System.Drawing.Color.Lime;
            this.Pass_Lable.Location = new System.Drawing.Point(215, 254);
            this.Pass_Lable.Name = "Pass_Lable";
            this.Pass_Lable.Size = new System.Drawing.Size(107, 23);
            this.Pass_Lable.TabIndex = 4;
            this.Pass_Lable.Text = "Password";
            this.Pass_Lable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Pass_Lable.Click += new System.EventHandler(this.Label2_Click_1);
            this.label2.Text = "Password";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // LoginTxt
            // 
            this.LoginTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LoginTxt.BackColor = System.Drawing.Color.Black;
            this.LoginTxt.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginTxt.ForeColor = System.Drawing.Color.Lime;
            this.LoginTxt.Location = new System.Drawing.Point(328, 204);
            this.LoginTxt.Name = "LoginTxt";
            this.LoginTxt.Size = new System.Drawing.Size(200, 23);
            this.LoginTxt.TabIndex = 5;
            this.LoginTxt.TextChanged += new System.EventHandler(this.LoginTxt_TextChanged);
            // 
            // PassTxt
            // 
            this.PassTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PassTxt.BackColor = System.Drawing.Color.Black;
            this.PassTxt.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassTxt.ForeColor = System.Drawing.Color.Lime;
            this.PassTxt.Location = new System.Drawing.Point(328, 254);
            this.PassTxt.Name = "PassTxt";
            this.PassTxt.Size = new System.Drawing.Size(200, 23);
            this.PassTxt.TabIndex = 10;
            this.PassTxt.UseSystemPasswordChar = true;
            this.PassTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PassTxt_KeyPress);
            // 
            // Login_Button
            // 
            this.Login_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Login_Button.BackColor = System.Drawing.Color.Black;
            this.Login_Button.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.Login_Button.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_Button.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Login_Button.Location = new System.Drawing.Point(12, 412);
            this.Login_Button.Name = "Login_Button";
            this.Login_Button.Size = new System.Drawing.Size(143, 63);
            this.Login_Button.TabIndex = 11;
            this.Login_Button.Text = "Login";
            this.Login_Button.UseVisualStyleBackColor = false;
            this.Login_Button.Click += new System.EventHandler(this.Button3_Click);
            // 
            // Exit_Button
            // 
            this.Exit_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Exit_Button.BackColor = System.Drawing.Color.Black;
            this.Exit_Button.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.Exit_Button.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit_Button.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Exit_Button.Location = new System.Drawing.Point(629, 412);
            this.Exit_Button.Name = "Exit_Button";
            this.Exit_Button.Size = new System.Drawing.Size(143, 63);
            this.Exit_Button.TabIndex = 12;
            this.Exit_Button.Text = "Exit";
            this.Exit_Button.UseVisualStyleBackColor = false;
            this.Exit_Button.Click += new System.EventHandler(this.Button4_Click);
            // 
            // Register_Lable
            // 
            this.Register_Lable.AutoSize = true;
            this.Register_Lable.BackColor = System.Drawing.Color.Transparent;
            this.Register_Lable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Register_Lable.ForeColor = System.Drawing.Color.White;
            this.Register_Lable.Location = new System.Drawing.Point(378, 290);
            this.Register_Lable.Name = "Register_Lable";
            this.Register_Lable.Size = new System.Drawing.Size(96, 13);
            this.Register_Lable.TabIndex = 13;
            this.Register_Lable.Text = "Register New User";
            this.Register_Lable.Click += new System.EventHandler(this.Register_Lable_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.button3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.Location = new System.Drawing.Point(12, 412);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(143, 63);
            this.button3.TabIndex = 11;
            this.button3.Text = "Login";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button4.BackColor = System.Drawing.Color.Black;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.button4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button4.Location = new System.Drawing.Point(629, 412);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(143, 63);
            this.button4.TabIndex = 12;
            this.button4.Text = "Exit";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(784, 487);
            this.Controls.Add(this.Register_Lable);
            this.Controls.Add(this.Exit_Button);
            this.Controls.Add(this.Login_Button);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(1176, 863);
            this.Controls.Add(this.PassTxt);
            this.Controls.Add(this.LoginTxt);
            this.Controls.Add(this.Pass_Lable);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Login_Lable);
            this.Controls.Add(this.label1);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WatchDog";
            this.Load += new System.EventHandler(this.WatchDog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Login_Lable;
        private System.Windows.Forms.Button button1;
       
        private System.Windows.Forms.Button Login_Button;
        private System.Windows.Forms.Button Exit_Button;
        private System.Windows.Forms.Label Register_Lable;
        private System.Windows.Forms.Label Pass_Lable;
        private System.Windows.Forms.TextBox LoginTxt;
        private System.Windows.Forms.TextBox PassTxt;
    }
}

