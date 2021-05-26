using System;
using System.Windows.Forms;
using System.Linq;

namespace WatchDog_V1
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            string Pathlog = "Log\\" + Form1.A_Login + "\\Log.txt";
            string[] lines = System.IO.File.ReadAllLines(Pathlog);

             for (int i = 0; i < lines.Count(); i++)
             {
                  richTextBox1.Text += "\t" + lines[i] + "\r\n";
             }
        }
    }   
}
