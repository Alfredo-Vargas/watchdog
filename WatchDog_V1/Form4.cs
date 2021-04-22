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
        public static string R_Phone;

        public Form4()
        {
            InitializeComponent();
            textBox2.MaxLength = 14;
        }
        private void conformation()
        {
            R_Login = textBox1.Text;
            R_Pass = textBox2.Text;
            R_email = textBox4.Text;
            R_Phone = textBox5.Text;

            string Pass1 = textBox2.Text;
            string Pass2 = textBox3.Text;

            if (Pass1 == Pass2)
            {
                Form5 y = new Form5();
                y.Show();
                this.Hide();
                
            }

            else
            {
                MessageBox.Show("Fields not filled in correctly\n\tTry again...");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Pass1 = textBox2.Text;
           
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
