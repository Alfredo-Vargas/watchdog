﻿using System;
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

        private void WatchDog_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void mm(object sender, EventArgs e)
        {
            Form4 Registration = new Form4();
            Registration.Show();
            this.Hide();
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void LoginForm()
        {
            string Login = LoginTxt.Text;
            string pass = PassTxt.Text;

            if (Login == Form4.R_Login && pass == Form4.R_Pass)
            {
                Form2 main = new Form2();
                main.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Password or Login incorrect try again");

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoginForm();   
        }

        private void PassTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

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
    }
}
