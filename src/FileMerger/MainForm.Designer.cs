namespace FileMerger {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.txtFileOne = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFileTwo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFileThree = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFileOutput = new System.Windows.Forms.TextBox();
            this.gbFiles = new System.Windows.Forms.GroupBox();
            this.btnFileOutput = new System.Windows.Forms.Button();
            this.btnFileThree = new System.Windows.Forms.Button();
            this.btnFileTwo = new System.Windows.Forms.Button();
            this.btnFileOne = new System.Windows.Forms.Button();
            this.gbSettings = new System.Windows.Forms.GroupBox();
            this.nudSeconds = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.btnWriteLog = new System.Windows.Forms.Button();
            this.btnMergeFilesNow = new System.Windows.Forms.Button();
            this.btnClearConfig = new System.Windows.Forms.Button();
            this.cbSystemTray = new System.Windows.Forms.CheckBox();
            this.cbWatchOnStartUp = new System.Windows.Forms.CheckBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.rtxtFormat = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.rtxtLog = new System.Windows.Forms.RichTextBox();
            this.imgList = new System.Windows.Forms.ImageList(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.gbFiles.SuspendLayout();
            this.gbSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSeconds)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "File 1:";
            // 
            // txtFileOne
            // 
            this.txtFileOne.Location = new System.Drawing.Point(55, 19);
            this.txtFileOne.Name = "txtFileOne";
            this.txtFileOne.Size = new System.Drawing.Size(273, 20);
            this.txtFileOne.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "File 2:";
            // 
            // txtFileTwo
            // 
            this.txtFileTwo.Location = new System.Drawing.Point(55, 45);
            this.txtFileTwo.Name = "txtFileTwo";
            this.txtFileTwo.Size = new System.Drawing.Size(273, 20);
            this.txtFileTwo.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "File 3:";
            // 
            // txtFileThree
            // 
            this.txtFileThree.Location = new System.Drawing.Point(55, 71);
            this.txtFileThree.Name = "txtFileThree";
            this.txtFileThree.Size = new System.Drawing.Size(273, 20);
            this.txtFileThree.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Output:";
            // 
            // txtFileOutput
            // 
            this.txtFileOutput.Location = new System.Drawing.Point(55, 97);
            this.txtFileOutput.Name = "txtFileOutput";
            this.txtFileOutput.Size = new System.Drawing.Size(273, 20);
            this.txtFileOutput.TabIndex = 1;
            // 
            // gbFiles
            // 
            this.gbFiles.Controls.Add(this.txtFileOne);
            this.gbFiles.Controls.Add(this.label1);
            this.gbFiles.Controls.Add(this.label2);
            this.gbFiles.Controls.Add(this.btnFileOutput);
            this.gbFiles.Controls.Add(this.txtFileTwo);
            this.gbFiles.Controls.Add(this.btnFileThree);
            this.gbFiles.Controls.Add(this.label3);
            this.gbFiles.Controls.Add(this.btnFileTwo);
            this.gbFiles.Controls.Add(this.txtFileThree);
            this.gbFiles.Controls.Add(this.btnFileOne);
            this.gbFiles.Controls.Add(this.label4);
            this.gbFiles.Controls.Add(this.txtFileOutput);
            this.gbFiles.Location = new System.Drawing.Point(12, 12);
            this.gbFiles.Name = "gbFiles";
            this.gbFiles.Size = new System.Drawing.Size(374, 130);
            this.gbFiles.TabIndex = 4;
            this.gbFiles.TabStop = false;
            this.gbFiles.Text = "Files";
            // 
            // btnFileOutput
            // 
            this.btnFileOutput.Image = ((System.Drawing.Image)(resources.GetObject("btnFileOutput.Image")));
            this.btnFileOutput.Location = new System.Drawing.Point(334, 95);
            this.btnFileOutput.Name = "btnFileOutput";
            this.btnFileOutput.Size = new System.Drawing.Size(30, 23);
            this.btnFileOutput.TabIndex = 2;
            this.btnFileOutput.UseVisualStyleBackColor = true;
            this.btnFileOutput.Click += new System.EventHandler(this.btnFileOutput_Click);
            // 
            // btnFileThree
            // 
            this.btnFileThree.Image = ((System.Drawing.Image)(resources.GetObject("btnFileThree.Image")));
            this.btnFileThree.Location = new System.Drawing.Point(334, 69);
            this.btnFileThree.Name = "btnFileThree";
            this.btnFileThree.Size = new System.Drawing.Size(30, 23);
            this.btnFileThree.TabIndex = 2;
            this.btnFileThree.UseVisualStyleBackColor = true;
            this.btnFileThree.Click += new System.EventHandler(this.btnFileThree_Click);
            // 
            // btnFileTwo
            // 
            this.btnFileTwo.Image = ((System.Drawing.Image)(resources.GetObject("btnFileTwo.Image")));
            this.btnFileTwo.Location = new System.Drawing.Point(334, 43);
            this.btnFileTwo.Name = "btnFileTwo";
            this.btnFileTwo.Size = new System.Drawing.Size(30, 23);
            this.btnFileTwo.TabIndex = 2;
            this.btnFileTwo.UseVisualStyleBackColor = true;
            this.btnFileTwo.Click += new System.EventHandler(this.btnFileTwo_Click);
            // 
            // btnFileOne
            // 
            this.btnFileOne.Image = global::FileMerger.Properties.Resources.folder_search;
            this.btnFileOne.Location = new System.Drawing.Point(334, 18);
            this.btnFileOne.Name = "btnFileOne";
            this.btnFileOne.Size = new System.Drawing.Size(30, 23);
            this.btnFileOne.TabIndex = 2;
            this.btnFileOne.UseVisualStyleBackColor = true;
            this.btnFileOne.Click += new System.EventHandler(this.btnFileOne_Click);
            // 
            // gbSettings
            // 
            this.gbSettings.Controls.Add(this.nudSeconds);
            this.gbSettings.Controls.Add(this.label7);
            this.gbSettings.Controls.Add(this.btnWriteLog);
            this.gbSettings.Controls.Add(this.btnMergeFilesNow);
            this.gbSettings.Controls.Add(this.btnClearConfig);
            this.gbSettings.Controls.Add(this.cbSystemTray);
            this.gbSettings.Controls.Add(this.cbWatchOnStartUp);
            this.gbSettings.Location = new System.Drawing.Point(12, 148);
            this.gbSettings.Name = "gbSettings";
            this.gbSettings.Size = new System.Drawing.Size(374, 109);
            this.gbSettings.TabIndex = 5;
            this.gbSettings.TabStop = false;
            this.gbSettings.Text = "Settings";
            // 
            // nudSeconds
            // 
            this.nudSeconds.Location = new System.Drawing.Point(145, 77);
            this.nudSeconds.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudSeconds.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudSeconds.Name = "nudSeconds";
            this.nudSeconds.Size = new System.Drawing.Size(92, 20);
            this.nudSeconds.TabIndex = 3;
            this.nudSeconds.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Refresh interval (Seconds):";
            // 
            // btnWriteLog
            // 
            this.btnWriteLog.Image = global::FileMerger.Properties.Resources.action_log;
            this.btnWriteLog.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWriteLog.Location = new System.Drawing.Point(246, 72);
            this.btnWriteLog.Name = "btnWriteLog";
            this.btnWriteLog.Size = new System.Drawing.Size(123, 23);
            this.btnWriteLog.TabIndex = 1;
            this.btnWriteLog.Text = "Write Log";
            this.btnWriteLog.UseVisualStyleBackColor = true;
            this.btnWriteLog.Click += new System.EventHandler(this.btnWriteLog_Click);
            // 
            // btnMergeFilesNow
            // 
            this.btnMergeFilesNow.Image = global::FileMerger.Properties.Resources.arrow_merge;
            this.btnMergeFilesNow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMergeFilesNow.Location = new System.Drawing.Point(246, 43);
            this.btnMergeFilesNow.Name = "btnMergeFilesNow";
            this.btnMergeFilesNow.Size = new System.Drawing.Size(123, 23);
            this.btnMergeFilesNow.TabIndex = 1;
            this.btnMergeFilesNow.Text = "Merge Now";
            this.btnMergeFilesNow.UseVisualStyleBackColor = true;
            this.btnMergeFilesNow.Click += new System.EventHandler(this.btnMergeFilesNow_Click);
            // 
            // btnClearConfig
            // 
            this.btnClearConfig.Image = global::FileMerger.Properties.Resources.cog_delete;
            this.btnClearConfig.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClearConfig.Location = new System.Drawing.Point(246, 14);
            this.btnClearConfig.Name = "btnClearConfig";
            this.btnClearConfig.Size = new System.Drawing.Size(123, 23);
            this.btnClearConfig.TabIndex = 1;
            this.btnClearConfig.Text = "Clear Config";
            this.btnClearConfig.UseVisualStyleBackColor = true;
            this.btnClearConfig.Click += new System.EventHandler(this.btnClearConfig_Click);
            // 
            // cbSystemTray
            // 
            this.cbSystemTray.AutoSize = true;
            this.cbSystemTray.Location = new System.Drawing.Point(7, 43);
            this.cbSystemTray.Name = "cbSystemTray";
            this.cbSystemTray.Size = new System.Drawing.Size(172, 17);
            this.cbSystemTray.TabIndex = 0;
            this.cbSystemTray.Text = "Minimize window to system tray";
            this.cbSystemTray.UseVisualStyleBackColor = true;
            // 
            // cbWatchOnStartUp
            // 
            this.cbWatchOnStartUp.AutoSize = true;
            this.cbWatchOnStartUp.Location = new System.Drawing.Point(7, 20);
            this.cbWatchOnStartUp.Name = "cbWatchOnStartUp";
            this.cbWatchOnStartUp.Size = new System.Drawing.Size(165, 17);
            this.cbWatchOnStartUp.TabIndex = 0;
            this.cbWatchOnStartUp.Text = "Start watching files on startup";
            this.cbWatchOnStartUp.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.ImageList = this.imgList;
            this.tabControl1.Location = new System.Drawing.Point(392, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(374, 294);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.rtxtFormat);
            this.tabPage1.ImageIndex = 1;
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(366, 267);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Configure";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(6, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(354, 23);
            this.label6.TabIndex = 1;
            this.label6.Text = "Variables: {file_one} {file_two} {file_three}";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rtxtFormat
            // 
            this.rtxtFormat.BackColor = System.Drawing.SystemColors.Info;
            this.rtxtFormat.Location = new System.Drawing.Point(6, 6);
            this.rtxtFormat.Name = "rtxtFormat";
            this.rtxtFormat.Size = new System.Drawing.Size(354, 96);
            this.rtxtFormat.TabIndex = 0;
            this.rtxtFormat.Text = "";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.rtxtLog);
            this.tabPage2.ImageIndex = 0;
            this.tabPage2.Location = new System.Drawing.Point(4, 23);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(366, 267);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Log";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // rtxtLog
            // 
            this.rtxtLog.BackColor = System.Drawing.SystemColors.Info;
            this.rtxtLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxtLog.Location = new System.Drawing.Point(3, 3);
            this.rtxtLog.Name = "rtxtLog";
            this.rtxtLog.ReadOnly = true;
            this.rtxtLog.Size = new System.Drawing.Size(360, 261);
            this.rtxtLog.TabIndex = 0;
            this.rtxtLog.Text = "";
            // 
            // imgList
            // 
            this.imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgList.ImageStream")));
            this.imgList.TransparentColor = System.Drawing.Color.Transparent;
            this.imgList.Images.SetKeyName(0, "action_log.png");
            this.imgList.Images.SetKeyName(1, "cog.png");
            this.imgList.Images.SetKeyName(2, "information.png");
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "FileMerger";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // btnStop
            // 
            this.btnStop.Image = global::FileMerger.Properties.Resources.control_stop_blue;
            this.btnStop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStop.Location = new System.Drawing.Point(242, 263);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(144, 23);
            this.btnStop.TabIndex = 3;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.Image = global::FileMerger.Properties.Resources.control_play_blue;
            this.btnStart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStart.Location = new System.Drawing.Point(12, 263);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(144, 23);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnExit
            // 
            this.btnExit.Image = global::FileMerger.Properties.Resources.cancel;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(12, 292);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = global::FileMerger.Properties.Resources.disk;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(311, 292);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 319);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.gbSettings);
            this.Controls.Add(this.gbFiles);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "FileMerger - (C) SharpDevs 2016";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.gbFiles.ResumeLayout(false);
            this.gbFiles.PerformLayout();
            this.gbSettings.ResumeLayout(false);
            this.gbSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSeconds)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFileOne;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFileTwo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFileThree;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFileOutput;
        private System.Windows.Forms.Button btnFileOne;
        private System.Windows.Forms.Button btnFileTwo;
        private System.Windows.Forms.Button btnFileThree;
        private System.Windows.Forms.Button btnFileOutput;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox gbFiles;
        private System.Windows.Forms.GroupBox gbSettings;
        private System.Windows.Forms.CheckBox cbWatchOnStartUp;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnClearConfig;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox rtxtLog;
        private System.Windows.Forms.ImageList imgList;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.CheckBox cbSystemTray;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox rtxtFormat;
        private System.Windows.Forms.Button btnMergeFilesNow;
        private System.Windows.Forms.NumericUpDown nudSeconds;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnWriteLog;
    }
}

