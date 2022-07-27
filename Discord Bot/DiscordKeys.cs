using Newtonsoft.Json;

namespace Discord_Bot
{
    public class DiscordKeys
    {
        public string ApplicationID { get; set; }
        public string PublicKey { get; set; }
        public string ClientID { get; set; }
        public string ClientSecret { get; set; }
        public string Token { get; set; }

        public DiscordKeys(string filePath)
        {
            LoadKeys(filePath);
        }

        public void LoadKeys(string filePath)
        {
            using (StreamReader r = new StreamReader(filePath))
            {
                string json = r.ReadToEnd();
                dynamic array = JsonConvert.DeserializeObject(json);

                ApplicationID = array[0];
                PublicKey = array[1];
                ClientID = array[2];
                ClientSecret = array[3];
                Token = array[4];
            }
        }
    }
}
