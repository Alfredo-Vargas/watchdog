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

namespace WatchDog_V1
{
    public partial class Form2 : Form
    {
        private string filePath = "C:\\Users";
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
                        fileExtension = files[i].Extension.ToUpper();
                        switch(fileExtension)  // index of the file icon 
                        {
                            case ".MP3":
                            case ".MP2":
                                listView1.Items.Add(files[i].Name, 2);   
                                break;
                            case ".EXE":
                            case ".COM":
                                listView1.Items.Add(files[i].Name, 3);   
                                break;
                            case ".MP4":
                            case ".AVI":
                            case ".MKV":
                                listView1.Items.Add(files[i].Name, 4);   
                                break;
                            case ".PDF":
                                listView1.Items.Add(files[i].Name, 5);   
                                break;
                            case ".DOC":
                            case ".DOCX":
                                listView1.Items.Add(files[i].Name, 6);   
                                break;
                            case ".PNG":
                            case ".JPG":
                            case ".JPEG":
                                break;
                            default:
                                listView1.Items.Add(files[i].Name, 0);   
                                break;
                        }
                    }
                    for (int i = 0; i < dirs.Length; i++)
                        listView1.Items.Add(dirs[i].Name, 1);      // index of the folder is one
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
                MessageBox.Show("Code to show the contextMenuStrip"); // how to callback the context menu strip???
        }

    }
}
