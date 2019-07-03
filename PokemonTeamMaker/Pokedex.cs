using System;
using System.IO;
using System.Collections.Generic;

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
            using (StreamReader reader = new StreamReader(fileName))
            {
                string line;
                //char[] ability_delimiter = new char[] { '"', '[', ']' };
                char[] delimiters = new char[] { ',' };

                // Need to get the first row as the properties? 
                // Maybe not...
                // Go through and assign to each property in pokemon class
                // Also deal with the first ability item which is in a weird format
                // if "[ ]"

                while ((line = reader.ReadLine()) != null)
                {
                    // Get the ability array separately

                    // Then split everything else by delimiter
                    string[] pokemon = line.Split(delimiters);
                    //Console.WriteLine(line + " END LINE");
                    foreach (string i in pokemon)
                    {
                        Console.Write(i + " ");

                    }
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
