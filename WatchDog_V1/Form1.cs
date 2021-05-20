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

namespace WatchDog_V1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            PassTxt.PasswordChar = '*';
        }

       private void mm(object sender, EventArgs e)
        {
            Form4 Registration = new Form4();
            Registration.Show();
            this.Hide();
        }
        private void LoginForm()
        {
            string Login = LoginTxt.Text;
            string pass = PassTxt.Text;


            string[] lines = System.IO.File.ReadAllLines(@"./Data/Data.txt");


            if(Login =="" && pass =="")
            {
                Form2 main = new Form2();
                main.Show();
                this.Hide();

            }

          /*  Boolean loginMatch = false;

            for (int i = 0; i < lines.Count(); i += 5)
            {               
                if (Login == lines[i] && pass == lines[i+1])
                {
                    loginMatch = true;
                    Form2 main = new Form2();
                    main.Show();
                    this.Hide();
                }

            }


            if (loginMatch == false)
            {
                MessageBox.Show("Password or login incorrect try again");
            }*/

        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoginForm();   
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

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 Registration = new Form4();
            Registration.Show();
            this.Hide();
        }


    }
}
