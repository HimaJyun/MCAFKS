using System.Collections.Generic;
using System.Windows.Forms;

namespace MCAFKS.UI {
    public partial class Settings : Form {
        private readonly KeyValuePair<string, WatcherType>[] watcherType = new KeyValuePair<string, WatcherType>[] {
            new KeyValuePair<string, WatcherType>("通常",WatcherType.Standard),
            new KeyValuePair<string, WatcherType>("正規表現",WatcherType.Regex)
        };

        private readonly Config config;

        public Settings(Config config) {
            this.config = config;

            InitializeComponent();
        }

        private void Settings_Load(object sender, System.EventArgs e) {
            textBoxLogPath.Text = config.LogFile;
            numericUpDownCheckInterval.Value = config.CheckInterval;

            int index = 0;
            for (int i = 0; i < watcherType.Length; i++) {
                if (watcherType[i].Value == config.SelectWatcher) {
                    index = i;
                }
            }
            // データソース変更でindex変更イベントが起きる
            selectWatcher.DataSource = watcherType;
            selectWatcher.ValueMember = "Value";
            selectWatcher.DisplayMember = "Key";
            selectWatcher.SelectedIndex = index;

            textBoxColorUnread.BackColor = config.ColorUnread;
            textBoxColorAlreadyRead.BackColor = config.ColorAlreadyRead;

            checkBoxSkipSettings.Checked = config.IsSkipSettings;
        }

        private void Settings_FormClosed(object sender, FormClosedEventArgs e) {
            config.LogFile = textBoxLogPath.Text;
            config.CheckInterval = decimal.ToInt32(numericUpDownCheckInterval.Value);

            config.ColorUnread = textBoxColorUnread.BackColor;
            config.ColorAlreadyRead = textBoxColorAlreadyRead.BackColor;

            config.IsSkipSettings = checkBoxSkipSettings.Checked;
        }

        private void buttonLogPath_Click(object sender, System.EventArgs e) {
            if (openFileDialogLogPath.ShowDialog() == DialogResult.OK) {
                textBoxLogPath.Text = openFileDialogLogPath.FileName;
            }
        }

        private void buttonColorUnread_Click(object sender, System.EventArgs e) {
            if (colorDialogSelect.ShowDialog() == DialogResult.OK) {
                textBoxColorUnread.BackColor = colorDialogSelect.Color;
            }
        }

        private void buttonColorAlreadyRead_Click(object sender, System.EventArgs e) {
            if (colorDialogSelect.ShowDialog() == DialogResult.OK) {
                textBoxColorAlreadyRead.BackColor = colorDialogSelect.Color;
            }
        }

        private void buttonSettingsSave_Click(object sender, System.EventArgs e) {
            this.Close();
        }

        private void selectWatcher_SelectedIndexChanged(object sender, System.EventArgs e) {
            config.SelectWatcher = watcherType[selectWatcher.SelectedIndex].Value;
        }
    }
}
