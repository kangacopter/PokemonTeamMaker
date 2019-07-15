using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;

namespace PokemonTeamMaker
{
    public class Team
    {
        public int Id { get; private set; }
        public string Name { get; set; }
        public int Slots { get; set; }
        public List<Pokemon> Pokemon { get; set; }

        public static int globalTeamsId;
        
        public Team(string name, int slots)
        {
            Name = name; // Set name of pokemon team
            Slots = slots; // Set number of slots a team can be
            Pokemon = new List<Pokemon>();
            // Probably need to make this an array that is limited to the slot count
            Id = Interlocked.Increment(ref globalTeamsId);
        }

        public Team(string name, int slots, int id, List<Pokemon> pokemon)
        {
            Name = name; // Set name of pokemon team
            Slots = slots; // Set number of slots a team can be
            Pokemon = pokemon; // Set loaded pokemon
            Id = id; // Set loaded id
        }

        // Saves team to csv file (append if exists)
        public void SaveTeam()
        {

            // Save to user's My Documents
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var filePath = Path.Combine(path, $"myPokemonTeams.csv");
            using (StreamWriter sw = new StreamWriter(filePath, true))
            {
                sw.Write(Id + "," + Name + ",");
                foreach (Pokemon pokemon in Pokemon)
                {
                    sw.Write(pokemon.Name + ",");
                }
                sw.Write("\n");
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
            Pokemon.RemoveAt(slot - 1);
        }

        // Gets and loads the team from the csv file 
        public void LoadTeam(int id)
        {
            // Load from user's My Documents
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var filePath = Path.Combine(path, $"myPokemonTeams.csv");
            // What if this doesn't exist?

            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {

                    var teamData = line.Trim().Split(',');
                    string teamName = teamData[1];
                    int teamId = Convert.ToInt32(teamData[0]);
                    List<Pokemon> teamPokemon = new List<Pokemon>();
                    var subPokemon = teamData.Skip(2);
                    foreach (string x in subPokemon)
                    {
                        Console.WriteLine(x);
                    }


                //    if (teamId == id)
                //    {
                //        return Team loadedTeam = new Team(teamName, 6, teamId, teamPokemon);

                //    } else { return null};
                }

            }

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
                    teamString += "Slot " + count + ": " + poke.Name + "\n";
                    count++;
                }
                return teamString;
            }

            return "No pokemon in this team, yet.";
        }
    }
}
