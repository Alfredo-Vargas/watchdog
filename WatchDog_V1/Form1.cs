using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WatchDog_V1;
using System.IO;
using EncryptEncDec;


namespace WatchDog_V1
{
    public partial class Form1 : Form
    {
        public static string A_Login;

        public Form1()
        {
            InitializeComponent();
            PassTxt.PasswordChar = '*';
        }

        int attempts = 1;
        private void LoginForm()
        {
            string Login = LoginTxt.Text;
            string pass = PassTxt.Text;
            string path = @"./Data/Data.BIN";
            String dir = @"./Data";

            if (!Directory.Exists(dir))
            {
                MessageBox.Show("Password or login incorrect try again\n" + attempts + "out of 3");
                attempts = attempts + 1;
            }
            else
            {

                string[] lines = System.IO.File.ReadAllLines(@"./Data/Data.BIN");

                Boolean loginMatch = false;

                string Pathsec = "Log\\" + Login + "\\Securtylog.txt";
                string Pathlog = "Log\\" + Login + "\\Log.txt";
                string time = DateTime.Now.ToString("dd/M/yyyy-HH:mm:ss");

                var sr = new StreamReader(@"./Data/Data.BIN");

                for (int i = 0; i < lines.Count(); i += 5)
                {
                    string encryUsr = Encryption.Encrypt(Login);
                    string enctyPass = Encryption.Encrypt(pass);

                    if (encryUsr == lines[i] && enctyPass == lines[i + 1])
                    {
                        loginMatch = true;
                        using (StreamWriter sw = File.AppendText(Pathlog))
                        {
                            sw.WriteLine(time + "\tUser Login : \t" + Login + "\n");
                            sw.Close();
                        }

                        using (StreamWriter sw = File.AppendText(Pathsec))
                        {
                            sw.WriteLine(time + "\tUser Login : \t" + Login + "\n");
                            sw.Close();
                        }

                        A_Login = LoginTxt.Text;
                        Form2 main = new Form2();
                        main.Show();
                        this.Hide();
                    }

                }

                if (loginMatch == false)
                {
                    MessageBox.Show("Password or login incorrect try again\n" + attempts + " out of 3");
                    attempts = attempts + 1;
                }
            }

            if (attempts == 4)
            {
                MessageBox.Show("Maximum login attepts reached the program will close");
                System.Windows.Forms.Application.Exit();
            }
        }

        private void PassTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                LoginForm();
            }
        }

        private void Form1Closing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginForm(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 Registration = new Form4();
            Registration.Show();
            this.Hide();
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            
            panel1.Width -= 40;
            panel2.Width -= 40;

            if(panel1.Width == 0)
            {
                timer1.Stop();
            }
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            await Task.Delay(1500);
            timer1.Start();
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            timer1.Start();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void panel2_MouseClick(object sender, MouseEventArgs e)
        {
            timer1.Start();
        }
    }
}
      

