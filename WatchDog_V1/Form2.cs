using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Diagnostics;            // to be able to open a file
using System.IO;                     // to deal file/folder attributes
using System.Security.AccessControl; // to get access ACL options
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;            // to get the UserDomainName
using System.Security;
using System.Security.Cryptography; // to use RijndaelManaged RMCrypto

namespace WatchDog_V1
{
    public partial class Form2 : Form
    {
        public string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
        public string userSID = System.Security.Principal.WindowsIdentity.GetCurrent().User.ToString();
        public string UserDomainName = Environment.UserDomainName;
        private string filePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        private bool isFile = false;
        private string currentlySelectedItemName = "";
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            filePathTextBox.Text = filePath;
            loadFilesAndDirectories();
            label2.Text = Form1.A_Login;
        }

        public void loadFilesAndDirectories()
        {
            DirectoryInfo fileList;
            string tempFilePath = "";
            FileAttributes fileAttr;
            try
            {
                if (isFile)
                {
                    tempFilePath = filePath + "/" + currentlySelectedItemName;
                    FileInfo fileDetails = new FileInfo(tempFilePath);
                    fileNameLabel.Text = fileDetails.Name;
                    fileTypeLabel.Text = fileDetails.Extension;
                    fileAttr = File.GetAttributes(tempFilePath);
                    Process.Start(tempFilePath);
                }
                else
                {
                    fileAttr = File.GetAttributes(filePath);
                }
                if ((fileAttr & FileAttributes.Directory) == FileAttributes.Directory)
                {
                    fileList = new DirectoryInfo(filePath);
                    FileInfo[] files = fileList.GetFiles();           // get all the files
                    DirectoryInfo[] dirs = fileList.GetDirectories();   // get all the folders
                    string fileExtension = "";

                    listView1.Items.Clear();

                    for (int i = 0; i < files.Length; i++)
                    {
                        fileExtension = files[i].Extension.ToLower().Substring(1);
                        if (iconList.Images.ContainsKey(fileExtension + ".ico"))
                        {
                            listView1.Items.Add(files[i].Name, fileExtension + ".ico");
                        }
                        else
                        {
                            listView1.Items.Add(files[i].Name, "blank.ico");
                        }
                    }
                    for (int i = 0; i < dirs.Length; i++)
                    {
                        //if (iconList.Images.ContainsKey("folder.ico"))
                        listView1.Items.Add(dirs[i].Name, "folder.ico");
                    }
                }
                else
                {
                    fileNameLabel.Text = this.currentlySelectedItemName;
                }
            }
            catch(Exception e)
            {

            }
        }

        public void loadButtonAction()
        {
            removeBackSlash();
            filePath = filePathTextBox.Text;
            loadFilesAndDirectories();
            isFile = false;             // when going inside a directory the selected item is not a file
        }

        public void removeBackSlash()   // removes if a backslash is at the end of path
        {
            string path = filePathTextBox.Text;
            if(path.LastIndexOf("/") == path.Length - 1)
            {
                filePathTextBox.Text = path.Substring(0, path.Length - 1);
            }
        }

        public void goBack()
        {
            try
            {
                string path = filePathTextBox.Text;
                path = path.Substring(0, path.LastIndexOf("/"));
                this.isFile = false;
                filePathTextBox.Text = path;
                removeBackSlash();
            }
            catch(Exception e)
            {

            }
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            loadButtonAction();
        }
        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e) // this when clicking another item in the listview (ItemSelectionChanged)
        {
            currentlySelectedItemName = e.Item.Text; // gets the selected item name
            FileAttributes fileAttr = File.GetAttributes(filePath + "/" + currentlySelectedItemName); // updates the fileAttr given the new path
            if ((fileAttr & FileAttributes.Directory) == FileAttributes.Directory)
            {
                isFile = false;
                filePathTextBox.Text = filePath + "/" + currentlySelectedItemName;                  // updates the path if is a directory
            }
            else
                isFile = true;
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            loadButtonAction();   // it will open a directory or a file this function calls loadFilesAndDirectories()
        }

        private void button6_Click(object sender, EventArgs e)
        {

            string Pathlog = "Log\\" + Form1.A_Login + "\\Log.txt";
            string time = DateTime.Now.ToString("dd/M/yyyy-HH:mm:ss");

            using (StreamWriter sw = File.AppendText(Pathlog))
            {
                sw.WriteLine(time + "\tOpen EventLog : \t" + Form1.A_Login + "\n");
                sw.Close();
            }

            Form6 Event = new Form6();
            Event.Show();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

            string Pathlog = "Log\\" + Form1.A_Login + "\\Log.txt";
            string time = DateTime.Now.ToString("dd/M/yyyy-HH:mm:ss");

            using (StreamWriter sw = File.AppendText(Pathlog))
            {
                sw.WriteLine(time + "\tOpen WatchDog : \t" + Form1.A_Login + "\n");
                sw.Close();
            }

            Form3 main = new Form3();
            main.Show();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            string Pathsec = "Log\\" + Form1.A_Login + "\\Securtylog.txt";
            string Pathlog = "Log\\" + Form1.A_Login + "\\Log.txt";
            string time = DateTime.Now.ToString("dd/M/yyyy-HH:mm:ss");

            using (StreamWriter sw = File.AppendText(Pathlog))
            {
                sw.WriteLine(time + "\tUser Logout : \t" + Form1.A_Login + "\n");
                sw.Close();
            }

            using (StreamWriter sw = File.AppendText(Pathsec))
            {
                sw.WriteLine(time + "\tUser Logout : \t" + Form1.A_Login + "\n");
                sw.Close();
            }



            System.Windows.Forms.Application.ExitThread();

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            goBack();
            loadButtonAction();
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && isFile)
            {
                contextMenuStrip1.Show(listView1, e.Location);
            }
        }

        /* ACL CONTROL CODE HERE */
        /* some guidelines */
        /* https://docs.microsoft.com/en-us/dotnet/api/system.io.file.setaccesscontrol?view=netframework-4.8 */
        private void lockFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string selectedFilePath = filePath + "/" + currentlySelectedItemName;
            try
            {
                BlockAllUsers();

                string Pathsec = "Log\\" + Form1.A_Login + "\\Securtylog.txt";
                string time = DateTime.Now.ToString("dd/M/yyyy-HH:mm:ss");

                using (StreamWriter sw = File.AppendText(Pathsec))
                {
                    sw.WriteLine(time + "\tLocked File: \t"+ currentlySelectedItemName + "\n");
                    sw.Close();
                }
            }
            catch 
            {
                MessageBox.Show("Something went wrong when locking the file");
            }
        }
        private void makeReadOnlyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string selectedFilePath = filePath + "/" + currentlySelectedItemName;
            try
            {
                UnblockAllUsers();

                string Pathsec = "Log\\" + Form1.A_Login + "\\Securtylog.txt";
                string time = DateTime.Now.ToString("dd/M/yyyy-HH:mm:ss");


                using (StreamWriter sw = File.AppendText(Pathsec))
                {
                    sw.WriteLine(time + "\tUnlocked File: \t" + currentlySelectedItemName + "\n");
                    sw.Close();
                }
            }
            catch
            {
                MessageBox.Show("Something went wrong when unlocking the file");
            }
        }
        public static void AddFileSecurity(string fileName, string account, FileSystemRights rights, AccessControlType controlType)
        {
            // Get file security object
            FileSecurity fSecurity = File.GetAccessControl(fileName);

            // Add the FileSystemAccessRule to the security settings
            fSecurity.AddAccessRule(new FileSystemAccessRule(account, rights, controlType));

            // SettingsBindableAttribute the new access setings
            File.SetAccessControl(fileName, fSecurity);
        }
        public static void RemoveFileSecurity(string fileName, string account, FileSystemRights rights, AccessControlType controlType)
        {
            // Get file security object
            FileSecurity fSecurity = File.GetAccessControl(fileName);

            // Remove the FileSystemAccessRule from security settings
            fSecurity.RemoveAccessRule(new FileSystemAccessRule(account, rights, controlType));

            // Set the new access settings
            File.SetAccessControl(fileName, fSecurity);
        }

        private void BlockAllUsers()
        {
            string UserX;
            string DomainX = "Domain=\'" + UserDomainName + "\'";
            string selectedFilePath = filePath + "/" + currentlySelectedItemName;
            SelectQuery sQuery = new SelectQuery("Win32_UserAccount", DomainX);
            try
            {
                ManagementObjectSearcher mSearcher = new ManagementObjectSearcher(sQuery);
                
                foreach (ManagementObject mObject in mSearcher.Get())
                {
                    UserX = mObject["Domain"].ToString() + "\\" + mObject["Name"].ToString();
                    if (userName != UserX)
                    {
                        AddFileSecurity(selectedFilePath, UserX, FileSystemRights.ReadData, AccessControlType.Deny);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void UnblockAllUsers()
        {
            string UserX;
            string DomainX = "Domain=\'" + UserDomainName + "\'";
            string selectedFilePath = filePath + "/" + currentlySelectedItemName;
            SelectQuery sQuery = new SelectQuery("Win32_UserAccount", DomainX);
            try
            {
                ManagementObjectSearcher mSearcher = new ManagementObjectSearcher(sQuery);
                
                foreach (ManagementObject mObject in mSearcher.Get())
                {
                    UserX = mObject["Domain"].ToString() + "\\" + mObject["Name"].ToString();
                    if (userName != UserX)
                    {
                        RemoveFileSecurity(selectedFilePath, UserX, FileSystemRights.ReadData, AccessControlType.Deny);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        /* ENCRYPTION CODE HERE */
        /* MAIN CODE IDEA IN THE FOLLOWING URL*/
        /* https://www.codeproject.com/Articles/26085/File-Encryption-and-Decryption-in-C */
        private void EncryptFile(string inputFile, string outputFile)
        {
            string uName = userSID.Substring(userSID.Length - 16);
            try
            {
                RijndaelManaged RMCrypto = new RijndaelManaged();
                RMCrypto.BlockSize = 256;     // allows to user a bigger key (size of IV)

                string password = uName;  // key used to encrypt
                UnicodeEncoding UE = new UnicodeEncoding();
                byte[] key = UE.GetBytes(password);
                string cryptFile = outputFile;
                FileStream fsCrypt = new FileStream(cryptFile, FileMode.Create);  // open pointer to destination file

                // pointer to crypto stream MEMORY ALLOCATION
                CryptoStream cs = new CryptoStream(fsCrypt, RMCrypto.CreateEncryptor(key, key), CryptoStreamMode.Write); 

                FileStream fsIn = new FileStream(inputFile, FileMode.Open);     // open pointer to source file

                int data;
                while ((data = fsIn.ReadByte()) != -1)
                    cs.WriteByte((byte)data);

                fsIn.Close();  // file pointer is closed (source file)
                cs.Close(); // pointer to the encryption stream is closed
                fsCrypt.Close(); // file pointer is closed (destination file)
            }
            catch
            {
                MessageBox.Show("Encryption failed!", "Error");
            }
        }
        private void DecryptFile(string inputFile, string outputFile)
        {
            string uName = userSID.Substring(userSID.Length - 16);
            try
            {
                RijndaelManaged RMCrypto = new RijndaelManaged();
                RMCrypto.BlockSize = 256;     // allows to user a bigger key (size of IV)

                string password = uName;  // key used to decrypt 

                UnicodeEncoding UE = new UnicodeEncoding();
                byte[] key = UE.GetBytes(password);

                FileStream fsCrypt = new FileStream(inputFile, FileMode.Open);

                CryptoStream cs = new CryptoStream(fsCrypt, RMCrypto.CreateDecryptor(key, key), CryptoStreamMode.Read);

                FileStream fsOut = new FileStream(outputFile, FileMode.Create);

                int data;
                while ((data = cs.ReadByte()) != -1)
                    fsOut.WriteByte((byte)data);

                fsOut.Close();
                cs.Close();
                fsCrypt.Close();
            }
            catch
            {
                MessageBox.Show("Decryption failed!");
            }
        }

        private void encryptFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string selectedFilePath = filePath + "/" + currentlySelectedItemName;
            string destinationFilePath = filePath + "/" + "encrypted_" + currentlySelectedItemName;
            EncryptFile(selectedFilePath, destinationFilePath);
            
            if (isFile)
            {
                this.isFile = false; // to avoid opening the selected file (we want only to refresh)
            }
            loadFilesAndDirectories();  // call to refresh the items in the File Explorer after new encrypted file was created

            string Pathsec = "Log\\" + Form1.A_Login + "\\Securtylog.txt";
            string time = DateTime.Now.ToString("dd/M/yyyy-HH:mm:ss");

            using (StreamWriter sw = File.AppendText(Pathsec))
            {
                sw.WriteLine(time + "\tEncypted File: \t" + currentlySelectedItemName + "\n");
                sw.Close();
            }
        }

        private void decryptFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string selectedFilePath = filePath + "/" + currentlySelectedItemName;
            string destinationFilePath = filePath + "/" + "decrypted_" + currentlySelectedItemName;
            DecryptFile(selectedFilePath, destinationFilePath);

            if (isFile)
            {
                this.isFile = false; // to avoid opening the selected file (we want only to refresh)
            }
            loadFilesAndDirectories();  // call to refresh the items in the File Explorer after new encrypted file was created

            string Pathsec = "Log\\" + Form1.A_Login + "\\Securtylog.txt";
            string time = DateTime.Now.ToString("dd/M/yyyy-HH:mm:ss");

            using (StreamWriter sw = File.AppendText(Pathsec))
            {
                sw.WriteLine(time + "\tDecypted File: \t" + currentlySelectedItemName + "\n");
                sw.Close();
            }
        }

        private void securityButton_Click(object sender, EventArgs e)
        {
            string Pathlog = "Log\\" + Form1.A_Login + "\\Log.txt";
            string time = DateTime.Now.ToString("dd/M/yyyy-HH:mm:ss");

            using (StreamWriter sw = File.AppendText(Pathlog))
            {
                sw.WriteLine(time + "\tOpen SecurityLog : \t" + Form1.A_Login + "\n");
                sw.Close();
            }
            Form7 Secr = new Form7();
            Secr.Show();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;
                

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;     //Get the path of specified file
                }
            }

            File.Copy(filePath, filePathTextBox.Text + "\\" + Path.GetFileName(filePath));

            if (isFile)
            {
                this.isFile = false; // to avoid opening the selected file (we want only to refresh)
            }
            loadFilesAndDirectories();  // call to refresh the items in the File Explorer after new encrypted file was created

            string Pathsec = "Log\\" + Form1.A_Login + "\\Securitylog.txt";
            string Pathlog = "Log\\" + Form1.A_Login + "\\Log.txt";
            string time = DateTime.Now.ToString("dd/M/yyyy-HH:mm:ss");

             using (StreamWriter sw = File.AppendText(Pathsec))
             {
                 sw.WriteLine(time + "\tAdded File : \t" + Form1.A_Login + "\n");
                 sw.Close();
             }

             using (StreamWriter sw = File.AppendText(Pathlog))
             {
                 sw.WriteLine(time + "\tAdded File : \t" + Form1.A_Login + "\n");
                 sw.Close();
             }
        }

        private void deleteFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string fileToBeDeleted = filePath + "\\" + currentlySelectedItemName;
            File.Delete(fileToBeDeleted);
            if (isFile)
            {
                this.isFile = false; // to avoid opening the selected file (we want only to refresh)
            }
            loadFilesAndDirectories();  // call to refresh the items in the File Explorer after new encrypted file was created           
        }
    }
}
