using Newtonsoft.Json;

namespace BlazorASV.Data;

public class Helper
{
    public static void SaveConfig(Config obj)
    {
        string jsonString = JsonConvert.SerializeObject(obj, Formatting.Indented);
        File.WriteAllText("Config.json", jsonString);
    }

    public static Config LoadConfig()
    {
        string strResult = File.ReadAllText("Config.json");
        Config config = JsonConvert.DeserializeObject<Config>(strResult);
        return config;
    }
}

