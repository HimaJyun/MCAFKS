using System;
using System.IO;
using System.Text;

namespace MCAFKS.ChatWatcher {
    class StandardChatWatcher : ChatWatcher {
        private readonly string chatPrefix = @"[CHAT] ";
        private readonly int logPrefixSize = (@"[00:00:00] [Client thread/INFO]: ").Length;
        private readonly int prefixSize;

        private readonly StringBuilder builder = new StringBuilder();

        public StandardChatWatcher(string path) : base(path) {
            prefixSize = logPrefixSize + chatPrefix.Length;
        }

        override protected string Read() {
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
