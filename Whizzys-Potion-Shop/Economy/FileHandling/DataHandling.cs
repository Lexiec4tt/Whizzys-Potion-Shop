using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace Economy.FileHandling
{
    // saving data
    public class SaveData
    {
        public string PlayerName { get; set; } = "";
        public int Balance { get; set; }
        public int CurrentDay { get; set; }
        public Dictionary<string, int> UpgradeLevels { get; set; } = new();
        public Dictionary<int, int> Inventory { get; set; } = new();
        public List<int> UnlockedPotions { get; set; } = new();
    }

    // saving methods
    public static class DataHandling
    {
        private static readonly JsonSerializerOptions Options = new() { WriteIndented = true };

        public static bool Save(SaveData saveData, string PATH)
        {
            try
            {
                string folder = Path.GetDirectoryName(PATH) ?? "";
                if (folder != "")
                    Directory.CreateDirectory(folder);

                string json = JsonSerializer.Serialize(saveData, Options);

                File.AppendAllText(PATH, json + Environment.NewLine);

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static SaveData? Load(string PATH)
        {
            try
            {
                if (!File.Exists(PATH)) return null;
                return JsonSerializer.Deserialize<SaveData>(File.ReadAllText(PATH));
            }
            catch (Exception) { return null; }
        }

        public static string DefaultPath()
        {
            string appData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            return Path.Combine(appData, "Whizzys-Potion-Shop", "save.json");
        }

        public static string SavesFolder()
        {
            string appData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            return Path.Combine(appData, "Whizzys-Potion-Shop", "Saves");
        }

        public static string PathFor(string playerName)
        {
            foreach (char c in Path.GetInvalidFileNameChars()) { playerName.Replace(c, '_'); }
            ;
            return Path.Combine(SavesFolder(), playerName + ".json");
        }

        public static List<SaveData> LoadAll()
        {
            List<SaveData> saves = new List<SaveData>();

            if (!Directory.Exists(SavesFolder())) return saves;

            foreach (string file in Directory.GetFiles(SavesFolder(), "*.json"))
            {
                SaveData? data = Load(file);
                if (data != null) saves.Add(data);
            }

            return saves;
        }
    }
}