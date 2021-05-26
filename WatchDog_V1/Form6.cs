using System;
using System.Windows.Forms;
using System.Linq;
using System.IO;

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

        private void button1_Click(object sender, EventArgs e)
        {
            //button code for "Download"

            string Pathlog = "Log\\" + Form1.A_Login + "\\Log.txt";
            string PathDesk = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), Form1.A_Login + "_WatchDog_EventLog.txt");

            string sourceFile = Pathlog;
            string destinationFile = PathDesk;

            try
            {
                File.Copy(sourceFile, destinationFile, true);
            }
            catch (IOException iox)
            {
                Console.WriteLine(iox.Message);
            }

            MessageBox.Show("The file "+ Form1.A_Login +"_WatchDog_EventLog.txt has been placed on your desktop");
        }
    }   
}
