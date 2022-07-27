using TwitchLib;
using TwitchLib.Client;
using TwitchLib.Client.Events;
using TwitchLib.Client.Models;
using TwitchLib.Communication.Events;

namespace Twitch_Bot
{
    public class Bot
    {
        ConnectionCredentials creds;
        TwitchClient client;
        Keys key;
        Random random;

        public Bot()
        {
            random = new Random();


        }

        public void Connect()
        {
            client = new TwitchClient();
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Twitch-Keys.JSON";
            key = new Keys(path);
            creds = new ConnectionCredentials(key.Username, key.OAUTH);

            Console.WriteLine("[Bot]: Connecting...");

            
            client.OnLog += Client_OnLog;
            client.OnError += Client_OnError;
            client.OnMessageReceived += Client_OnMessageReceived;
            client.OnChatCommandReceived += ClientOnChatCommandReceived;
            client.OnUserJoined += Client_OnUserJoined;

            client.Initialize(creds, key.Username);
            client.Connect();
            client.OnConnected += Client_OnConnected;
        }

        private void Client_OnUserJoined(object? sender, OnUserJoinedArgs e)
        {
            if(e.Username != key.Username)
            client.SendMessage(key.Username, $"Willkommen {e.Username}, viel spaß beim zuschauen");
        }

        private void Client_OnConnected(object? sender, OnConnectedArgs e)
        {
            Console.WriteLine("[Bot]: Connected");
        }

        private void ClientOnChatCommandReceived(object? sender, OnChatCommandReceivedArgs e)
        {
            string command = e.Command.CommandText;
            command = command.ToLower();

            switch (command)
            {
                case "dice":
                    int dice = random.Next(1, 6);
                    client.SendMessage(key.Username, $"Du würfelst die {dice}");
                    break;
            }

            if(e.Command.ChatMessage.DisplayName == key.Username)
            {
                switch (command)
                {
                    case "hi":
                        client.SendMessage(key.Username, "Hi Boss");
                        break;
                }
            }
        }

        private void Client_OnMessageReceived(object? sender, OnMessageReceivedArgs e)
        {
            Console.WriteLine($"[{e.ChatMessage.DisplayName}]: {e.ChatMessage.Message}");
        }

        private void Client_OnError(object sender, OnErrorEventArgs e)
        {
            Console.WriteLine(e.Exception.Message);
        }

        private void Client_OnLog(object sender, OnLogArgs e)
        {
            Console.WriteLine(e.Data);
        }

        public void Disconnect()
        {
            client.Disconnect();
        }



    }
}
