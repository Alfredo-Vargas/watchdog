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
    public partial class Form4 : Form
    {
        public static string R_Login;
        public static string R_Pass;
        public static string R_email;
        public static string R_Phone;

        public Form4()
        {
            InitializeComponent();
            textBox2.MaxLength = 16;
            textBox3.MaxLength = 16;
            textBox5.MaxLength = 15;
            
        }


        private void conformation()
        {
            R_Login = textBox1.Text;
            R_Pass = textBox2.Text;
            R_email = textBox4.Text;
            R_Phone = textBox5.Text;

            string Pass1 = textBox2.Text;
            string Pass2 = textBox3.Text;
            string Login = textBox1.Text;
            string mail = textBox4.Text;
            string phone = textBox5.Text;

            string path = @"./Data/Data.txt";
            string username = null;


            if (File.Exists(path))
            {
                string[] lines = System.IO.File.ReadAllLines(@"./Data/Data.txt");

                Boolean exits = false;

                for (int i = 0; i < lines.Count(); i += 5)
                {
                    if (Login == lines[i])
                    {
                        exits = true;
                        break;

                    }
                }

                    if( exits == true)
                    {
                        MessageBox.Show("Login already in use"); 
                    }

                    else
                    {
                        if (Pass1.Length >= 8 && Pass1.Any(char.IsUpper) && Pass1.Any(char.IsLower)) //pass req
                        {
                            if (mail.Contains("@") && mail.Contains("."))
                            {
                                if (phone.Length >= 7)
                                {
                                    if (Pass1 == Pass2) //pass1&2 need to be eaqual to go to form5
                                    {
                                        Form5 y = new Form5();
                                        this.Close();
                                        y.Show();
                                    }
                                    else
                                    {
                                        MessageBox.Show("The passwords do not match\n\tTry again...");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Enter a valid phone number");
                                }
                            }
                            else
                            {
                                MessageBox.Show("\tFill in the correct e-mail syntax \n\tsomething@domain.com");
                            }
                        }
                        else
                        {
                            MessageBox.Show("The password requirements have not been met");
                        }

                    }
                
            }

            else
            {

                if (Pass1.Length >= 8 && Pass1.Any(char.IsUpper) && Pass1.Any(char.IsLower)) //pass req
                {
                    if (mail.Contains("@") && mail.Contains(".")) //email req
                    {
                        if (phone.Length >= 7) //min phone number length in the world
                        {
                            if (Pass1 == Pass2) //pass1&2 need to be eaqual to go to form5
                            {
                                Form5 y = new Form5();
                                y.Show();
                                this.Hide();

                            }
                            else
                            {
                                MessageBox.Show("The passwords do not match\n\tTry again...");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Enter a valid phone number");
                        }
                    }
                    else
                    {
                        MessageBox.Show("\tFill in the correct e-mail syntax \n\tsomething@domain.com");
                    }
                }
                else
                {
                    MessageBox.Show("The password requirements have not been met");
                }
            }

        }


        private void button1_Click(object sender, EventArgs e)
        {  
                conformation();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                conformation();
            }
        }
    }
}
