namespace FileMerger {    partial class MainForm {        /// <summary>        /// Required designer variable.        /// </summary>        private System.ComponentModel.IContainer components = null;        /// <summary>        /// Clean up any resources being used.        /// </summary>        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>        protected override void Dispose(bool disposing) {            if (disposing && (components != null)) {                components.Dispose();            }            base.Dispose(disposing);        }        #region Windows Form Designer generated code        /// <summary>        /// Required method for Designer support - do not modify        /// the contents of this method with the code editor.        /// </summary>        private void InitializeComponent() {            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label4 = new System.Windows.Forms.Label();
            this.txtFileOutput = new System.Windows.Forms.TextBox();
            this.gbFiles = new System.Windows.Forms.GroupBox();
            this.btnFileOutput = new System.Windows.Forms.Button();
            this.gbSettings = new System.Windows.Forms.GroupBox();
            this.nudSeconds = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.btnWriteLog = new System.Windows.Forms.Button();
            this.btnMergeFilesNow = new System.Windows.Forms.Button();
            this.btnClearConfig = new System.Windows.Forms.Button();
            this.cbSystemTray = new System.Windows.Forms.CheckBox();
            this.cbWatchOnStartUp = new System.Windows.Forms.CheckBox();
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvFiles = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCopyKey = new System.Windows.Forms.Button();
            this.btnRemoveSelected = new System.Windows.Forms.Button();
            this.btnAddFile = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.rtxtLog = new System.Windows.Forms.RichTextBox();
            this.imgList = new System.Windows.Forms.ImageList(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.colKey = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rtxtFormat = new System.Windows.Forms.RichTextBox();
            this.gbFiles.SuspendLayout();
            this.gbSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSeconds)).BeginInit();
            this.tcMain.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiles)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Output:";
            // 
            // txtFileOutput
            // 
            this.txtFileOutput.Location = new System.Drawing.Point(57, 18);
            this.txtFileOutput.Name = "txtFileOutput";
            this.txtFileOutput.Size = new System.Drawing.Size(273, 20);
            this.txtFileOutput.TabIndex = 1;
            // 
            // gbFiles
            // 
            this.gbFiles.Controls.Add(this.btnFileOutput);
            this.gbFiles.Controls.Add(this.label4);
            this.gbFiles.Controls.Add(this.txtFileOutput);
            this.gbFiles.Location = new System.Drawing.Point(392, 267);
            this.gbFiles.Name = "gbFiles";
            this.gbFiles.Size = new System.Drawing.Size(374, 109);
            this.gbFiles.TabIndex = 4;
            this.gbFiles.TabStop = false;
            this.gbFiles.Text = "Files";
            // 
            // btnFileOutput
            // 
            this.btnFileOutput.Image = ((System.Drawing.Image)(resources.GetObject("btnFileOutput.Image")));
            this.btnFileOutput.Location = new System.Drawing.Point(336, 16);
            this.btnFileOutput.Name = "btnFileOutput";
            this.btnFileOutput.Size = new System.Drawing.Size(30, 23);
            this.btnFileOutput.TabIndex = 2;
            this.btnFileOutput.UseVisualStyleBackColor = true;
            this.btnFileOutput.Click += new System.EventHandler(this.btnFileOutput_Click);
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
            this.gbSettings.Location = new System.Drawing.Point(12, 267);
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
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tabPage1);
            this.tcMain.Controls.Add(this.tabPage3);
            this.tcMain.Controls.Add(this.tabPage2);
            this.tcMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.tcMain.ImageList = this.imgList;
            this.tcMain.Location = new System.Drawing.Point(0, 0);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(783, 261);
            this.tcMain.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.rtxtFormat);
            this.tabPage1.ImageIndex = 1;
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(775, 234);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Text";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tableLayoutPanel1);
            this.tabPage3.ImageIndex = 2;
            this.tabPage3.Location = new System.Drawing.Point(4, 23);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(775, 234);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Input";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dgvFiles, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(769, 228);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dgvFiles
            // 
            this.dgvFiles.AllowUserToAddRows = false;
            this.dgvFiles.AllowUserToDeleteRows = false;
            this.dgvFiles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFiles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colKey,
            this.colFile});
            this.dgvFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFiles.Location = new System.Drawing.Point(3, 43);
            this.dgvFiles.MultiSelect = false;
            this.dgvFiles.Name = "dgvFiles";
            this.dgvFiles.ReadOnly = true;
            this.dgvFiles.RowHeadersVisible = false;
            this.dgvFiles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFiles.Size = new System.Drawing.Size(763, 182);
            this.dgvFiles.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCopyKey);
            this.panel1.Controls.Add(this.btnRemoveSelected);
            this.panel1.Controls.Add(this.btnAddFile);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(763, 34);
            this.panel1.TabIndex = 1;
            // 
            // btnCopyKey
            // 
            this.btnCopyKey.Image = global::FileMerger.Properties.Resources.key_solid;
            this.btnCopyKey.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCopyKey.Location = new System.Drawing.Point(293, 5);
            this.btnCopyKey.Name = "btnCopyKey";
            this.btnCopyKey.Size = new System.Drawing.Size(137, 23);
            this.btnCopyKey.TabIndex = 1;
            this.btnCopyKey.Text = "Copy Key";
            this.btnCopyKey.UseVisualStyleBackColor = true;
            this.btnCopyKey.Click += new System.EventHandler(this.btnCopyKey_Click);
            // 
            // btnRemoveSelected
            // 
            this.btnRemoveSelected.Image = global::FileMerger.Properties.Resources.cancel;
            this.btnRemoveSelected.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemoveSelected.Location = new System.Drawing.Point(150, 5);
            this.btnRemoveSelected.Name = "btnRemoveSelected";
            this.btnRemoveSelected.Size = new System.Drawing.Size(137, 23);
            this.btnRemoveSelected.TabIndex = 0;
            this.btnRemoveSelected.Text = "Remove Selected";
            this.btnRemoveSelected.UseVisualStyleBackColor = true;
            this.btnRemoveSelected.Click += new System.EventHandler(this.btnRemoveSelected_Click);
            // 
            // btnAddFile
            // 
            this.btnAddFile.Image = global::FileMerger.Properties.Resources.add;
            this.btnAddFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddFile.Location = new System.Drawing.Point(7, 5);
            this.btnAddFile.Name = "btnAddFile";
            this.btnAddFile.Size = new System.Drawing.Size(137, 23);
            this.btnAddFile.TabIndex = 0;
            this.btnAddFile.Text = "Add File";
            this.btnAddFile.UseVisualStyleBackColor = true;
            this.btnAddFile.Click += new System.EventHandler(this.btnAddFile_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.rtxtLog);
            this.tabPage2.ImageIndex = 0;
            this.tabPage2.Location = new System.Drawing.Point(4, 23);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(775, 234);
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
            this.rtxtLog.Size = new System.Drawing.Size(769, 228);
            this.rtxtLog.TabIndex = 0;
            this.rtxtLog.Text = "";
            // 
            // imgList
            // 
            this.imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgList.ImageStream")));
            this.imgList.TransparentColor = System.Drawing.Color.Transparent;
            this.imgList.Images.SetKeyName(0, "action_log.png");
            this.imgList.Images.SetKeyName(1, "cog.png");
            this.imgList.Images.SetKeyName(2, "file_manager.png");
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
            this.btnStop.Location = new System.Drawing.Point(622, 383);
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
            this.btnStart.Location = new System.Drawing.Point(12, 383);
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
            this.btnExit.Location = new System.Drawing.Point(12, 412);
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
            this.btnSave.Location = new System.Drawing.Point(691, 412);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // colKey
            // 
            this.colKey.HeaderText = "Key";
            this.colKey.Name = "colKey";
            this.colKey.ReadOnly = true;
            // 
            // colFile
            // 
            this.colFile.HeaderText = "File";
            this.colFile.Name = "colFile";
            this.colFile.ReadOnly = true;
            // 
            // rtxtFormat
            // 
            this.rtxtFormat.BackColor = System.Drawing.SystemColors.Info;
            this.rtxtFormat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxtFormat.Location = new System.Drawing.Point(3, 3);
            this.rtxtFormat.Name = "rtxtFormat";
            this.rtxtFormat.Size = new System.Drawing.Size(769, 228);
            this.rtxtFormat.TabIndex = 0;
            this.rtxtFormat.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 444);
            this.Controls.Add(this.tcMain);
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
            this.tcMain.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiles)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }        #endregion        private System.Windows.Forms.Label label4;        private System.Windows.Forms.TextBox txtFileOutput;        private System.Windows.Forms.Button btnSave;        private System.Windows.Forms.Button btnExit;        private System.Windows.Forms.GroupBox gbFiles;        private System.Windows.Forms.GroupBox gbSettings;        private System.Windows.Forms.CheckBox cbWatchOnStartUp;        private System.Windows.Forms.Button btnStart;        private System.Windows.Forms.Button btnStop;        private System.Windows.Forms.Button btnClearConfig;        private System.Windows.Forms.TabControl tcMain;        private System.Windows.Forms.TabPage tabPage1;        private System.Windows.Forms.TabPage tabPage2;        private System.Windows.Forms.RichTextBox rtxtLog;        private System.Windows.Forms.ImageList imgList;        private System.Windows.Forms.NotifyIcon notifyIcon1;        private System.Windows.Forms.CheckBox cbSystemTray;        private System.Windows.Forms.Button btnMergeFilesNow;        private System.Windows.Forms.NumericUpDown nudSeconds;        private System.Windows.Forms.Label label7;        private System.Windows.Forms.Button btnWriteLog;        private System.Windows.Forms.Button btnFileOutput;        private System.Windows.Forms.TabPage tabPage3;        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;        private System.Windows.Forms.DataGridView dgvFiles;        private System.Windows.Forms.Panel panel1;        private System.Windows.Forms.Button btnRemoveSelected;        private System.Windows.Forms.Button btnAddFile;        private System.Windows.Forms.Button btnCopyKey;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKey;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFile;
        private System.Windows.Forms.RichTextBox rtxtFormat;
    }}