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
    public partial class Form4 : Form
    {

        public static string R_Login;
        public static string R_Pass;
        public static string R_email;

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        
        private void label2_Click(object sender, EventArgs e)
        {

        }
        
        private void label3_Click(object sender, EventArgs e)
        {

        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            R_Login = textBox1.Text;
            R_Pass = textBox2.Text;
            R_email = textBox4.Text;

            //https://www.youtube.com/watch?v=dRJsg3X8aEU
            //min 2:01

            string Pass1 = textBox2.Text;
            string Pass2 = textBox3.Text;

            if(Pass1 == Pass2)
            {
                /*Form5 Confirmation = new Form5();
                Confirmation.Show();
                this.Hide();*/
            }

            else
            {
                MessageBox.Show("Fields not filled in correctly\n\tTry again...");
            }
        }

       
    }
}
