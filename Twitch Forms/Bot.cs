using TwitchLib;
using TwitchLib.Client;
using TwitchLib.Client.Events;
using TwitchLib.Client.Models;
using TwitchLib.Communication.Events;

namespace Twitch_Forms
{
    public class Bot
    {
        ConnectionCredentials creds;
        TwitchClient client;
        Keys key;
        Random random;
        Form1 main;

        

        public Bot(Form1 _main)
        {
            main = _main;
            random = new Random();
        }

        public void Connect()
        {
            main.ClearLog();
            client = new TwitchClient();
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Twitch-Keys.JSON";
            key = new Keys(path);
            creds = new ConnectionCredentials(key.Username, key.OAUTH);

            //main.txt_Log.Text += "[Bot]: Connecting...";
            //Console.WriteLine("[Bot]: Connecting...");

            
            client.OnLog += Client_OnLog;
            client.OnError += Client_OnError;
            client.OnMessageReceived += Client_OnMessageReceived;
            client.OnChatCommandReceived += ClientOnChatCommandReceived;
            client.OnUserJoined += Client_OnUserJoined;
            client.OnUserLeft += Client_OnUserLeft;

            client.Initialize(creds, key.Username);
            client.Connect();
            client.OnConnected += Client_OnConnected;
        }

        private void Client_OnUserLeft(object? sender, OnUserLeftArgs e)
        {
            client.SendMessage(key.Username, $"Danke {e.Username} fürs vorbeischauen");
            main.DeleteViewer(e.Username);
        }

        private void Client_OnUserJoined(object? sender, OnUserJoinedArgs e)
        {
            if(e.Username != key.Username)
            {
                client.SendMessage(key.Username, $"Willkommen {e.Username}, viel spaß beim zuschauen");
                main.AddViewer(e.Username);
            }
            
        }

        private void Client_OnConnected(object? sender, OnConnectedArgs e)
        {
            

            main.Log("[Bot]: Connected" + Environment.NewLine);
            
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
            main.Log("XXXXXXXX <<<<>>>>"+e.Exception.Message + Environment.NewLine);
            //main.txt_Log.Text += e.Exception.Message;
            //Console.WriteLine(e.Exception.Message);
        }

        private async void Client_OnLog(object sender, OnLogArgs e)
        {
            main.Log(e.Data + Environment.NewLine);
        }

        private string Text(string t)
        {
            return t;
        }

        public void Disconnect()
        {
            client.Disconnect();
        }



    }
}
