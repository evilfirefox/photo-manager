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
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
            targetFolderText.Text = Properties.Settings.Default.SourcePath;
            backupFolderText.Text = Properties.Settings.Default.BackupPath;
            prefixText.Text = Properties.Settings.Default.Prefix;
            backupSwitch.Checked = Properties.Settings.Default.BackupEnabled;
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
            this.resetEnv();
            this.logInfo("Processing folder: " + targetFolderText.Text);
            try
            {
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
                    string name = info.Name.Replace(info.Extension, "");
                    string newPath = targetFolderText.Text + Path.DirectorySeparatorChar + name + prefixText.Text + info.LastWriteTime.ToString(Properties.Settings.Default.TimestampFormat) + info.Extension;
                    info.MoveTo(newPath);
                    progress.Value = (++complete / total) * 100;
                    this.logInfo("File updated.");
                }
                this.logInfo(complete + " of " + total + " files renamed.");
            }
            catch (Exception ex)
            {
                this.logInfo("Error occured: " + ex.Message);
            }
        }

        protected void logInfo(string message)
        {
            logText.Text += message + Environment.NewLine;
            logText.SelectionStart = logText.Text.Length;
            logText.ScrollToCaret();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            backupFolderText.Enabled = backupFolderButton.Enabled = backupSwitch.Checked;
            Properties.Settings.Default.BackupEnabled = backupSwitch.Checked;
        }

        private void targetFolderText_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.SourcePath = folderBrowserDialog1.SelectedPath = targetFolderText.Text;
            this.resetEnv();
        }

        protected void resetEnv()
        {
            logText.Text = "";
            progress.Value = 0;
        }

        private void prefixText_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Prefix = prefixText.Text;
            this.resetEnv();
        }

        private void backupFolderText_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.BackupPath = folderBrowserDialog2.SelectedPath = backupFolderText.Text;
            this.resetEnv();
        }
    }
}
