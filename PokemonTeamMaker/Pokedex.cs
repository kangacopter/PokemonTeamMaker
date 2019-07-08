using System;
using System.IO;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace PokemonTeamMaker
{
    public class Pokedex
    {
        private readonly string fileContents;
        private readonly Dictionary<int, Pokemon> Entries;

        public Pokedex()
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            DirectoryInfo dir = new DirectoryInfo(currentDirectory);
            var fileName = Path.Combine(dir.FullName, "pokemon.csv");
            //fileContents = ReadFile(fileName);

            // Parse the CSV file
            using (StreamReader reader = new StreamReader(fileName))
            {
                string line;
                char[] delimiters = { ',' }; // Delimit the rest of data
                char[] bracketDelimiters = { '[', ']' }; // Delimit ability

                string headline = reader.ReadLine(); // Remove header row
                while ((line = reader.ReadLine()) != null)
                {

                    List<string> abilities = new List<string>();
                    var matches = Regex.Matches(line, @"([''])(?:(?=(\\?))\2.)*?\1");
                    // Get the ability array separately
                    foreach (Match match in matches)
                    {
                        abilities.Add(match.ToString());
                    }

                    var bracketDelimit = line.Split(bracketDelimiters);

                    // Then split everything else by delimiter
                    string[] pokemonData = bracketDelimit[2].Split(delimiters);


                    Console.WriteLine();
                    Console.WriteLine("****************************");
                }

            }

        }

        public static string ReadFile(string fileName)
        {
            using (var reader = new StreamReader(fileName))
            {
                return reader.ReadToEnd();
            }
        }

        // Build a dictionary with CSV data
        // Key is going to be pokedex_number, value is Pokemon
        public void BuildPokedex(string fileContents)
        {
            // Go through fileContents and build pokemon
        }

        // This will write Pokedex entires to console
        // Might be able to make this return sections of it, or have paging...
        public void GetPokedex()
        {
            Console.WriteLine(Entries);
        }
        // public Pokemon getPokemonByType(string type) {}

        // Read CSV line by line and build a Pokemon
        // Maybe use arrays, first one is base array with header?
        // Each line after will build a Pokemon and add it to the dictionary
        // with the pokedex_number as the key

    }
}
