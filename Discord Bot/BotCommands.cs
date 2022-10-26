using Discord;
using Discord.Commands;
using GiphyDotNet.Manager;
using GiphyDotNet.Model.Parameters;
using PokeAPI;
using System.Net.Http;
using MongoDB.Driver;

namespace Discord_Bot
{
    public class BotCommandModule : ModuleBase<SocketCommandContext>
    {

        [Command("hallo")]
        [Alias("hi")]        public async Task Hallo()
        {
            string gifURL = Helper.SearchGifs("Hallo").Result.Data.Url;
            await Context.Channel.DeleteMessageAsync(Context.Message);
            await Context.Channel.SendMessageAsync(gifURL);
        }

        [Command("hallo")]
        [Alias("hi")]
        public async Task Hallo(string param)
        {
            string user = Context.Message.Author.Mention;
            string gifURL = Helper.SearchGifs("Hallo").Result.Data.Url;
            await Context.Channel.DeleteMessageAsync(Context.Message);
            await Context.Channel.SendMessageAsync($"Hallo {param}");
            await Context.Channel.SendMessageAsync(gifURL);
        }

        [Command("gif", true)]
        [Alias("g")]
        public async Task Gif([Remainder] string param)
        {
            var gif = await Helper.SearchGifs(param);

            var embedfieldList = new List<EmbedFieldBuilder>();

            try
            {
                embedfieldList.Add(new EmbedFieldBuilder()
                {
                    IsInline = true,
                    Name = "Caption",
                    Value = gif.Data.Caption
                });
            }
            catch (Exception)
            {
            }
            try
            {
                embedfieldList.Add(new EmbedFieldBuilder()
                {
                    IsInline = true,
                    Name = "Rating",
                    Value = gif.Data.Rating
                });
            }
            catch (Exception)
            {
            }
            try
            {
                embedfieldList.Add(new EmbedFieldBuilder()
                {
                    IsInline = true,
                    Name = "Source",
                    Value = gif.Data.Source
                });
            }
            catch (Exception)
            {
            }
            
            var foot = new EmbedFooterBuilder()
            {
                IconUrl = gif.Data.ContentUrl,
                Text = gif.Data.Username
            };

            string thumbnailUrl = string.Empty;
            try
            {
                if (gif.Data.User.AvatarUrl != null)
                {
                    thumbnailUrl = gif.Data.User.AvatarUrl;
                }
            }
            catch (Exception)
            {
            }

            var builder = new EmbedBuilder()
            {
                Title = gif.Data.Title,
                Description = gif.Data.Username,
                ImageUrl = gif.Data.Images.Original.Url,
                ThumbnailUrl = thumbnailUrl,
                Color = Color.Blue,
                Fields = embedfieldList,
                Footer = foot,
                Author = new EmbedAuthorBuilder() { IconUrl = thumbnailUrl, Name = gif.Data.User.DisplayName, Url = gif.Data.User.ProfileUrl },
                Timestamp = DateTime.Parse(gif.Data.ImportDatetime),
                Url = gif.Data.Url
            };


            Console.WriteLine(gif.Data.User.AvatarUrl);

            await DeleteMessages(1);
            await Context.Channel.SendMessageAsync(embed: builder.Build());
        }

        [Command("pokemon", true)]
        [Alias("poke")]
        public async Task Pokemon(string param)
        {
            Pokemon pokemon = new Pokemon();
            bool isID = int.TryParse(param, out int id);

            if(!isID)
            {
                foreach (var p in Helper.Pokemon)
                {
                    if(p.Name.ToLower().Equals(param.ToLower()))
                    {
                        pokemon = p;
                    }
                }
            }
            else
            {
                pokemon = Helper.Pokemon[id - 1];
            }

            List<EmbedFieldBuilder> embedfieldList = new List<EmbedFieldBuilder>();

            foreach (var a in pokemon.Abilities)
            {
                embedfieldList.Add(new EmbedFieldBuilder()
                {
                    Name = a.Ability.Name,
                    Value = a.Ability.ID
                });
            }

            var footer = new EmbedFooterBuilder();
            foreach (var t in pokemon.Types)
            {
                footer.Text += t.Type.Name + " ";
            }

            var builder = new EmbedBuilder()
            {
                Title = pokemon.Name,
                ImageUrl = $"https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/other/official-artwork/{pokemon.ID}.png",
                Description = "Nothing to see here, because dont have descriptions in the API",
                Fields = embedfieldList,
                Footer = footer,
                ThumbnailUrl = pokemon.Sprites.FrontMale
            };
            await Context.Channel.DeleteMessageAsync(Context.Message);
            await Context.Channel.SendMessageAsync(embed: builder.Build());
        }

        [Command("profil",true)]
        [Alias("profile")]
        public async Task Profile([Remainder]string param)
        {
            string url = string.Empty;
            foreach (var item in Context.Message.Attachments)
            {
                url = item.Url;
                break;
            }
            
            var foot = new EmbedFooterBuilder()
            {
                IconUrl = "https://cdn-icons-png.flaticon.com/512/1172/1172477.png",
                Text = "cool"
            };

            var builder = new EmbedBuilder()
            {
                Title = Context.Message.Author.Username,
                Description = param,
                ImageUrl = url,
                ThumbnailUrl = "http://assets.stickpng.com/images/580b585b2edbce24c47b2493.png",
                Color = Color.Blue,
                Footer = foot,
                Author = new EmbedAuthorBuilder() { IconUrl = "https://cdn-icons-png.flaticon.com/512/1172/1172477.png", Name = Context.Message.Author.Username, Url = "https://www.google.com/" },
                Timestamp = DateTime.Now,
                Url = "https://www.google.com/"

            };
            await Context.Channel.DeleteMessageAsync(Context.Message);
            await Context.Channel.SendMessageAsync(embed: builder.Build());
        }

        [Command("purge")]
        public async Task Purge(string n)
        {
            await Context.Channel.DeleteMessageAsync(Context.Message);

            bool isNumber = int.TryParse(n, out int count);
            if(isNumber)
            {
                await Context.Channel.SendMessageAsync($"Channel {Context.Channel.Name} wird nun gepurged!");
                await DeleteMessages(count);
            }
            else
            {
                if(n.ToLower().Equals("all"))
                {
                    count = int.MaxValue;
                    await Context.Channel.SendMessageAsync($"Channel {Context.Channel.Name} wird nun gepurged!");
                    await DeleteMessages(count);
                }
                else
                {
                    await Context.Channel.SendMessageAsync(SearchCommands("purge").ErrorMessage);
                    await Task.Delay(5000);
                    await DeleteMessages(1);
                }
            }
        }
        [Command("help")]
        [Alias("?")]
        public async Task Help(string param)
        {
            var command = SearchCommands(param);
            string info;
            if(command != null)
            {
                info = command.Information;
            }
            else
            {
                info = "Command existiert nicht!";
            }
            await Context.Channel.SendMessageAsync(info);
        }

        [Command("anime")]
        public async Task Animes([Remainder] string param)
        {
            var client = new MongoClient("mongodb://localhost:27017");
            var db = client.GetDatabase("Crunchyroll");
            
            //IMongoCollection<Anime> collection = db.GetCollection<Anime>("Animes");

           // var Anime = from anime in collection.AsQueryable()
           //             where anime.Name.ToLower().Contains(param)
           //             select anime;

            //var result = Anime.FirstOrDefault();

            //if (result != null)
            //{


            //    var fields = new List<EmbedFieldBuilder>();

            //    fields.Add(new EmbedFieldBuilder()
            //    {
            //        Name = "Seasons",
            //        Value = result.Seasons.Length,
            //        IsInline = true
            //    });

            //    fields.Add(new EmbedFieldBuilder()
            //    {
            //        Name = "Episodes",
            //        Value = result.Episodes,
            //        IsInline = true
            //    });

            //    fields.Add(new EmbedFieldBuilder()
            //    {
            //        Name = "Rating",
            //        Value = result.Rating,
            //        IsInline = true
            //    });

            //    fields.Add(new EmbedFieldBuilder()
            //    {
            //        Name = "Tags",
            //        Value = result.GetTags(),
            //        IsInline = true
            //    });

            //    var foot = new EmbedFooterBuilder()
            //    {
            //        IconUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/0/08/Crunchyroll_Logo.png/857px-Crunchyroll_Logo.png",
            //        Text = "Crunchyroll"
            //    };

            //    var builder = new EmbedBuilder()
            //    {
            //        Title = result.Name,
            //        Description = result.Description,
            //        ImageUrl = result.Image,
            //        ThumbnailUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/0/08/Crunchyroll_Logo.png/857px-Crunchyroll_Logo.png",
            //        Color = Color.Orange,
            //        Fields = fields,
            //        Footer = foot,
            //        Author = new EmbedAuthorBuilder()
            //        { Name = result.Publisher },
            //        Url = result.Url
            //    };
            //    await Context.Channel.DeleteMessageAsync(Context.Message);
            //    await Context.Channel.SendMessageAsync(embed: builder.Build());
            //}
            //else
            //{
            //    await Context.Channel.DeleteMessageAsync(Context.Message);
            //    await Context.Channel.SendMessageAsync($"Anime: '{param}' not found.");
            //}

        }

        public async Task DeleteMessages(int n)
        {
            var messages = Context.Channel.GetMessagesAsync(n).Flatten();
            foreach (var h in await messages.ToArrayAsync())
            { 
                await Context.Channel.DeleteMessageAsync(h);
            }
        }

        public Commands SearchCommands(string param)
        {
            foreach (var item in Helper.Commands)
            {
                if (item.CommandName.Equals(param))
                {
                    return item;
                }
            }
            return null;
        }

       

        

    }
}
