namespace Pokemon_Blazor.Pages
{
    public partial class Index
    {
        public Index()
        {
            
        }

        public void Start()
        {
            PokemonDB.LoadPokemon();
        }
    }
}
