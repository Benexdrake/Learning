using TwitchLib;
using TwitchLib.Api;
using TwitchLib.Client;
using TwitchLib.Client.Events;
using TwitchLib.Client.Models;
using TwitchLib.Communication.Events;
using TwitchLib.Communication;
using TwitchLib.Api.Helix.Models.Users.GetUsers;
using TwitchLib.Api.Helix;
using TwitchLib.Api.Helix.Models.Users.GetUserFollows;

namespace Twitch_Stream_App
{
    public class Bot
    {
        ConnectionCredentials creds;
        TwitchAPI twitchAPI;
        TwitchClient client;
        TwitchKeys key;
        Random random;
        Main main;

        public string BotName { get; set; }

        int viewerCount = 0;

        public Bot(Main _main)
        {
            main = _main;
            random = new Random();
        }

        public void Connect()
        {
            string exeLocation = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string path = System.IO.Path.GetDirectoryName(exeLocation) + @"\Twitch-Keys.JSON";

            //string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Twitch-Keys.JSON";

            key = new TwitchKeys(path);

            BotName = key.Username;

            viewerCount = 0;

            twitchAPI = new TwitchAPI();
            twitchAPI.Settings.ClientId = key.ClientID;
            twitchAPI.Settings.AccessToken = key.AccessToken;

            var s = twitchAPI.Helix.Users.GetAccessToken();

            

            creds = new ConnectionCredentials(key.Username, key.OAUTH);

            client = new TwitchClient();

            client.OnLog += Client_OnLog;
            client.OnError += Client_OnError;
            client.OnMessageReceived += Client_OnMessageReceived;
            client.OnChatCommandReceived += Client_On_Chat_CommandReceived;
            client.OnUserJoined += Client_OnUserJoined;
            client.OnUserLeft += Client_OnUserLeft;
            client.OnUserStateChanged += Client_OnUserStateChanged;

            client.Initialize(creds, key.Username);
            client.Connect();
            client.OnConnected += Client_OnConnected;
        }

        private void Client_OnUserStateChanged(object? sender, OnUserStateChangedArgs e)
        {
        }

        private void Client_OnUserLeft(object? sender, OnUserLeftArgs e)
        {
            if (e.Username != key.Username)
            {
                viewerCount--;
                client.SendMessage(key.Username, $"Danke {e.Username} fürs vorbeischauen");
                main.DeleteViewer(e.Username);
                main.ViewCounter(viewerCount.ToString());
            }
        }

        private void Client_OnUserJoined(object? sender, OnUserJoinedArgs e)
        {
            if(e.Username != key.Username)
            {
                main.AddViewer(e.Username);
                client.SendMessage(key.Username, $"Willkommen {e.Username}, viel spaß beim zuschauen");
                viewerCount++;
                main.ViewCounter(viewerCount.ToString());
            }
        }

        private void Client_OnConnected(object? sender, OnConnectedArgs e)
        {
            main.Log(DateTime.Now + ": [Bot]: Connected" + Environment.NewLine);   
        }

        private void Client_On_Chat_CommandReceived(object? sender, OnChatCommandReceivedArgs e)
        {
            string command = e.Command.CommandText;
            command = command.ToLower();

            switch (command)
            {
                case "dice":
                    int dice = random.Next(1, 6);
                    client.SendMessage(key.Username, $"Du würfelst die {dice}");
                    break;
                case "hi":
                    client.SendMessage(e.Command.ChatMessage.DisplayName, $"Hallo {e.Command.ChatMessage.DisplayName}");
                    break;
            }
        }

        private async void Client_OnMessageReceived(object? sender, OnMessageReceivedArgs e)
        {
            main.ChatBox($">>> [{e.ChatMessage.DisplayName}]: {e.ChatMessage.Message}" + Environment.NewLine);
        }

        private async void Client_OnError(object sender, OnErrorEventArgs e)
        {
            main.Log(DateTime.Now + ": " +e.Exception.Message + Environment.NewLine);
        }

        private async void Client_OnLog(object sender, OnLogArgs e)
        {
            main.Log(DateTime.Now + " " + e.Data + Environment.NewLine);
        }

        public void Disconnect()
        {
            client.Disconnect();
        }

        public void SendMessage(string text)
        {
            client.SendMessage(key.Username,text);
        }

        public void OpenProfile()
        {
            
        }

        public async Task BlockViewer(string userID)
        {
            await twitchAPI.Helix.Users.BlockUserAsync(userID);
        }

        public async Task<User> GetUser(List<string> userList)
        {
            return twitchAPI.Helix.Users.GetUsersAsync(null, userList).Result.Users[0];
        }
        public async Task<User[]> GetUserList(List<string> userList)
        {
            return twitchAPI.Helix.Users.GetUsersAsync(null, userList).Result.Users;
        }

        public async Task FollowViewer(string viewerID)
        {
            await twitchAPI.Helix.Users.CreateUserFollows(key.UserID, viewerID);
            MessageBox.Show(viewerID);
        }

        public async Task UnFollowViewer(string viewerID)
        {
            await twitchAPI.Helix.Users.DeleteUserFollows(key.UserID, viewerID);
        }

        public async Task<Follow[]> FollowUsersRespone(List<string> userList)
        {
            var userid = GetUser(userList).Result.Id;
            var user = twitchAPI.Helix.Users.GetUsersFollowsAsync(fromId: userid).Result.Follows;
            return user;
        }
    }
}
