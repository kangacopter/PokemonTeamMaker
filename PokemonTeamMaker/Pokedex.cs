using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace PokemonTeamMaker
{
    public class Pokedex
    {
        private Dictionary<string, Pokemon> Entries { get; set; }
        private HashSet<string> TypeListing { get; set; }

        public Pokedex()
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            DirectoryInfo dir = new DirectoryInfo(currentDirectory);
            var fileName = Path.Combine(dir.FullName, "pokemon.csv");

            Dictionary<string, Pokemon> dex = new Dictionary<string, Pokemon>();
            HashSet<string> types = new HashSet<string>();

            // Parse the CSV file
            using (StreamReader reader = new StreamReader(fileName))
            {
                string line;
                char[] delimiters = { ',' }; // Delimit by comma
                char[] bracketDelimiters = { '[', ']' }; // Delimit abilities by bracket

                var headline = reader.ReadLine().Split(delimiters).ToList();
                // Generate header row, remove from rest of data.

                while ((line = reader.ReadLine()) != null)
                {
                    var bracketDelimit = line.Trim().Split(bracketDelimiters);
                    var abilityDelimit = bracketDelimit[1].Trim().Split(delimiters);

                    List<string> abilities = new List<string>();
                    abilities.AddRange(abilityDelimit);

                    // Get the rest of the data that is NOT abilities
                    var pokemonData = bracketDelimit[2].Split(delimiters).ToList();
                    pokemonData.RemoveAt(0);

                    // Make Pokemon!
                    Pokemon pokemon = new Pokemon(abilities, pokemonData);

                    // Add type to the set
                    types.Add(pokemon.Type1);
                    types.Add(pokemon.Type2);

                    // Add to pokedex dictionary
                    dex.Add(pokemon.Name, pokemon);

                }
                Entries = dex;
                TypeListing = types;
            }

        }

        public static string ReadFile(string fileName)
        {
            using (var reader = new StreamReader(fileName))
            {
                return reader.ReadToEnd();
            }
        }


        // Write all Pokedex entires to console with paging
        public void GetPokedex()
        {
            int perPage = 1;
            int numberPages = Entries.Count() / perPage;
            var currentPage = 0;
            var currentEntries = Entries.Skip(currentPage).Take(perPage);
            string input;
            foreach (var entry in currentEntries)
            {
                Console.WriteLine("-~*~--~*~--~*~--~*~--~*~--~*~--~*~--~*~--~*~--~*~--~*~--~*~--~*~--~*~-\n");
                entry.Value.PokedexEntry();
            }

            do
            {
                Console.WriteLine("[ Current Page: " + (currentPage + 1) + "/" + (numberPages + 1) + " ] [ Z: Backward ] [ Enter: Forward ] [ Q: Exit ]");
                Console.Write("Enter Selection or Page Number >>> ");
                input = Console.ReadLine();
                Console.Clear();
                if (input == "")
                {
                    currentPage++;
                    currentEntries = Entries.Skip(currentPage * perPage).Take(perPage);
                }
                if (input.ToLower() == "z")
                {
                    currentPage = currentPage <= 0 ? 0 : currentPage - 1;
                    currentEntries = Entries.Skip(currentPage * perPage).Take(perPage);
                }
                if (int.TryParse(input, out int result))
                {
                    currentPage = result - 1;
                    currentEntries = Entries.Skip(currentPage * perPage).Take(perPage);
                }
                foreach (var entry in currentEntries)
                {
                    Console.WriteLine("-~*~--~*~--~*~--~*~--~*~--~*~--~*~--~*~--~*~--~*~--~*~--~*~--~*~--~*~-\n");
                    entry.Value.PokedexEntry();
                }

            }
            while (input != "q");

            PokedexMenu.Run();

        }

        public List<Pokemon> GetPokemonByType(string type) {
            // Check if empty/null string or invalid type
            if (string.IsNullOrEmpty(type) || !TypeListing.Contains(type))
            {
                throw new ArgumentException("Please enter a valid Pokemon type.");
            }
            type = type.ToLower();
            // Find Pokemon that have the type as Type1 or Type2
            var result = Entries.Where(pkmn => pkmn.Value.Type1 == type || pkmn.Value.Type2 == type);
            List<Pokemon> typePokemon = new List<Pokemon>();
            foreach (var p in result)
            {
                typePokemon.Add(p.Value);
            }
            return typePokemon;
        }

        public Pokemon GetPokemonByName(string name)
        {
            name = name.First().ToString().ToUpper() + name.Substring(1);
            if (Entries.TryGetValue(name, out Pokemon result))
            {
                return result;
            }
            throw new ArgumentException("MissingNo: Pokemon not found.");
        }

        public void ShowTypeListing()
        {
            foreach (string t in TypeListing)
            {
                Console.Write(" [" + t + "] ");
            }
            Console.WriteLine();
        }

    }
}
