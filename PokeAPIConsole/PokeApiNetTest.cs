using PokeApiNet;

namespace PokeAPIConsole
{
    public class PokeApiNetTest
    {
        static List<Pokemon> pokemonList;

        public static async Task Start()
        {
            await GetPokemonAsync();
        }

        private static async Task GetPokemonAsync()
        {
            pokemonList = new List<Pokemon>();
            PokeApiClient client = new PokeApiClient();

            for (int i = 1; i <= 151; i++)
            {
                pokemonList.Add(await client.GetResourceAsync<Pokemon>(i));
            }
        }
    }
}
