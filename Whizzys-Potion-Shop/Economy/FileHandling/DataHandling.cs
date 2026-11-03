using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;

namespace Economy.FileHandling
{
    // saving data
    public class SaveData
    {
        public int Balance {  get; set; }
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
                if (folder != "") Directory.CreateDirectory(folder);

                File.WriteAllText(PATH, JsonSerializer.Serialize(saveData, Options));
                return true;
            }
            catch (Exception) { return false; }
        }
        public static SaveData? Load(string PATH)
        {
            try
            {
                if (!File.Exists(PATH)) return null;
                return JsonSerializer.Deserialize<SaveData>(File.ReadAllText(PATH));
            
            } catch (Exception) { return null; }
        }

        public static string DefaultPath()
        {
            string appData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            return Path.Combine(appData, "WhizzyPotionShop", "save.json");
        }

    }
}
