using System;
namespace PokemonTeamMaker
{
    public class Team
    {
        public string Name { get; set; }
        public int Slots { get; set; }
        public string[] Weaknesses { get; set; } 
        // Maybe determine all the weaknesses in a set
        // This will probably have to be a function that iterates through the weakness (against < 1)
        // And adds to the string[]

        // Maybe do stuff here for averages? AvgHp?

        public Team(string name, int slots)
        {
            Name = name; // Set name of pokemon team
            Slots = slots; // Set number of slots a team can be
        }
    }
}
