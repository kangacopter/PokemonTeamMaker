using System;
namespace PokemonTeamMaker
{
    public class PokedexEntry
    {
        public Pokemon CurrentPokemon { get; set; }

        // Formatting for the entry display?
        public PokedexEntry(Pokemon pokemon)
        {
            CurrentPokemon = pokemon;
        }

        public void Show()
        {
            Console.WriteLine("***********************************");
            Console.WriteLine(CurrentPokemon.Name);
            Console.WriteLine("***********************************");

        }
    }
}
