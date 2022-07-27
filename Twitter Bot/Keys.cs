using Newtonsoft.Json;

namespace Twitter_Bot
{
    public class Keys
    {
        public string APIKey { get; private set; }
        public string APIKeySecret { get; private set; }
        public string BearerToken { get; private set; }
        public string AccessToken { get; private set; }
        public string AccessTokenSecret { get; private set; }
        public string ClientID { get; set; }
        public string ClientSecret { get; set; }

        public Keys(string filePath)
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
                APIKeySecret = array[1];
                BearerToken = array[2];
                AccessToken = array[3];
                AccessTokenSecret = array[4];
                ClientID = array[5];
                ClientSecret = array[6];
            }
        }
    }
}
