namespace MCAFKS.UI
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.groupBoxLogPath = new System.Windows.Forms.GroupBox();
            this.buttonLogPath = new System.Windows.Forms.Button();
            this.textBoxLogPath = new System.Windows.Forms.TextBox();
            this.groupBoxCheckInterval = new System.Windows.Forms.GroupBox();
            this.numericUpDownCheckInterval = new System.Windows.Forms.NumericUpDown();
            this.groupBoxColor = new System.Windows.Forms.GroupBox();
            this.labelColorAlreadyRead = new System.Windows.Forms.Label();
            this.labelColorUnread = new System.Windows.Forms.Label();
            this.buttonColorAlreadyRead = new System.Windows.Forms.Button();
            this.buttonColorUnread = new System.Windows.Forms.Button();
            this.buttonSettingsSave = new System.Windows.Forms.Button();
            this.checkBoxSkipSettings = new System.Windows.Forms.CheckBox();
            this.colorDialogSelect = new System.Windows.Forms.ColorDialog();
            this.openFileDialogLogPath = new System.Windows.Forms.OpenFileDialog();
            this.textBoxColorUnread = new System.Windows.Forms.TextBox();
            this.textBoxColorAlreadyRead = new System.Windows.Forms.TextBox();
            this.groupBoxLogPath.SuspendLayout();
            this.groupBoxCheckInterval.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCheckInterval)).BeginInit();
            this.groupBoxColor.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxLogPath
            // 
            this.groupBoxLogPath.Controls.Add(this.buttonLogPath);
            this.groupBoxLogPath.Controls.Add(this.textBoxLogPath);
            this.groupBoxLogPath.Location = new System.Drawing.Point(12, 12);
            this.groupBoxLogPath.Name = "groupBoxLogPath";
            this.groupBoxLogPath.Size = new System.Drawing.Size(260, 47);
            this.groupBoxLogPath.TabIndex = 0;
            this.groupBoxLogPath.TabStop = false;
            this.groupBoxLogPath.Text = "ログファイル";
            // 
            // buttonLogPath
            // 
            this.buttonLogPath.Location = new System.Drawing.Point(179, 18);
            this.buttonLogPath.Name = "buttonLogPath";
            this.buttonLogPath.Size = new System.Drawing.Size(75, 23);
            this.buttonLogPath.TabIndex = 1;
            this.buttonLogPath.Text = "開く";
            this.buttonLogPath.UseVisualStyleBackColor = true;
            this.buttonLogPath.Click += new System.EventHandler(this.buttonLogPath_Click);
            // 
            // textBoxLogPath
            // 
            this.textBoxLogPath.Location = new System.Drawing.Point(6, 20);
            this.textBoxLogPath.Name = "textBoxLogPath";
            this.textBoxLogPath.Size = new System.Drawing.Size(167, 19);
            this.textBoxLogPath.TabIndex = 0;
            // 
            // groupBoxCheckInterval
            // 
            this.groupBoxCheckInterval.Controls.Add(this.numericUpDownCheckInterval);
            this.groupBoxCheckInterval.Location = new System.Drawing.Point(12, 65);
            this.groupBoxCheckInterval.Name = "groupBoxCheckInterval";
            this.groupBoxCheckInterval.Size = new System.Drawing.Size(260, 43);
            this.groupBoxCheckInterval.TabIndex = 1;
            this.groupBoxCheckInterval.TabStop = false;
            this.groupBoxCheckInterval.Text = "更新のチェック間隔(ミリ秒)";
            // 
            // numericUpDownCheckInterval
            // 
            this.numericUpDownCheckInterval.Location = new System.Drawing.Point(6, 18);
            this.numericUpDownCheckInterval.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numericUpDownCheckInterval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownCheckInterval.Name = "numericUpDownCheckInterval";
            this.numericUpDownCheckInterval.Size = new System.Drawing.Size(248, 19);
            this.numericUpDownCheckInterval.TabIndex = 0;
            this.numericUpDownCheckInterval.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBoxColor
            // 
            this.groupBoxColor.Controls.Add(this.textBoxColorAlreadyRead);
            this.groupBoxColor.Controls.Add(this.textBoxColorUnread);
            this.groupBoxColor.Controls.Add(this.labelColorAlreadyRead);
            this.groupBoxColor.Controls.Add(this.labelColorUnread);
            this.groupBoxColor.Controls.Add(this.buttonColorAlreadyRead);
            this.groupBoxColor.Controls.Add(this.buttonColorUnread);
            this.groupBoxColor.Location = new System.Drawing.Point(12, 114);
            this.groupBoxColor.Name = "groupBoxColor";
            this.groupBoxColor.Size = new System.Drawing.Size(260, 76);
            this.groupBoxColor.TabIndex = 0;
            this.groupBoxColor.TabStop = false;
            this.groupBoxColor.Text = "色の設定";
            // 
            // labelColorAlreadyRead
            // 
            this.labelColorAlreadyRead.AutoSize = true;
            this.labelColorAlreadyRead.Location = new System.Drawing.Point(6, 52);
            this.labelColorAlreadyRead.Name = "labelColorAlreadyRead";
            this.labelColorAlreadyRead.Size = new System.Drawing.Size(80, 12);
            this.labelColorAlreadyRead.TabIndex = 5;
            this.labelColorAlreadyRead.Text = "既読メッセージ：";
            // 
            // labelColorUnread
            // 
            this.labelColorUnread.AutoSize = true;
            this.labelColorUnread.Location = new System.Drawing.Point(6, 23);
            this.labelColorUnread.Name = "labelColorUnread";
            this.labelColorUnread.Size = new System.Drawing.Size(80, 12);
            this.labelColorUnread.TabIndex = 4;
            this.labelColorUnread.Text = "未読メッセージ：";
            // 
            // buttonColorAlreadyRead
            // 
            this.buttonColorAlreadyRead.Location = new System.Drawing.Point(179, 47);
            this.buttonColorAlreadyRead.Name = "buttonColorAlreadyRead";
            this.buttonColorAlreadyRead.Size = new System.Drawing.Size(75, 23);
            this.buttonColorAlreadyRead.TabIndex = 3;
            this.buttonColorAlreadyRead.Text = "変更";
            this.buttonColorAlreadyRead.UseVisualStyleBackColor = true;
            this.buttonColorAlreadyRead.Click += new System.EventHandler(this.buttonColorAlreadyRead_Click);
            // 
            // buttonColorUnread
            // 
            this.buttonColorUnread.Location = new System.Drawing.Point(179, 18);
            this.buttonColorUnread.Name = "buttonColorUnread";
            this.buttonColorUnread.Size = new System.Drawing.Size(75, 23);
            this.buttonColorUnread.TabIndex = 2;
            this.buttonColorUnread.Text = "変更";
            this.buttonColorUnread.UseVisualStyleBackColor = true;
            this.buttonColorUnread.Click += new System.EventHandler(this.buttonColorUnread_Click);
            // 
            // buttonSettingsSave
            // 
            this.buttonSettingsSave.Location = new System.Drawing.Point(191, 196);
            this.buttonSettingsSave.Name = "buttonSettingsSave";
            this.buttonSettingsSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSettingsSave.TabIndex = 2;
            this.buttonSettingsSave.Text = "完了";
            this.buttonSettingsSave.UseVisualStyleBackColor = true;
            this.buttonSettingsSave.Click += new System.EventHandler(this.buttonSettingsSave_Click);
            // 
            // checkBoxSkipSettings
            // 
            this.checkBoxSkipSettings.AutoSize = true;
            this.checkBoxSkipSettings.Location = new System.Drawing.Point(12, 200);
            this.checkBoxSkipSettings.Name = "checkBoxSkipSettings";
            this.checkBoxSkipSettings.Size = new System.Drawing.Size(173, 16);
            this.checkBoxSkipSettings.TabIndex = 3;
            this.checkBoxSkipSettings.Text = "起動時にこの画面を表示しない";
            this.checkBoxSkipSettings.UseVisualStyleBackColor = true;
            // 
            // colorDialogSelect
            // 
            this.colorDialogSelect.FullOpen = true;
            // 
            // openFileDialogLogPath
            // 
            this.openFileDialogLogPath.Filter = "ログファイル(latest.log)|*.log";
            this.openFileDialogLogPath.Title = "開く";
            // 
            // textBoxColorUnread
            // 
            this.textBoxColorUnread.Enabled = false;
            this.textBoxColorUnread.Location = new System.Drawing.Point(92, 20);
            this.textBoxColorUnread.Name = "textBoxColorUnread";
            this.textBoxColorUnread.ReadOnly = true;
            this.textBoxColorUnread.Size = new System.Drawing.Size(81, 19);
            this.textBoxColorUnread.TabIndex = 6;
            // 
            // textBoxColorAlreadyRead
            // 
            this.textBoxColorAlreadyRead.Enabled = false;
            this.textBoxColorAlreadyRead.Location = new System.Drawing.Point(92, 49);
            this.textBoxColorAlreadyRead.Name = "textBoxColorAlreadyRead";
            this.textBoxColorAlreadyRead.ReadOnly = true;
            this.textBoxColorAlreadyRead.Size = new System.Drawing.Size(81, 19);
            this.textBoxColorAlreadyRead.TabIndex = 7;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 231);
            this.Controls.Add(this.checkBoxSkipSettings);
            this.Controls.Add(this.buttonSettingsSave);
            this.Controls.Add(this.groupBoxColor);
            this.Controls.Add(this.groupBoxCheckInterval);
            this.Controls.Add(this.groupBoxLogPath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Settings";
            this.Text = "MCAFKS - 設定";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Settings_FormClosed);
            this.Load += new System.EventHandler(this.Settings_Load);
            this.groupBoxLogPath.ResumeLayout(false);
            this.groupBoxLogPath.PerformLayout();
            this.groupBoxCheckInterval.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCheckInterval)).EndInit();
            this.groupBoxColor.ResumeLayout(false);
            this.groupBoxColor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxLogPath;
        private System.Windows.Forms.Button buttonLogPath;
        private System.Windows.Forms.TextBox textBoxLogPath;
        private System.Windows.Forms.GroupBox groupBoxCheckInterval;
        private System.Windows.Forms.NumericUpDown numericUpDownCheckInterval;
        private System.Windows.Forms.GroupBox groupBoxColor;
        private System.Windows.Forms.Button buttonColorUnread;
        private System.Windows.Forms.Button buttonColorAlreadyRead;
        private System.Windows.Forms.Label labelColorAlreadyRead;
        private System.Windows.Forms.Label labelColorUnread;
        private System.Windows.Forms.Button buttonSettingsSave;
        private System.Windows.Forms.CheckBox checkBoxSkipSettings;
        private System.Windows.Forms.ColorDialog colorDialogSelect;
        private System.Windows.Forms.OpenFileDialog openFileDialogLogPath;
        private System.Windows.Forms.TextBox textBoxColorAlreadyRead;
        private System.Windows.Forms.TextBox textBoxColorUnread;
    }
}