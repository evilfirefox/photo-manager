using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhotoManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            targetFolderText.Text = folderBrowserDialog1.SelectedPath;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            folderBrowserDialog2.ShowDialog();
            backupFolderText.Text = folderBrowserDialog2.SelectedPath;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.logInfo("Processing folder: " + targetFolderText.Text);
            string[] photos = Directory.GetFiles(targetFolderText.Text);
            int total = photos.Length;
            int complete = 0;
            this.logInfo(total + " files found.");
            foreach (var item in photos)
            {
                FileInfo info = new FileInfo(item);
                this.logInfo("File: " + info.Name);
                if (backupSwitch.Checked)
                {
                    this.logInfo("File " + info.Name + " copied to " + backupFolderText.Text + " folder.");
                    info.CopyTo(backupFolderText.Text + Path.DirectorySeparatorChar + info.Name);
                }
                string newPath = targetFolderText.Text + Path.DirectorySeparatorChar + info.Name + prefixText.Text + info.LastWriteTime.ToString("yyyyMMdd") + info.Extension;
                info.MoveTo(newPath);
                progress.Value = (++complete / total) * 100;
                this.logInfo("File updated.");
            }
            this.logInfo(complete + " of " + total + " files renamed.");
        }

        protected void logInfo(string message)
        {
            logText.Text += message + Environment.NewLine;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            backupFolderText.Enabled = backupFolderButton.Enabled = backupSwitch.Checked;
        }
    }
}
