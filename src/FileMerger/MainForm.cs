using System;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Config.NET;
using System.Collections.Generic;
using System.Linq;
using System.Timers;

namespace FileMerger {
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();
        }

        private System.Timers.Timer _timer;


        //Format: 30 Day Top Donator {30_day_donator} Most Recent Donator {most_recent_donator} Followers this stream {session_follower_count}
        //Month: {30_day_donator} Recent: {most_recent_donator} and New Wolves: {session_follower_count}
        //http://www.codeproject.com/Articles/271669/Using-FileSystemWatcher-to-monitor-multiple-direct
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e) {
            if (MessageBox.Show("Are you sure that you want to exit?", "Exit?",
                       MessageBoxButtons.YesNo,
                       MessageBoxIcon.Information) == DialogResult.No) {
                e.Cancel = true;
            }
        }

        private void btnExit_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void btnSave_Click(object sender, EventArgs e) {
            //try {
            //    if (string.IsNullOrEmpty(txtFileOne.Text) || string.IsNullOrWhiteSpace(txtFileOne.Text)) {
            //        throw new NullReferenceException("File path one can not be null");
            //    }
            //    if (string.IsNullOrEmpty(txtFileTwo.Text) || string.IsNullOrWhiteSpace(txtFileTwo.Text)) {
            //        throw new NullReferenceException("File path two can not be null");
            //    }
            //    if (string.IsNullOrEmpty(txtFileThree.Text) || string.IsNullOrWhiteSpace(txtFileThree.Text)) {
            //        throw new NullReferenceException("File path three can not be null");
            //    }
            //    if (string.IsNullOrEmpty(txtFileOutput.Text) || string.IsNullOrWhiteSpace(txtFileOutput.Text)) {
            //        throw new NullReferenceException("File path output can not be null");
            //    }
            //    LogMessage("Saving settings");
            //    var file = new ConfigFile("", "fmSettings");
            //    file.AddConfig("fileOne", txtFileOne.Text);
            //    file.AddConfig("fileTwo", txtFileTwo.Text);
            //    file.AddConfig("fileThree", txtFileThree.Text);
            //    file.AddConfig("fileOutput", txtFileOutput.Text);
            //    file.AddConfig("runOnStart", cbWatchOnStartUp.Checked.ToString());
            //    file.AddConfig("minimizeToTray", cbSystemTray.Checked.ToString());
            //    file.AddConfig("fileOutputFormat", rtxtFormat.Text);
            //    file.AddConfig("refreshInterval", nudSeconds.Value.ToString());
            //    file.Write();
            //    LogMessage("Settings saved");
            //    if (MessageBox.Show("Restart required to apply new settings, restart?", "Restart?",
            //       MessageBoxButtons.YesNo,
            //       MessageBoxIcon.Information) == DialogResult.Yes) {
            //        Application.Restart();
            //    }
            //}
            //catch (Exception ex) {
            //    LogMessage($"Failed to save. Error: {ex.ToString()}");
            //    MessageBox.Show($"Failed to save. Error: {ex.ToString()}");

            //}
            try {
                var file = new ConfigFile("", "fmSettings");
                file.AddConfig("paths", GetPathsFromDictionary());
                file.AddConfig("fileOutput", txtFileOutput.Text);
                file.AddConfig("runOnStart", cbWatchOnStartUp.Checked.ToString());
                file.AddConfig("minimizeToTray", cbSystemTray.Checked.ToString());
                file.AddConfig("fileOutputFormat", rtxtFormat.Text);
                file.AddConfig("refreshInterval", nudSeconds.Value.ToString());
                file.Write();
                LogMessage("Settings saved");
                if (MessageBox.Show("Restart required to apply new settings, restart?", "Restart?",
                   MessageBoxButtons.YesNo,
                   MessageBoxIcon.Information) == DialogResult.Yes) {
                    Application.Restart();
                }
            }
            catch (Exception ex) {
                LogMessage($"Failed to save. Error: {ex}");
                MessageBox.Show($"Failed to save. Error: {ex}");

            }
        }

        private string GetPathsFromDictionary() {
            return string.Join(",", FileMergerSettings.Files.Select(x => x.Key + ";" + x.Value).ToArray());
        }

        private void MainForm_Load(object sender, EventArgs e) {
            btnStart.Enabled = false;
            try {
                this.Text = $@"FileMerger (C) SharpDevs 2016";
                var file = new ConfigFile("", "fmSettings");
                if (file.FileExists()) {
                    LogMessage("Loading settings..");
                    file.Load();
                    FileMergerSettings.FileOutput = file.GetConfig("fileOutput");
                    FileMergerSettings.StartOnStartup = Convert.ToBoolean(file.GetConfig("runOnStart"));
                    FileMergerSettings.MinimizeToTray = Convert.ToBoolean(file.GetConfig("minimizeToTray"));
                    FileMergerSettings.OutputFormat = file.GetConfig("fileOutputFormat");
                    FileMergerSettings.RefreshInterval = (double)Convert.ToInt32(file.GetConfig("refreshInterval"));
                    FileMergerSettings.Files = LoadFilesFromSetting(file.GetConfig("paths"));
                    txtFileOutput.Text = FileMergerSettings.FileOutput;
                    cbWatchOnStartUp.Checked = FileMergerSettings.StartOnStartup;
                    cbSystemTray.Checked = FileMergerSettings.MinimizeToTray;
                    rtxtFormat.Text = FileMergerSettings.OutputFormat;
                    nudSeconds.Value = (decimal)FileMergerSettings.RefreshInterval;
                    ReLoadCache();
                    btnStart.Enabled = true;
                    //
                    if (FileMergerSettings.StartOnStartup) {

                        StartTimers();
                        gbFiles.Enabled = false;
                        gbSettings.Enabled = false;
                        btnStart.Enabled = false;
                        btnExit.Enabled = false;
                        btnSave.Enabled = false;
                        rtxtFormat.Enabled = false;
                        btnStop.Enabled = true;
                    }
                    else {
                        btnStop.Enabled = false;
                        btnStart.Enabled = true;
                    }
                    LogMessage("Done loading settings.");
                }
                else {
                    btnStop.Enabled = false;
                    btnStart.Enabled = false;
                }
            }
            catch (Exception ex) {
                LogMessage($"Failed to load Error: {ex.ToString()}");
                MessageBox.Show($"Failed to load Error: {ex.ToString()}");
            }
        }

        private Dictionary<string, string> LoadFilesFromSetting(string input) {
            var paths = input.Split(',');
            return paths.Select(path => path.Split(';')).ToDictionary(parts => parts[0], parts => parts[1]);
        }


        private void btnFileOutput_Click(object sender, EventArgs e) {
            txtFileOutput.Text = GetFilePath();
        }

        private string GetFilePath() {
            try {
                var ofd = new OpenFileDialog {
                    Filter = @"Textfiles|*.txt",
                    Multiselect = false,
                    CheckFileExists = true
                };
                var result = ofd.ShowDialog();
                return result == DialogResult.OK ? ofd.FileName : "";

            }
            catch (Exception ex) {
                LogMessage($"Failed to get path Error: {ex.ToString()}");
                MessageBox.Show($"Failed to get path Error: {ex.ToString()}");
                return "";
            }
        }

        private void btnClearConfig_Click(object sender, EventArgs e) {
            try {
                var file = new ConfigFile("", "fmSettings");
                file.Delete();
                if (MessageBox.Show("Restart required, restart?", "Restart?",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information) == DialogResult.Yes) {
                    Application.Restart();
                }

            }
            catch (Exception ex) {
                LogMessage($"Failed to clear config. Error: {ex.ToString()}");
                MessageBox.Show($"Failed to clear config. Error: {ex.ToString()}");
            }
        }


        private void LogMessage(string message) {
            Invoke((MethodInvoker)delegate {
                var log = rtxtLog.Text;
                var newText = $"[{DateTime.Now}] " + message + Environment.NewLine + log;
                rtxtLog.Clear();
                rtxtLog.Text = newText;
            });
        }



        private void MainForm_Resize(object sender, EventArgs e) {

            notifyIcon1.BalloonTipTitle = "FileMerger";
            notifyIcon1.BalloonTipText = "FileMerger is still running in the background. Click the system tray to get me back.";

            switch (this.WindowState) {
                case FormWindowState.Minimized:
                    if (FileMergerSettings.MinimizeToTray) {

                        notifyIcon1.Visible = true;
                        notifyIcon1.ShowBalloonTip(500);
                        this.Hide();
                    }
                    break;
                case FormWindowState.Normal:
                    notifyIcon1.Visible = false;
                    break;
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e) {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }



        private static void ReLoadCache() {
            FileMergerSettings.FileCache.Clear();
            foreach (var file in FileMergerSettings.Files) {
                FileMergerSettings.FileCache.Add(file.Key, ReadFile(file.Value));
            }

        }
        //Sleep the method? Bad for updates tho..?
        static void WriteFile() {

            try {
                var outputFormat = FileMergerSettings.OutputFormat;
                var outFile = FileMergerSettings.FileOutput;
                foreach (var file in FileMergerSettings.FileCache) {
                    outputFormat = Regex.Replace(outputFormat, file.Key, file.Value);

                }

                //Output file is locked? By writer? Dunno.. danThink
                using (var writer = new StreamWriter(outFile, false)) {
                    writer.Write(outputFormat);
                }
            }
            catch (Exception ex) {
                string dosomething = "1";
            }
        }

        private void btnMergeFilesNow_Click(object sender, EventArgs e) {
            LogMessage("Merging files");
            WriteFile();
            LogMessage("Done merging files");
        }


        private void btnStart_Click(object sender, EventArgs e) {
            StartTimers();
            gbFiles.Enabled = false;
            gbSettings.Enabled = false;
            btnStart.Enabled = false;
            btnExit.Enabled = false;
            btnSave.Enabled = false;
            rtxtFormat.Enabled = false;
            btnStop.Enabled = true;
        }

        private void StartTimers() {
            int interval = (int)TimeSpan.FromSeconds((double)FileMergerSettings.RefreshInterval).TotalMilliseconds;
            System.Timers.Timer one = new System.Timers.Timer { Interval = interval };
            one.Elapsed += One_Elapsed;
            _timer = one;
            one.Start();
        }

        private void One_Elapsed(object sender, ElapsedEventArgs e) {
            try {
                LogMessage("Timer elapsed, updating file..");
                ReLoadCache();
                WriteFile();
                LogMessage("Done updating file..");
            }
            catch (Exception ex) {

                LogMessage($"Failed to updaste. Error: {ex.ToString()}");
            }
        }

        private void btnStop_Click(object sender, EventArgs e) {
            _timer.Stop();
            gbFiles.Enabled = true;
            gbSettings.Enabled = true;
            btnStart.Enabled = true;
            btnExit.Enabled = true;
            btnSave.Enabled = true;
            rtxtFormat.Enabled = true;
            btnStop.Enabled = false;
        }

        private static string ReadFile(string filePath) {
            try {
                var sendBack = "";
                using (StreamReader reader = new StreamReader(filePath)) {
                    sendBack = reader.ReadToEnd();
                }
                return sendBack;
            }
            catch (Exception ex) {

                return "";
            }

        }

        private void btnWriteLog_Click(object sender, EventArgs e) {
            File.WriteAllLines("FileMergerLog.txt", rtxtLog.Lines);
        }
    }
}
