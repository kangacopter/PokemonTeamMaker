using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace PokemonTeamMaker
{
    public class Team
    {
        public string Name { get; set; }
        public int Slots { get; set; }
        public List<Pokemon> Pokemon { get; set; }

        public Team(string name, int slots)
        {
            Name = name; // Set name of pokemon team
            Slots = slots; // Set number of slots a team can be
            Pokemon = new List<Pokemon>(); // Pokemon list
        }

        // Saves team to CSV file
        public void SaveTeam()
        {
            // Save to user's My Documents
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var filePath = Path.Combine(path, $"myPokemonTeam.csv");
         
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                sw.Write(Name + ",");
                foreach (Pokemon pokemon in Pokemon)
                {
                    sw.Write(pokemon.Name + ",");
                }
                sw.Write("\n");
                Console.WriteLine("Team saved to " + filePath);
            }

        }

        // Adds Pokemon to team by name
        public void AddByName(string name)
        {
            Pokedex pokedex = new Pokedex();
            Pokemon pokemonToAdd = pokedex.GetPokemonByName(name);
            if (pokemonToAdd != null && Pokemon.Count < Slots)
            {
                Pokemon.Add(pokemonToAdd);
            }
        }

        public void Remove(int slot)
        {
            // Remove from team by slot number
            Pokemon.RemoveAt(slot - 1);
        }

        // Gets and loads the team from the csv file 
        public Team LoadTeam()
        {
            // Load from user's system folder
            // Only one team can be saved and loaded... for now!
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var filePath = Path.Combine(path, $"myPokemonTeam.csv");

            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {

                        var teamData = line.Trim().Split(',');
                        string teamName = teamData[0];
                        List<Pokemon> teamPokemon = new List<Pokemon>();
                        var subPokemon = teamData.Skip(1);

                        foreach (string x in subPokemon)
                        {
                            if (!string.IsNullOrEmpty(x))
                            {
                                Pokedex pokedex = new Pokedex();
                                Pokemon thisPokemon = pokedex.GetPokemonByName(x);
                                teamPokemon.Add(thisPokemon);
                            }
                        }
                        Name = teamName;
                        Pokemon = teamPokemon;
                    }
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Pokemon team file not found. Try making a new team and saving!");
            }
            return this;
        }

        // Allows editing of team
        public void EditTeamName(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            if (Pokemon.Count > 0)
            {
                string teamString = "";
                int count = 1;
                foreach (Pokemon poke in Pokemon)
                {
                    teamString += "[* Slot " + count + " *] " + poke.Name + "\n";
                    count++;
                }
                return teamString;
            }
            return "No pokemon in this team, yet.\n";
        }
    }
}
