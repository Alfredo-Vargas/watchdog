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
                    sw.WriteLine(Form4.R_Login);
                    sw.WriteLine(Form4.R_Pass);
                    sw.WriteLine(Form4.R_email);
                    sw.WriteLine(Form4.R_Phone);
                    sw.Close();
                }
            }

            else
            {
                
                using (StreamWriter sw = File.AppendText(path))
                {

                    sw.WriteLine("\n" + Form4.R_Login);
                    sw.WriteLine(Form4.R_Pass);
                    sw.WriteLine(Form4.R_email);
                    sw.WriteLine(Form4.R_Phone);
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
