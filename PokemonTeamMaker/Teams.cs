using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace PokemonTeamMaker
{
    public class Teams
    {
        private Dictionary<int, Team> List { get; set; }

        public Teams()
        {
            // Load from user's My Documents
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var filePath = Path.Combine(path, $"myPokemonTeams.csv");
            // What if this doesn't exist?
            Dictionary<int, Team> teams = new Dictionary<int, Team>();

            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {

                    var teamData = line.Trim().Split(',');
                    string teamName = teamData[1];
                    List<Pokemon> teamPokemon = new List<Pokemon>();
                    var subPokemon = teamData.Skip(1);
                    var count = 1;
                    foreach (string x in subPokemon)
                    {
                        if (!string.IsNullOrEmpty(x))
                        {
                            Pokedex pokedex = new Pokedex();
                            Pokemon thisPokemon = pokedex.GetPokemonByName(x);
                            teamPokemon.Add(thisPokemon);
                        }
                    }

                    teams.Add(count, new Team(teamName, 6, teamPokemon));
                    count++;
                }

            }

            List = teams;
        }

        public void Show()
        {
            foreach(var team in List)
            {
                //Console.WriteLine(team.Key);
                Console.WriteLine(team.Key + " " + team.Value + "\n");
            }
        }
    }
}
