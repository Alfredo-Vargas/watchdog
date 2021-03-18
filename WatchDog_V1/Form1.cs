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

namespace test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void WatchDog_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void mm(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

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

        private void button4_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string Login = LoginTxt.Text;
            string pass = PassTxt.Text;

            if (Login == "h" && pass == "w") {
                Form2 main = new Form2();
                main.Show();
                this.Hide();
                
            }
            else
            {
                MessageBox.Show("Password or Login incorrect try again");

            }

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
