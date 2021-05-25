using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using EncryptEncDec;



namespace WatchDog_V1
{
    public partial class Form5 : Form
    {
        
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            label5.Text = Form4.R_Login;
            label6.Text = Form4.R_email;
            label7.Text = Form4.R_Pass;
            label8.Text = Form4.R_Phone;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 Registration = new Form4();
            Registration.Show();
            this.Hide();
        }

        

        private void button2_Click(object sender, EventArgs e)
        {

            string path = @"./Data/Data.BIN";
            String dir = @"./Data";

            if(!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
          
            if (!File.Exists(path))
            { 
                using (StreamWriter sw = File.CreateText(path))
                {
                    string encryUsr = Encryption.Encrypt(Form4.R_Login);
                    string encryPass = Encryption.Encrypt(Form4.R_Pass);
                    string encryemail = Encryption.Encrypt(Form4.R_email);
                    string encryPhone = Encryption.Encrypt(Form4.R_Phone);

                    sw.WriteLine(encryUsr);
                    sw.WriteLine(encryPass);
                    sw.WriteLine(encryemail);
                    sw.WriteLine(encryPhone);
                    sw.Close();
                }
            }

            else
            {
                
                using (StreamWriter sw = File.AppendText(path))
                {


                    string encryUsr = Encryption.Encrypt(Form4.R_Login);
                    string encryPass = Encryption.Encrypt(Form4.R_Pass);
                    string encryemail = Encryption.Encrypt(Form4.R_email);
                    string encryPhone = Encryption.Encrypt(Form4.R_Phone);

                    sw.WriteLine("\n" + encryUsr);
                    sw.WriteLine(encryPass);
                    sw.WriteLine(encryemail);
                    sw.WriteLine(encryPhone);
                    sw.Close();
                }
                
                
            }

            string Pathsec = "Log\\" + Form4.R_Login + "\\Securtylog.txt";
            string Pathlog = "Log\\" + Form4.R_Login + "\\Log.txt";
            string Dirlog = "Log\\" + Form4.R_Login;
            string time = DateTime.Now.ToString("dd/M/yyyy-HH:mm:ss");

            if (!Directory.Exists(Dirlog))
            {
                Directory.CreateDirectory(Dirlog);
            }

            if (!File.Exists(Pathsec)) //only for login /logout and locked file/ unlocked file
            {
                using (StreamWriter sw = File.CreateText(Pathsec))
                {
                    sw.WriteLine(time + "\tNew User Created : " +Form4.R_Login +"\n");
                    sw.Close();
                }
            }

            if (!File.Exists(Pathlog)) //for every action taken 
            {
                using (StreamWriter sw = File.CreateText(Pathlog))
                {
                    sw.WriteLine(time + "\tNew User Created : " + Form4.R_Login + "\n");
                    sw.Close();
                }
            }




            Form1 login = new Form1();
            login.Show();
            this.Hide();

            Form4.R_Login = null;
            Form4.R_Pass = null;
            Form4.R_email = null;
            Form4.R_Phone = null;
        }



        private void button3_Click(object sender, EventArgs e)
        {
            if(label7.Visible == false)
            {
                label7.Visible = true;
            }
            else
            {
                label7.Visible = false;
            }
        }

    }   


}
