using System;
using System.ComponentModel;
using System.Drawing;
using System.Xml.Serialization;

namespace MCAFKS {

    public class Config {
        /// <summary>
        /// trueなら設定画面をスキップする
        /// </summary>
        public bool IsSkipSettings = false;

        public string LogFile = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\.minecraft\logs\latest.log";
        public int CheckInterval = 5000;

        [XmlIgnore]
        public Color ColorUnread = Color.Green;
        [XmlIgnore]
        public Color ColorAlreadyRead = Color.Black;
        #region colorXml
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        [XmlElement("ColorUnread")]
        public int _ColorUnread {
            get { return ColorUnread.ToArgb(); }
            set { this.ColorUnread = Color.FromArgb(value); }
        }
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        [XmlElement("ColorAlreadyRead")]
        public int _ColorAlreadyRead {
            get { return ColorAlreadyRead.ToArgb(); }
            set { this.ColorAlreadyRead = Color.FromArgb(value); }
        }
        #endregion colorXml

        public bool IsTopMost = false;
        public bool IsAutoScroll = false;
    }
}
