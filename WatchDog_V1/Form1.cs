using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Loginbox : Form
    {
        public Loginbox()
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
            this.Close();
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Login = LoginTxt.Text;
            string pass = PassTxt.Text;

            if (Login == "Harun" && pass == "WatchDog123");
            else
            {
                MessageBox.Show("Password or Login incorrect try again");
            }
           
                 
            
        }

        private void PassTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
