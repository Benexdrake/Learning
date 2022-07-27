using GiphyDotNet.Manager;
using GiphyDotNet.Model.Parameters;
using PokeAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discord_Bot
{
    public class Helper
    {
        private static string[] uRLs;
        private static List<Pokemon> pokemon;
        private static Pokedex pokedex;

        public static int Count { get; set; }

        public static List<Pokemon> Pokemon { get => pokemon; set => pokemon = value; }
        public static List<List<string>> Description { get; set; }

        public static List<Commands> Commands { get; set; }

        public static Pokedex Pokedex { get => pokedex; set => pokedex = value; }

        private static async Task GetPokedexEntries(int pokeDexRegion)
        {
            Pokedex = await DataFetcher.GetApiObject<Pokedex>(pokeDexRegion);
            Count = Pokedex.Entries.Length;
        }

        public static async Task GetPokemons()
        {
            await GetPokedexEntries(2);
            
            pokemon = new List<Pokemon>();

            for (int i = 1; i <= Count; i++)
            {
                var p = await DataFetcher.GetApiObject<Pokemon>(i);
                pokemon.Add(p);
            }
        }

        public static async Task<GiphyDotNet.Model.Results.GiphyRandomResult> SearchGifs(string gif)
        {
            Giphy g = new Giphy("g1HLl7dQfMsO8Vd9k4RmbFx8l9hN7aQz");
            RandomParameter rp = new RandomParameter();
            rp.Tag = gif;

            return g.RandomGif(rp).Result;
        }

        public static string GetCommandName(int id)
        {
            foreach (var item in Commands)
            {
                if(item.ID == id)
                {
                    return item.CommandName;
                }
            }
            return null;
        }

        public static void LoadLists()
        {
            Task.Run(() => GetPokemons());

            Helper.Commands = new List<Commands>();

            Helper.Commands.Add(new Commands()
            {
                ID = 1,
                CommandName = "hallo",
                AliasName = new string[] { "hi" },
                Information = "Mit dem Command hallo oder hi werden Sie mit einem Gif begrüßt, um einen User zu begrüßen, @Mention nutzen\nBeispiel: !hallo !hi oder !hi @Name_des_Users",
                ErrorMessage = ""
            });
            Helper.Commands.Add(new Commands()
            {
                ID = 1,
                CommandName = "gif",
                AliasName = new string[] { "g" },
                Information = "Mit dem Command gif parameter oder g parameter wird ein Gif passend zum Parameter gepostet.\nBeispiel: !gif hallo !g drachen",
                ErrorMessage = ""
            });
            Helper.Commands.Add(new Commands()
            {
                ID = 1,
                CommandName = "pokemon",
                AliasName = new string[] { "poke" },
                Information = "Mit dem Command pokemon id oder pokemon name wird erscheint ein Eintrag des Pokedexs, Kanto Region 1-151 Pokemon.\nBeispiel: !pokemon 12 !poke pikachu",
                ErrorMessage = "Pokemon Name oder Id Incorrect, ID von 1-151, Kanto Region"
            });
            Helper.Commands.Add(new Commands()
            {
                ID = 1,
                CommandName = "profil",
                AliasName = new string[] { "profile" },
                Information = "Mit dem Command profil oder profile erstellt man eine Embed mit Foto und Informationen, wichtig, Bild als Foto anhängen" +
                              "\nBeispiel: Folgt...",
                ErrorMessage = ""
            });
            Helper.Commands.Add(new Commands()
            {
                ID = 1,
                CommandName = "purge",
                Information = "Mit dem Command purge löscht man den Chat in dem Chat man den Befehl eingibt" +
                              "\nBeispiel: !purge 100 um 100 Nachrichten zu löschen purge Stop kommt noch.",
                ErrorMessage = "Bitte eine Ganzzahl als Parameter angeben"
            });
        }
    }
}
