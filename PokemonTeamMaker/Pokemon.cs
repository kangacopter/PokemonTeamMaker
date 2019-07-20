using System;
using System.Collections.Generic;

namespace PokemonTeamMaker
{
    public class Pokemon
    {
        // Abilities
        public List<string> Abilities { get; set; }

        // Type weakness
        public double AgainstBug { get; set; }
        public double AgainstDark { get; set; }
        public double AgainstDragon { get; set; }
        public double AgainstElectric { get; set; }
        public double AgainstFairy { get; set; }
        public double AgainstFight { get; set; }
        public double AgainstFire { get; set; }
        public double AgainstFlying { get; set; }
        public double AgainstGhost { get; set; }
        public double AgainstGrass { get; set; }
        public double AgainstGround { get; set; }
        public double AgainstIce { get; set; }
        public double AgainstNormal { get; set; }
        public double AgainstPoison { get; set; }
        public double AgainstPsychic { get; set; }
        public double AgainstRock { get; set; }
        public double AgainstSteel { get; set; }
        public double AgainstWater { get; set; }

        // Battle stats
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int SpAttack { get; set; }
        public int SpDefense { get; set; }
        public int Speed { get; set; }
        public int HP { get; set; }

        // Misc stats
        public int BaseEggSteps { get; set; }
        public int BaseHappiness { get; set; }
        public int CaptureRate { get; set; }

        // Basic attributes 
        public string Name { get; set; }
        public int PokedexNumber { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        public int Generation { get; set; }
        public double PercentMale { get; set; }
        public string Type1 { get; set; }
        public string Type2 { get; set; }
        public bool IsLegendary { get; set; }

        // Intialize/populate Pokemon data
        public Pokemon(List<string> abilities, List<string> data)
        {
            Abilities = abilities;
            AgainstBug = Convert.ToDouble(data[0]);
            AgainstDark = Convert.ToDouble(data[1]);
            AgainstDragon = Convert.ToDouble(data[2]);
            AgainstElectric = Convert.ToDouble(data[3]);
            AgainstFairy = Convert.ToDouble(data[4]);
            AgainstFight = Convert.ToDouble(data[5]);
            AgainstFire = Convert.ToDouble(data[6]);
            AgainstFlying = Convert.ToDouble(data[7]);
            AgainstGhost = Convert.ToDouble(data[8]);
            AgainstGrass = Convert.ToDouble(data[9]);
            AgainstGround = Convert.ToDouble(data[10]);
            AgainstIce = Convert.ToDouble(data[11]);
            AgainstNormal = Convert.ToDouble(data[12]);
            AgainstPoison = Convert.ToDouble(data[13]);
            AgainstPsychic = Convert.ToDouble(data[14]);
            AgainstRock = Convert.ToDouble(data[15]);
            AgainstSteel = Convert.ToDouble(data[16]);
            AgainstWater = Convert.ToDouble(data[17]);
            Attack = Convert.ToInt32(data[18]);
            BaseEggSteps = Convert.ToInt32(data[19]);
            BaseHappiness = Convert.ToInt32(data[20]);
            CaptureRate = Convert.ToInt32(data[22]);
            Defense = Convert.ToInt32(data[24]);
            Attack = Convert.ToInt32(data[18]);
            Height = string.IsNullOrEmpty(data[26]) ? 0.0 : Convert.ToDouble(data[26]);
            HP = Convert.ToInt32(data[27]);
            Name = Convert.ToString(data[29]);
            PercentMale = string.IsNullOrEmpty(data[30]) ? 0.0 : Convert.ToDouble(data[30]);
            PokedexNumber = Convert.ToInt32(data[31]);
            SpAttack = Convert.ToInt32(data[32]);
            SpDefense = Convert.ToInt32(data[33]);
            Speed = Convert.ToInt32(data[34]);
            Type1 = Convert.ToString(data[35]);
            Type2 = string.IsNullOrEmpty(data[36]) ? "None" : Convert.ToString(data[36]);
            Weight = string.IsNullOrEmpty(data[37]) ? 0.0 : Convert.ToDouble(data[37]);
            Generation = Convert.ToInt32(data[38]);
            IsLegendary = data[39].Equals("1"); // Convert to boolean

        }

        public void PokedexEntry()
        {
            Console.WriteLine(String.Format("{0} {1,15} {2,-8} {3,-9}", "Dex No. " + PokedexNumber + ": " + Name + " (Gen " + Generation +")", "[" + Type1 + "]", (Type2 == "None" ? null : "[" + Type2 + "]"), (IsLegendary ? "Legendary" : "Non-Legendary")));
            Console.WriteLine("----------------------------------------------------------------------");
            Console.Write("Abilities: ");
            foreach (string ability in Abilities)
            {
                Console.Write("[" + ability + "] ");
            }
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------------------------");

            Console.WriteLine();
            Console.WriteLine(String.Format("\t   {0,15} | {1,15} | {2,10}", "Attack: " + Attack, "Defense: " + Defense, "HP: " + HP));
            Console.WriteLine(String.Format("\t   {0,15} | {1,15} | {2,10}", "SpAttack: " + SpAttack, "SpDefense: " + SpDefense, "Speed: " + Speed));
            Console.WriteLine(String.Format("\t   {0,15} | {1,15} | {2,10}", "Height: " + Height + "m", "Weight: " + Weight + "kg", PercentMale + "% Male"));
            Console.WriteLine(String.Format("\t   {0,15} | {1,15} | {2,10}", "Capture %: " + CaptureRate, "Egg Steps: " + BaseEggSteps, "Happiness: " + BaseHappiness));
        
            Console.WriteLine("\n\t\t\t     Immunities: ");
            // Less than 1, then it is a strength
            Console.WriteLine(" -----------------------------------------------------------------------");
            Console.WriteLine(String.Format("| {0,5} | {1,5} | {2,5} | {3,5} | {4,5} | {5,5} | {6,5} | {7,5} | {8,5} |",
                "bug ", "dark", "dragn", "elec", "fairy", "fight", "fire", "fly", "ghost"
                ));

Console.WriteLine(String.Format("| {0,5} | {1,5} | {2,5} | {3,5} | {4,5} | {5,5} | {6,5} | {7,5} | {8,5} |",
                AgainstBug < 1 ? "x  " : "", AgainstDark < 1 ? "x  " : "", AgainstDragon < 1 ? "x  " : "", AgainstElectric < 1 ? "x  " : "", AgainstFairy < 1 ? "x  " : "", AgainstFight < 1 ? "x  " : "", AgainstFire < 1 ? "x  " : "", AgainstFlying < 1 ? "x  " : "", AgainstGhost < 1 ? "x  " : ""
                ));
            Console.WriteLine(String.Format("| {0,5} | {1,5} | {2,5} | {3,5} | {4,5} | {5,5} | {6,5} | {7,5} | {8,5} |",
    "grass", "grnd", "ice ", "norml", "poisn", "psych", "rock", "steel", "water"
    ));
            Console.Write(String.Format("| {0,5} | {1,5} | {2,5} | {3,5} | {4,5} | {5,5} | {6,5} | {7,5} | {8,5} |",
    AgainstGrass < 1 ? "x  " : "", AgainstGround < 1 ? "x  " : "", AgainstIce < 1 ? "x  " : "", AgainstNormal < 1 ? "x  " : "", AgainstPoison < 1 ? "x  " : "", AgainstPsychic < 1 ? "x  " : "", AgainstRock < 1 ? "x  " : "", AgainstSteel < 1 ? "x  " : "", AgainstWater < 1 ? "x  " : ""
    ));
            Console.WriteLine("\n -----------------------------------------------------------------------");

            Console.WriteLine("\n\t\t\t     Weaknesses: ");
            // More than 1, then it is a weakness

            Console.WriteLine(" -----------------------------------------------------------------------");
            Console.WriteLine(String.Format("| {0,5} | {1,5} | {2,5} | {3,5} | {4,5} | {5,5} | {6,5} | {7,5} | {8,5} |",
                "bug ", "dark", "dragn", "elec", "fairy", "fight", "fire", "fly", "ghost"
                ));

            Console.WriteLine(String.Format("| {0,5} | {1,5} | {2,5} | {3,5} | {4,5} | {5,5} | {6,5} | {7,5} | {8,5} |",
                            AgainstBug > 1 ? "x  " : "", AgainstDark > 1 ? "x  " : "", AgainstDragon > 1 ? "x  " : "", AgainstElectric > 1 ? "x  " : "", AgainstFairy > 1 ? "x  " : "", AgainstFight > 1 ? "x  " : "", AgainstFire > 1 ? "x  " : "", AgainstFlying > 1 ? "x  " : "", AgainstGhost > 1 ? "x  " : ""
                            ));
            Console.WriteLine(String.Format("| {0,5} | {1,5} | {2,5} | {3,5} | {4,5} | {5,5} | {6,5} | {7,5} | {8,5} |",
    "grass", "grnd", "ice ", "norml", "poisn", "psych", "rock", "steel", "water"
    ));
            Console.Write(String.Format("| {0,5} | {1,5} | {2,5} | {3,5} | {4,5} | {5,5} | {6,5} | {7,5} | {8,5} |",
    AgainstGrass > 1 ? "x  " : "", AgainstGround > 1 ? "x  " : "", AgainstIce > 1 ? "x  " : "", AgainstNormal > 1 ? "x  " : "", AgainstPoison > 1 ? "x  " : "", AgainstPsychic > 1 ? "x  " : "", AgainstRock > 1 ? "x  " : "", AgainstSteel > 1 ? "x  " : "", AgainstWater > 1 ? "x  " : ""
    ));
            Console.WriteLine("\n -----------------------------------------------------------------------");


        }



        // Format Pokemon object output
        public override string ToString()
        {

            return "Dex No. " + PokedexNumber + ": " + Name + " [" + Type1 + "]";

        }
    }
}
