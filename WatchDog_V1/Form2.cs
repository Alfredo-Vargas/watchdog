﻿using System;
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
        private string filePath = "C:/Users/alfre/Documents/MEGAsync/thomas_more/studies 2020_2021/Practice Enterprise 6C"; // C:\\Users/alfre/Documents/MEGA";
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
                    fileName.Text = fileDetails.Name;
                    fileType.Text = fileDetails.Extension;
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
                        /*
                        switch(fileExtension)  // index of the file icon 
                        {
                            case ".mp3":
                            case ".mp2":
                                listView1.Items.Add(files[i].Name, 2);   
                                break;
                            case ".exe":
                            case ".com":
                                listView1.Items.Add(files[i].Name, 3);   
                                break;
                            case ".mp4":
                            case ".avi":
                            case ".mkv":
                                listView1.Items.Add(files[i].Name, 4);   
                                break;
                            case ".pdf":
                                listView1.Items.Add(files[i].Name, 5);   
                                break;
                            case ".doc":
                            case ".docx":
                                listView1.Items.Add(files[i].Name, 6);   
                                break;
                            case ".png":
                            case ".jpg":
                            case ".jpeg":
                                break;
                            default:
                                listView1.Items.Add(files[i].Name, 0);   
                                break;
                        }*/
                    }
                    for (int i = 0; i < dirs.Length; i++)
                    {
                        //if (iconList.Images.ContainsKey("folder.ico"))
                        listView1.Items.Add(dirs[i].Name, "folder.ico");
                    }
                }
                else
                {
                    fileName.Text = this.currentlySelectedItemName;
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
            Form6 Event = new Form6();
            Event.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 main = new Form3();
            main.Show();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
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
                //AddFileSecurity(selectedFilePath, userName, FileSystemRights.ReadData, AccessControlType.Deny);
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
                //RemoveFileSecurity(selectedFilePath, userName, FileSystemRights.ReadData, AccessControlType.Deny);
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
            //Console.ReadKey();
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
            //Console.ReadKey();
        }

        /* ENCRYPTION CODE HERE */
        /* MAIN CODE IDEA IN THE FOLLOWING URL*/
        /* https://www.codeproject.com/Articles/26085/File-Encryption-and-Decryption-in-C */
        private void EncryptFile(string inputFile, string outputFile)
        {
            string uName = userSID.Substring(userSID.Length - 8);
            try
            {
                string password = uName;  // key used to encrypt
                UnicodeEncoding UE = new UnicodeEncoding();
                byte[] key = UE.GetBytes(password);
                string cryptFile = outputFile;
                FileStream fsCrypt = new FileStream(cryptFile, FileMode.Create);  // open pointer to destination file

                RijndaelManaged RMCrypto = new RijndaelManaged();

                CryptoStream cs = new CryptoStream(fsCrypt, RMCrypto.CreateEncryptor(key, key), CryptoStreamMode.Write); // pointer to crypto stream MEMORY ALLOCATION

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
            string uName = userSID.Substring(userSID.Length - 8);
            try
            {
                string password = uName;  // key used to decrypt 

                UnicodeEncoding UE = new UnicodeEncoding();
                byte[] key = UE.GetBytes(password);

                FileStream fsCrypt = new FileStream(inputFile, FileMode.Open);

                RijndaelManaged RMCrypto = new RijndaelManaged();

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
        }

        private void decryptFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string selectedFilePath = filePath + "/" + currentlySelectedItemName;
            string destinationFilePath = filePath + "/" + "decrypted_" + currentlySelectedItemName;
            DecryptFile(selectedFilePath, destinationFilePath);
        }
    }
}
