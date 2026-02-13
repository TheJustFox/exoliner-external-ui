using Newtonsoft.Json;
using System;
using System.IO;

namespace ExolinerExternalUI.Classes {
    internal class FileManager {
        public static string BasePath = AppDomain.CurrentDomain.BaseDirectory;
        public static string ScriptsPath = Path.Combine(BasePath, "scripts");
        public static string AutoexecPath = Path.Combine(BasePath, "autoexec");
        public static string ConfigPath = Path.Combine(BasePath, "config.json");
        public static string PayloadFile = Path.Combine(BasePath, "payload.lua");

        public class Configuration {
            public string JWT { get; set; }
            public bool AutoLogin { get; set; }
            public int FolderRescanTime { get; set; }
            public bool AutoExec { get; set; }
            public bool ExtraPayload { get; set; }
            public bool SoundEffects { get; set; }

            public Configuration() {
                this.JWT = null;
                this.AutoLogin = false;
                this.FolderRescanTime = 3000;
                this.AutoExec = false;
                this.SoundEffects = true;
                this.ExtraPayload = false;
            }
        }
        public static Configuration CurrentSettings;

        public static void Init() {
            if (!Directory.Exists(ScriptsPath)) {
                Directory.CreateDirectory(ScriptsPath);
            }
            if (!Directory.Exists(AutoexecPath)) {
                Directory.CreateDirectory(AutoexecPath);
            }
            if (!File.Exists(PayloadFile)) {
                File.WriteAllText(PayloadFile, "");
            }
        }

        public static string GetPayload() {
            if (!File.Exists(PayloadFile)) {
                File.WriteAllText(PayloadFile, "");
            }
            if (!CurrentSettings.ExtraPayload) return "";
            return File.ReadAllText(PayloadFile);
        }

        public static string[] GetScripts() {
            if (!Directory.Exists(ScriptsPath)) {
                Directory.CreateDirectory(ScriptsPath);
            }
            return Directory.GetFiles(ScriptsPath);
        }

        public static string[] GetAutoExec() {
            if (!Directory.Exists(AutoexecPath)) {
                Directory.CreateDirectory(AutoexecPath);
            }
            return Directory.GetFiles(AutoexecPath);
        }

        public static void LoadSettings() {
            if (!File.Exists(ConfigPath)) {
                CurrentSettings = new Configuration();
                return;
            }
            string Data = File.ReadAllText(ConfigPath);
            CurrentSettings = JsonConvert.DeserializeObject<Configuration>(Data);
        }

        public static void SaveSettings() {
            File.WriteAllText(ConfigPath, JsonConvert.SerializeObject(CurrentSettings));
        }
    }
}
