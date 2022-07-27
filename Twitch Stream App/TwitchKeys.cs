using Newtonsoft.Json;

namespace Twitch_Stream_App
{
    public class TwitchKeys
    {
        public string Username { get; set; }
        public string OAUTH { get; set; }
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }
        public string ClientID { get; set; }
        public string UserID { get; set; }

        public TwitchKeys(string filePath)
        {
            LoadKeys(filePath);
        }

        public void LoadKeys(string filePath)
        {
            using (StreamReader r = new StreamReader(filePath))
            {
                string json = r.ReadToEnd();
                dynamic array = JsonConvert.DeserializeObject(json);
                Username = array[0];
                OAUTH = array[1];
                AccessToken = array[2];
                RefreshToken = array[3];
                ClientID = array[4];
                UserID = array[5]; 
            }
        }
    }
}
