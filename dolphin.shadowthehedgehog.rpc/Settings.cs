using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;

namespace Dolphin.ShadowTheHedgehog.RPC
{
    public class Settings
    {
        [JsonIgnore]
        private static string _filePath = $"{Program.ModDirectory}\\Settings.json";

        // Settings
        public bool OffensiveCaptions = false;

        // Read/Write
        public static Settings GetSettings()
        {
            if (!File.Exists(_filePath))
                new Settings().ToFile();

            return JsonConvert.DeserializeObject<Settings>(File.ReadAllText(_filePath));
        }

        public void ToFile()
        {
            File.WriteAllText(_filePath, JsonConvert.SerializeObject(this, Formatting.Indented));
        }
    }
}
