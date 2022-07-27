using Discord;
using Discord.Commands;
using Discord.WebSocket;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using GiphyDotNet.Manager;

namespace Discord_Bot
{
    public class Bot
    {
        Giphy g = new Giphy("g1HLl7dQfMsO8Vd9k4RmbFx8l9hN7aQz");
        
        DiscordKeys key;
        Random random;
        
        string fileName = @"\Discord-Keys.JSON";
        string exeLocation;
        string filePath;

        DiscordSocketClient botClient;
        CommandService commands;
        IServiceProvider serviceProvider;
       

        public const string PREFIX = "!";

        public Bot()
        {
            exeLocation = System.Reflection.Assembly.GetExecutingAssembly().Location;
            
            // Directory of the exe File
            //filePath = System.IO.Path.GetDirectoryName(exeLocation) + fileName;

            // Desktop 
            filePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)+"\\Keys" + fileName;
            key = new DiscordKeys(filePath);
            Helper.LoadLists();
        }

        public async Task Connect()
        {
            commands = new CommandService();
            botClient = new DiscordSocketClient();
           
            serviceProvider = ConfigureServices();
            await botClient.LoginAsync(Discord.TokenType.Bot, key.Token);

            await botClient.StartAsync();

            BotEvents();

            Console.ReadKey();

            Disconnect();
        }

        private void BotEvents()
        {
            botClient.Log += BotClient_Log;
            botClient.Ready += BotClient_Ready;
            botClient.MessageReceived += BotClient_MessageReceived;
        }

        public IServiceProvider ConfigureServices()
        {
            return new ServiceCollection()
                      .AddSingleton<BotCommandModule>()
                      .BuildServiceProvider();
        }


        private async Task BotClient_Ready()
        {
            await commands.AddModulesAsync(Assembly.GetEntryAssembly(), serviceProvider);
            await botClient.SetGameAsync("Hört zu");
        }

        private Task BotClient_Log(LogMessage arg)
        {
            Console.WriteLine(arg);
            return Task.CompletedTask;
        }

        public async Task Disconnect()
        {
            await botClient.StopAsync();
        }
        private async Task BotClient_MessageReceived(SocketMessage arg)
        {
            SocketUserMessage message = arg as SocketUserMessage;
            
            int commandPosition = 0;
            if(message.HasStringPrefix(PREFIX, ref commandPosition))
            {
                SocketCommandContext context = new SocketCommandContext(botClient, message);
                var result = await commands.ExecuteAsync(context, commandPosition, serviceProvider);
                if(!result.IsSuccess)
                {
                    Console.WriteLine(result.ErrorReason);
                }
            }
        }

    }
}
