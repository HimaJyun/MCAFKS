using System.IO;

namespace MCAFKS.ChatWatcher {
    abstract class ChatWatcher {
        protected FileStream file;
        protected long length = 0;

        public ChatWatcher(string path) {
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

        protected abstract string Read();
    }
}
