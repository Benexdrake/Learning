using Newtonsoft.Json;

namespace YoutubeApiConsole
{
    public class YoutubeKeys
    {
        public string APIKey { get; set; }

        public YoutubeKeys(string filePath)
        {
            LoadKeys(filePath);
        }

        public void LoadKeys(string filePath)
        {
            using (StreamReader r = new StreamReader(filePath))
            {
                string json = r.ReadToEnd();
                dynamic array = JsonConvert.DeserializeObject(json);
                APIKey = array[0];
            }
        }
    }
}
