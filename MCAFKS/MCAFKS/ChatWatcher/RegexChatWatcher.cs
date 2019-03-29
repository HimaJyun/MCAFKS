using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace MCAFKS.ChatWatcher {
    class RegexChatWatcher : ChatWatcher {
        private readonly Regex regex = new Regex(@"^\[[0-9]{2}:[0-9]{2}:[0-9]{2}\] \[.+\]: \[CHAT\] (?<text>.*)", RegexOptions.Compiled);

        private readonly StringBuilder builder = new StringBuilder();

        public RegexChatWatcher(string path) : base(path) { }

        protected override string Read() {
            builder.Clear();

            byte[] buffer = new byte[file.Length - length];
            file.Read(buffer, 0, buffer.Length);
            // 932 == Shift_JIS
            using (StringReader reader = new StringReader(Encoding.GetEncoding(932).GetString(buffer))) {
                string line;
                while ((line = reader.ReadLine()) != null) {
                    var match = regex.Match(line);
                    // マッチしない
                    if (!match.Success) {
                        continue;
                    }

                    builder.Append(match.Groups["text"].Value);
                    builder.Append(Environment.NewLine);
                }
            }

            return builder.ToString();
        }
    }
}
