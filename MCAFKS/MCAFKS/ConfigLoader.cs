using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace MCAFKS {
    class ConfigLoader {

        public string Path { get; }
        private XmlSerializer serializer = new XmlSerializer(typeof(Config));

        private Config configCache = null;

        public ConfigLoader(string path) {
            if (path.IndexOfAny(System.IO.Path.GetInvalidPathChars()) > -1) {
                throw new AggregateException("ファイル名に使えない文字が含まれています" + Environment.NewLine
                    + "指定したファイル：" + path);
            }
            this.Path = path;
        }

        public Config Load() {
            if (configCache == null) {
                configCache = LoadFile();
            }
            return configCache;
        }

        private Config LoadFile() {
            if (!File.Exists(Path)) {
                return new Config();
            }

            using (FileStream stream = new FileStream(Path, FileMode.Open)) {
                return (Config)serializer.Deserialize(stream);
            }
        }

        public void Save() {
            SaveFile(configCache);
        }

        public void SaveFile(Config config) {
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.IndentChars = "\t";

            using (XmlWriter writer = XmlWriter.Create(Path, settings)) {
                serializer.Serialize(writer, config);
            }
        }

        public void Reset() {
            SaveFile(new Config());
        }
    }
}
