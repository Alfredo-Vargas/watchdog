using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WatchDog_V1
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            string Pathsec = "Log\\" + Form1.A_Login + "\\Securtylog.txt";
            string[] lines = System.IO.File.ReadAllLines(Pathsec);

            for (int i = 0; i < lines.Count(); i++)
            {
                richTextBox1.Text += "\t" + lines[i] + "\r\n";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //button code for "Download"

            string Pathsec = "Log\\" + Form1.A_Login + "\\Securtylog.txt";
            string PathDesk = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), Form1.A_Login + "_WatchDog_Security.txt");

            string sourceFile = Pathsec;
            string destinationFile = PathDesk;

            try
            {
                File.Copy(sourceFile, destinationFile, true);
            }
            catch (IOException iox)
            {
                Console.WriteLine(iox.Message);
            }
            MessageBox.Show("The file " + Form1.A_Login + "_WatchDog_Security.txt has been placed in " + PathDesk);
        }
    }
}
