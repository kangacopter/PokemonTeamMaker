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

        // Saves team to csv file (append)
         public void SaveTeam(Team team) {

            // Get current directory and set the default file name
            string currentDirectory = Directory.GetCurrentDirectory();
            DirectoryInfo dir = new DirectoryInfo(currentDirectory);
            var fileName = Path.Combine(dir.FullName, $"team_{team.Name}.csv");
      

            //List<string> lines = new List<string>();
            //lines.Add(string.Join(delimiter, columns.Select(c => c.ColumnName)));
            //lines.AddRange(dataTable.Rows.Cast<DataRow>().Select(row => string.Join(delimiter, columns.Select(c => row[c]))));
            //File.WriteAllLines(filePath, lines);
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
