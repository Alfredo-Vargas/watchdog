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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form5_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                VisitLink();
            }
            catch (Exception ex )
            {
                MessageBox.Show("Unable to open link that was clicked.");
            }
        }

        private void VisitLink()
        {
            linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("https://github.com/Alfredo-Vargas/watchdog");

            string Pathsec = "Log\\" + Form1.A_Login + "\\Securtylog.txt";
            string Pathlog = "Log\\" +  Form1.A_Login + "\\Log.txt";
            string time = DateTime.Now.ToString("dd/M/yyyy-HH:mm:ss");

            using (StreamWriter sw = File.AppendText(Pathlog))
            {
                sw.WriteLine(time + "\t Visited link :\t https://github.com/Alfredo-Vargas/watchdog " + "\n");
                sw.Close();
            }

            using (StreamWriter sw = File.AppendText(Pathsec))
            {
                sw.WriteLine(time + "\t Visited link :\t https://github.com/Alfredo-Vargas/watchdog " + "\n");
                sw.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string MailH = "Kahramanogluharun@gmail.com";
            string MailA = "alfredo.vargas-paredes@outlook.com;";
            System.Diagnostics.Process.Start("mailto:" + MailA  + MailH + "?Subject=WatchDog Contact Form");

            string Pathsec = "Log\\" + Form1.A_Login + "\\Securtylog.txt";
            string time = DateTime.Now.ToString("dd/M/yyyy-HH:mm:ss");

            using (StreamWriter sw = File.AppendText(Pathsec))
            {
                sw.WriteLine(time + "\t Send Mail to : " +MailH + " " + MailA + "\n");
                sw.Close();
            }
        }
    }
}
