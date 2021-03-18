using System;
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

        private void Label2_Click(object sender, EventArgs e)
        {

        }



        private void Label2_Click_1(object sender, EventArgs e)
        {

        }



        private void PassTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginTxt_TextChanged(object sender, EventArgs e)
        {

        }

     

        private void Button4_Click(object sender, EventArgs e)
        {
           
            this.Close();
        }

      
        private void Button3_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void Login()
        {
            string Login = LoginTxt.Text;
            string pass = PassTxt.Text;

            if (Login == "h" && pass == "w")
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

        private void PassTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                Login();
            }

        }

        private void Register_Lable_Click(object sender, EventArgs e)
        {
            Form4 Registration = new Form4();
            Registration.Show();
            this.Hide();
        }
    }
}
