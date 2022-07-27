using PokeAPI;

namespace PokeAPIConsole
{
    public class PokeApiTest
    {

        static List<Pokemon> pokemons;
        public static void Start()
        {
            Console.WriteLine("Press a Key to all Kanto Pokemons");
            Console.ReadKey();
            GetPokemon();

            Console.ReadKey();
        }
        private static async Task GetPokemon()
        {
            pokemons = new List<Pokemon>();
            int entries = await GetPokedexEntries(2);

            Console.WriteLine("Entries: " + entries);
            for (int i = 1; i <= entries; i++)
            {
                Pokemon p = await DataFetcher.GetApiObject<Pokemon>(i);
                pokemons.Add(p);
                string type = string.Empty;
                foreach (var t in p.Types)
                {
                    type += t.Type.Name + " | ";
                }
                Console.WriteLine($" | ID: {p.ID} | Name: {p.Name} | Height: {p.Height} | Type: {type}");
            }
        }

        private static async Task<int> GetPokedexEntries(int pokeDexRegion)
        {
            Pokedex pokedex = await DataFetcher.GetApiObject<Pokedex>(pokeDexRegion);
            return pokedex.Entries.Length;
        }
    }
}
