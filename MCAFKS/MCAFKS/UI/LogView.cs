using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MCAFKS.UI {
    public partial class LogView : Form {
        private readonly Config config;
        private readonly ChatWatcher watcher;

        public LogView(Config config) {
            this.config = config;

            if (!config.IsSkipSettings) {
                openSettingsForm();
            }

            watcher = new ChatWatcher(config.LogFile);

            InitializeComponent();
        }

        private void LogView_Load(object sender, System.EventArgs e) {
            TopMost = config.IsTopMost;

            checkboxTopMost.Checked = config.IsTopMost;
            checkBoxAutoScroll.Checked = config.IsAutoScroll;

            timerChatWatch.Interval = config.CheckInterval;
            timerChatWatch.Enabled = true;

            saveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        }

        private void LogView_FormClosed(object sender, FormClosedEventArgs e) {
            watcher.Close();
        }

        private void addChat(string chat) {
            int caret = richTextView.SelectionStart;
            int length = richTextView.SelectionLength;

            richTextView.SelectionStart = richTextView.Text.Length;
            richTextView.SelectionColor = config.ColorUnread;

            richTextView.AppendText(chat);

            viewScroll(caret, length);
        }

        private void chatRead() {
            int caret = richTextView.SelectionStart;
            int length = richTextView.SelectionLength;
            richTextView.SelectAll();
            richTextView.SelectionColor = config.ColorAlreadyRead;
            richTextView.SelectionLength = 0;

            viewScroll(caret, length);
        }

        private void viewScroll(int caret, int length) {
            richTextView.SelectionStart = config.IsAutoScroll ? richTextView.Text.Length : caret;
            richTextView.SelectionLength = length;
            richTextView.Focus();
            richTextView.ScrollToCaret();
        }

        private void openSettingsForm() {
            Settings form = new Settings(config);
            form.ShowDialog(this);
            form.Dispose();
        }

        private async void timerChatWatch_TickAsync(object sender, System.EventArgs e) {
            string result = await Task.Run(() => watcher.Check());
            if (result != null) {
                addChat(result);
            }
        }

        private void checkBoxAutoScroll_CheckedChanged(object sender, System.EventArgs e) {
            config.IsAutoScroll = checkBoxAutoScroll.Checked;
        }

        private void checkboxTopMost_CheckedChanged(object sender, System.EventArgs e) {
            config.IsTopMost = checkboxTopMost.Checked;
            TopMost = checkboxTopMost.Checked;
        }

        private void buttonAlreadyRead_Click(object sender, System.EventArgs e) {
            chatRead();
        }

        private void readToolStripMenuItem_Click(object sender, System.EventArgs e) {
            chatRead();
        }

        private void settingsToolStripMenuItem_Click(object sender, System.EventArgs e) {
            timerChatWatch.Enabled = false;
            openSettingsForm();
            timerChatWatch.Interval = config.CheckInterval;
            watcher.ReOpen(config.LogFile);
            timerChatWatch.Enabled = true;
        }

        private void copyToolStripMenuItem_Click(object sender, System.EventArgs e) {
            Clipboard.SetDataObject(richTextView.SelectedText, true);
        }

        private void saveToolStripMenuItem1_Click(object sender, System.EventArgs e) {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK) {
                using (StreamWriter writer = new StreamWriter(saveFileDialog1.OpenFile())) {
                    writer.Write(richTextView.Text.Replace("\n", "\r\n"));
                }
            }
        }
    }
}
