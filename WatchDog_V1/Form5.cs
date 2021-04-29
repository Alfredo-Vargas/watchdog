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
            textBox1.Text = Form4.R_Pass;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 Registration = new Form4();
            Registration.Show();
            this.Hide();
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            
            
            string path = @"./Data/Data.txt";
            String dir = @"./Data";

            if(!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
          
            if (!File.Exists(path))
            { 
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("Login : " + Form4.R_Login);
                    sw.WriteLine("Password : " + Form4.R_Pass);
                    sw.WriteLine("E-Mail : " + Form4.R_email);
                    sw.WriteLine("Phone : " + Form4.R_Phone);
                    
                }
            }

            else
            {
                
                using (StreamWriter sw = File.AppendText(path))
                {

                    sw.WriteLine("\nLogin : " + Form4.R_Login);
                    sw.WriteLine("Password : " + Form4.R_Pass);
                    sw.WriteLine("E-Mail : " + Form4.R_email);
                    sw.WriteLine("Phone : " + Form4.R_Phone);
                }
                
            }
           
                
            
            Form1 login = new Form1();
            login.Show();
            this.Hide();
        }
    }
}
