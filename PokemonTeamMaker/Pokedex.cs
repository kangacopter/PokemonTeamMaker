using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace PokemonTeamMaker
{
    public class Pokedex
    {
        private Dictionary<string, Pokemon> Entries { get; set; }

        public Pokedex()
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            DirectoryInfo dir = new DirectoryInfo(currentDirectory);
            var fileName = Path.Combine(dir.FullName, "pokemon.csv");
            // What if this doesn't exist?
            Dictionary<string, Pokemon> dex = new Dictionary<string, Pokemon>();

            // Parse the CSV file
            using (StreamReader reader = new StreamReader(fileName))
            {
                string line;
                char[] delimiters = { ',' }; // Delimit by comma
                char[] bracketDelimiters = { '[', ']' }; // Delimit abilities by bracket

                var headline = reader.ReadLine().Split(delimiters).ToList();
                // Generate header row, remove from rest of data.
                // TODO: Perhaps use this headline in the future

                while ((line = reader.ReadLine()) != null)
                {
                    var bracketDelimit = line.Trim().Split(bracketDelimiters);
                    var abilityDelimit = bracketDelimit[1].Trim().Split(delimiters);

                    List<string> abilities = new List<string>();
                    abilities.AddRange(abilityDelimit);

                    // Get the rest of the data that is NOT abilities
                    var pokemonData = bracketDelimit[2].Split(delimiters).ToList();
                    pokemonData.RemoveAt(0);

                    Pokemon pokemon = new Pokemon(abilities, pokemonData);

                    // Add to pokedex dictionary
                    dex.Add(pokemon.Name, pokemon);

                }
                Entries = dex;
            }

        }

        public static string ReadFile(string fileName)
        {
            using (var reader = new StreamReader(fileName))
            {
                return reader.ReadToEnd();
            }
        }


        // This will write Pokedex entires to console
        // Might be able to make this return sections of it, or have paging...
        public void GetPokedex()
        {
            foreach (var entry in Entries)
            {
                Console.WriteLine(entry.Value);
            }
        }

        // public Pokemon getPokemonByType(string type) {}

        public Pokemon GetPokemonByName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("Please enter a valid Pokemon name.");
            }
            name = name.First().ToString().ToUpper() + name.Substring(1);
            if (Entries.TryGetValue(name, out Pokemon result))
            {
                return result;
            }
            Console.WriteLine("MissingNo: Pokemon not found.");
            return null;


        }

    }
}
