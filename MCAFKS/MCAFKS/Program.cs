using System;
using System.IO;
using System.Windows.Forms;

namespace MCAFKS {
    static class Program {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static int Main(string[] args) {
            string configPath = Directory.GetCurrentDirectory() + @"\config.xml";

            ConfigLoader loader = null;
            Config config = null;
            try {
                loader = new ConfigLoader(args.Length > 0 ? args[0] : configPath);
                config = loader.Load();
            } catch (ArgumentException ae) {
                MessageBox.Show(ae.Message, "初期化エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 1;
            } catch (InvalidOperationException) {
                DialogResult result = MessageBox.Show(
                    "設定ファイルを読み取れませんでした" + Environment.NewLine
                    + "設定をリセットしますか？" + Environment.NewLine + Environment.NewLine
                    + "指定したファイル：" + loader.Path
                    , "初期化エラー", MessageBoxButtons.YesNo, MessageBoxIcon.Error);

                if (result == DialogResult.No) {
                    return 1;
                }
                loader.Reset();
                config = loader.Load();
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new UI.LogView(config));

            loader.Save();
            return 0;
        }
    }
}
