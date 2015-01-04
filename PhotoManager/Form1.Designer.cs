namespace PhotoManager
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.backupFolderButton = new System.Windows.Forms.Button();
            this.targetFolderButton = new System.Windows.Forms.Button();
            this.backupFolderText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.prefixText = new System.Windows.Forms.TextBox();
            this.targetFolderText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.processButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.logText = new System.Windows.Forms.TextBox();
            this.progress = new System.Windows.Forms.ProgressBar();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowserDialog2 = new System.Windows.Forms.FolderBrowserDialog();
            this.backupSwitch = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.backupSwitch);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.backupFolderButton);
            this.groupBox1.Controls.Add(this.targetFolderButton);
            this.groupBox1.Controls.Add(this.backupFolderText);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.prefixText);
            this.groupBox1.Controls.Add(this.targetFolderText);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(362, 103);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Backup folder";
            // 
            // backupFolderButton
            // 
            this.backupFolderButton.Enabled = false;
            this.backupFolderButton.Location = new System.Drawing.Point(328, 70);
            this.backupFolderButton.Name = "backupFolderButton";
            this.backupFolderButton.Size = new System.Drawing.Size(28, 23);
            this.backupFolderButton.TabIndex = 6;
            this.backupFolderButton.Text = "...";
            this.backupFolderButton.UseVisualStyleBackColor = true;
            this.backupFolderButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // targetFolderButton
            // 
            this.targetFolderButton.Location = new System.Drawing.Point(328, 17);
            this.targetFolderButton.Name = "targetFolderButton";
            this.targetFolderButton.Size = new System.Drawing.Size(28, 23);
            this.targetFolderButton.TabIndex = 5;
            this.targetFolderButton.Text = "...";
            this.targetFolderButton.UseVisualStyleBackColor = true;
            this.targetFolderButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // backupFolderText
            // 
            this.backupFolderText.Enabled = false;
            this.backupFolderText.Location = new System.Drawing.Point(126, 72);
            this.backupFolderText.Name = "backupFolderText";
            this.backupFolderText.Size = new System.Drawing.Size(196, 20);
            this.backupFolderText.TabIndex = 4;
            this.backupFolderText.Text = "F:\\tmp\\test\\backup";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Prefix";
            // 
            // prefixText
            // 
            this.prefixText.Location = new System.Drawing.Point(105, 46);
            this.prefixText.Name = "prefixText";
            this.prefixText.Size = new System.Drawing.Size(251, 20);
            this.prefixText.TabIndex = 2;
            this.prefixText.Text = "__";
            // 
            // targetFolderText
            // 
            this.targetFolderText.Location = new System.Drawing.Point(105, 20);
            this.targetFolderText.Name = "targetFolderText";
            this.targetFolderText.Size = new System.Drawing.Size(217, 20);
            this.targetFolderText.TabIndex = 1;
            this.targetFolderText.Text = "F:\\tmp\\test";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Target folder";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(293, 260);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // processButton
            // 
            this.processButton.Location = new System.Drawing.Point(281, 103);
            this.processButton.Name = "processButton";
            this.processButton.Size = new System.Drawing.Size(75, 23);
            this.processButton.TabIndex = 2;
            this.processButton.Text = "Process";
            this.processButton.UseVisualStyleBackColor = true;
            this.processButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.logText);
            this.groupBox2.Controls.Add(this.progress);
            this.groupBox2.Controls.Add(this.processButton);
            this.groupBox2.Location = new System.Drawing.Point(12, 122);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(362, 132);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Progress";
            // 
            // logText
            // 
            this.logText.Location = new System.Drawing.Point(9, 19);
            this.logText.Multiline = true;
            this.logText.Name = "logText";
            this.logText.ReadOnly = true;
            this.logText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.logText.Size = new System.Drawing.Size(347, 78);
            this.logText.TabIndex = 4;
            // 
            // progress
            // 
            this.progress.Location = new System.Drawing.Point(9, 103);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(266, 23);
            this.progress.TabIndex = 3;
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // backupSwitch
            // 
            this.backupSwitch.AutoSize = true;
            this.backupSwitch.Location = new System.Drawing.Point(105, 75);
            this.backupSwitch.Name = "backupSwitch";
            this.backupSwitch.Size = new System.Drawing.Size(15, 14);
            this.backupSwitch.TabIndex = 8;
            this.backupSwitch.UseVisualStyleBackColor = true;
            this.backupSwitch.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 295);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "photo-manager";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button backupFolderButton;
        private System.Windows.Forms.Button targetFolderButton;
        private System.Windows.Forms.TextBox backupFolderText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox prefixText;
        private System.Windows.Forms.TextBox targetFolderText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button processButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox logText;
        private System.Windows.Forms.ProgressBar progress;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog2;
        private System.Windows.Forms.CheckBox backupSwitch;
    }
}

