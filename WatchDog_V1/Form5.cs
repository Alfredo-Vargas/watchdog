using System;
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
            Form1 login = new Form1();
            login.Show();
            this.Hide();
        }
    }
}
