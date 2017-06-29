using System;
using System.IO;
using System.Text;

namespace MCAFKS {
    class ChatWatcher {

        private readonly string chatPrefix = @"[CHAT] ";
        private readonly int logPrefixSize = (@"[00:00:00] [Client thread/INFO]: ").Length;
        private readonly int prefixSize;

        private FileStream file;

        private long length = 0;
        private readonly StringBuilder builder = new StringBuilder();

        public ChatWatcher(string path) {
            prefixSize = logPrefixSize + chatPrefix.Length;

            ReOpen(path);
        }

        public void ReOpen(string path) {
            file = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            length = file.Length;
        }

        public void Close() {
            file.Close();
        }

        public string Check() {
            // 変化なし
            if (file.Length == length) {
                return null;
            } else if (file.Length < length) {
                // ファイルが縮んだ==起動時のログローテーション
                length = 0;
            }

            file.Seek(length, SeekOrigin.Begin);
            string result = Read();
            length = file.Length;

            return result;
        }

        private string Read() {
            builder.Clear();

            byte[] buffer = new byte[file.Length - length];
            file.Read(buffer, 0, buffer.Length);
            // 932 == Shift_JIS
            using (StringReader reader = new StringReader(Encoding.GetEncoding(932).GetString(buffer))) {

                string line;
                while ((line = reader.ReadLine()) != null) {
                    // 文字数が少ない(明らかに違う)ならスキップ
                    if (line.Length < prefixSize) {
                        continue;
                    }

                    string prefix = line.Substring(logPrefixSize, chatPrefix.Length);
                    if (prefix != chatPrefix) { // "[CHAT] "になっていない == チャットじゃない
                        continue;
                    }

                    builder.Append(line.Substring(prefixSize, line.Length - prefixSize));
                    builder.Append(Environment.NewLine);
                }
            }

            return builder.ToString();
        }

    }
}
