namespace MCAFKS.UI
{
    partial class LogView
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogView));
            this.checkboxTopMost = new System.Windows.Forms.CheckBox();
            this.buttonAlreadyRead = new System.Windows.Forms.Button();
            this.richTextView = new System.Windows.Forms.RichTextBox();
            this.checkBoxAutoScroll = new System.Windows.Forms.CheckBox();
            this.timerChatWatch = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.readToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkboxTopMost
            // 
            this.checkboxTopMost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkboxTopMost.AutoSize = true;
            this.checkboxTopMost.Location = new System.Drawing.Point(12, 230);
            this.checkboxTopMost.Name = "checkboxTopMost";
            this.checkboxTopMost.Size = new System.Drawing.Size(102, 16);
            this.checkboxTopMost.TabIndex = 2;
            this.checkboxTopMost.Text = "常に手前に表示";
            this.checkboxTopMost.UseVisualStyleBackColor = true;
            this.checkboxTopMost.CheckedChanged += new System.EventHandler(this.checkboxTopMost_CheckedChanged);
            // 
            // buttonAlreadyRead
            // 
            this.buttonAlreadyRead.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAlreadyRead.Location = new System.Drawing.Point(197, 223);
            this.buttonAlreadyRead.Name = "buttonAlreadyRead";
            this.buttonAlreadyRead.Size = new System.Drawing.Size(75, 23);
            this.buttonAlreadyRead.TabIndex = 3;
            this.buttonAlreadyRead.Text = "既読";
            this.buttonAlreadyRead.UseVisualStyleBackColor = true;
            this.buttonAlreadyRead.Click += new System.EventHandler(this.buttonAlreadyRead_Click);
            // 
            // richTextView
            // 
            this.richTextView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextView.BackColor = System.Drawing.SystemColors.Control;
            this.richTextView.ContextMenuStrip = this.contextMenuStrip1;
            this.richTextView.Location = new System.Drawing.Point(12, 12);
            this.richTextView.Name = "richTextView";
            this.richTextView.ReadOnly = true;
            this.richTextView.Size = new System.Drawing.Size(260, 190);
            this.richTextView.TabIndex = 4;
            this.richTextView.Text = "";
            // 
            // checkBoxAutoScroll
            // 
            this.checkBoxAutoScroll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxAutoScroll.AutoSize = true;
            this.checkBoxAutoScroll.Location = new System.Drawing.Point(12, 208);
            this.checkBoxAutoScroll.Name = "checkBoxAutoScroll";
            this.checkBoxAutoScroll.Size = new System.Drawing.Size(94, 16);
            this.checkBoxAutoScroll.TabIndex = 5;
            this.checkBoxAutoScroll.Text = "自動スクロール";
            this.checkBoxAutoScroll.UseVisualStyleBackColor = true;
            this.checkBoxAutoScroll.CheckedChanged += new System.EventHandler(this.checkBoxAutoScroll_CheckedChanged);
            // 
            // timerChatWatch
            // 
            this.timerChatWatch.Tick += new System.EventHandler(this.timerChatWatch_TickAsync);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.readToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.saveToolStripMenuItem1,
            this.toolStripMenuItem1,
            this.settingsToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.contextMenuStrip1.Size = new System.Drawing.Size(155, 98);
            // 
            // readToolStripMenuItem
            // 
            this.readToolStripMenuItem.Name = "readToolStripMenuItem";
            this.readToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.readToolStripMenuItem.Text = "既読";
            this.readToolStripMenuItem.Click += new System.EventHandler(this.readToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.copyToolStripMenuItem.Text = "コピー(&C)";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem1
            // 
            this.saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
            this.saveToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem1.Size = new System.Drawing.Size(154, 22);
            this.saveToolStripMenuItem1.Text = "保存(&S)";
            this.saveToolStripMenuItem1.Click += new System.EventHandler(this.saveToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(151, 6);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.settingsToolStripMenuItem.Text = "設定";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileName = "チャット.txt";
            this.saveFileDialog1.Filter = "テキストファイル(*.txt)|*.txt|すべてのファイル(*.*)|*.*";
            this.saveFileDialog1.FilterIndex = 0;
            this.saveFileDialog1.RestoreDirectory = true;
            // 
            // LogView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.checkBoxAutoScroll);
            this.Controls.Add(this.richTextView);
            this.Controls.Add(this.buttonAlreadyRead);
            this.Controls.Add(this.checkboxTopMost);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "LogView";
            this.Text = "MCAFKS";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LogView_FormClosed);
            this.Load += new System.EventHandler(this.LogView_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkboxTopMost;
        private System.Windows.Forms.Button buttonAlreadyRead;
        private System.Windows.Forms.RichTextBox richTextView;
        private System.Windows.Forms.CheckBox checkBoxAutoScroll;
        private System.Windows.Forms.Timer timerChatWatch;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem readToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}