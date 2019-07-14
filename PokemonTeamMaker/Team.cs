using System;
using System.Collections.Generic;
using System.IO;

namespace PokemonTeamMaker
{
    public class Team
    {
        public string Name { get; set; }
        public int Slots { get; set; }
        public List<Pokemon> Pokemon { get; set; }
        public string[] Weaknesses { get; set; }
        // Maybe determine all the weaknesses in a set
        // This will probably have to be a function that iterates through the weakness (against < 1)
        // And adds to the string[]


        public Team(string name, int slots)
        {
            Name = name; // Set name of pokemon team
            Slots = slots; // Set number of slots a team can be
            Pokemon = new List<Pokemon>();
            // Probably need to make this an array that is limited to the slot count
        }

        // Saves team to csv file (append if exists)
        public void SaveTeam()
        {

            // Save to user's My Documents
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var filePath = Path.Combine(path, $"myPokemonTeams.csv");
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                sw.Write(Name + ",");
                foreach (Pokemon pokemon in Pokemon)
                {
                    sw.Write(pokemon.Name + ",");
                }
                Console.WriteLine("Team saved to " + filePath);

            }

        }

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
            // Remove by slot number
            Pokemon.RemoveAt(slot + 1);
        }

        // Gets and loads the team from the csv file 
        // public Team LoadTeam() {}

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
                    teamString += "Slot " + count + ": " + poke.Name + "\n";
                    count++;
                }
                return teamString;
            }

            return "No pokemon in this team, yet.";
        }
    }
}
