using PokeAPI;

namespace Pokemon_Blazor.Pages
{
    public class PokemonDB
    {
        public static List<Pokemon> pokemonList;
        public static async Task LoadPokemon()
        {
            pokemonList = new List<Pokemon>();
            int entries = await GetPokedexEntries(2);
            for (int i = 1; i < entries; i++)
            {
                Pokemon p = await DataFetcher.GetApiObject<Pokemon>(i);
                pokemonList.Add(p);
            }
        }

        private static async Task<int> GetPokedexEntries(int pokeDexRegion)
        {
            Pokedex pokedex = await DataFetcher.GetApiObject<Pokedex>(pokeDexRegion);
            return pokedex.Entries.Length;
        }
    }
}
