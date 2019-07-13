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


        public Team(string name, int slots, List<Pokemon> pokemon)
        {
            Name = name; // Set name of pokemon team
            Slots = slots; // Set number of slots a team can be
            Pokemon = pokemon;
        }

        // Saves team to csv file (append if exists)
         public void SaveTeam() {

            // Save to user's My Documents
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var filePath = Path.Combine(path, $"myPokemonTeams.csv");
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                sw.Write(Name + ",");
            foreach (Pokemon pokemon in Pokemon)
                {
                    sw.Write(pokemon.Name);
                }
                Console.WriteLine("Team saved to " + filePath);

            }

        }

        // Gets and loads the team from the csv file 
        // public Team GetTeam() {}

        // Allows editing of team
         public void EditTeamName(string name) {
            Name = name;
}

        // Displays the team above the team menu?
         public void DisplayTeam(List<Pokemon> pokemon) {
            int count = 0;
            foreach(Pokemon poke in pokemon)
            {
                Console.WriteLine(count + ": " + pokemon);
            }
        }
    }
}
