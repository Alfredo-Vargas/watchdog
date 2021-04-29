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
            textBox2.MaxLength = 18;
        }
        private void conformation()
        {
            R_Login = textBox1.Text;
            R_Pass = textBox2.Text;
            R_email = textBox4.Text;
            R_Phone = textBox5.Text;

            string Pass1 = textBox2.Text;
            string Pass2 = textBox3.Text;


            int validConditions = 0;
            foreach (char c in Pass1)
            {
                if (c >= 'a' && c <= 'z')
                {
                    validConditions++;
                    
                }
            }
            foreach (char c in Pass1)
            {
                if (c >= 'A' && c <= 'Z')
                {
                    validConditions++;
                    
                }
            }

            if (validConditions == 0)
            {
                MessageBox.Show("The password restrictions have not been followed"); 
            }
            foreach (char c in Pass1)
            {
                if (c >= '0' && c <= '9')
                {
                    validConditions++;
                   
                }
                if (validConditions == 1)
                {
                    MessageBox.Show("The password restrictions have not been followed");
                   
                }
                if (validConditions == 2)
                {
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

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
