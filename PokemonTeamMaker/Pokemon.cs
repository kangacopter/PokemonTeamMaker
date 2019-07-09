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
            Height = String.IsNullOrEmpty(data[26]) ? 0.0 : Convert.ToDouble(data[26]);
            HP = Convert.ToInt32(data[27]);
            Name = Convert.ToString(data[29]);
            PercentMale = String.IsNullOrEmpty(data[30]) ? 0.0 : Convert.ToDouble(data[30]);
            PokedexNumber = Convert.ToInt32(data[31]);
            SpAttack = Convert.ToInt32(data[32]);
            SpDefense = Convert.ToInt32(data[33]);
            Speed = Convert.ToInt32(data[34]);
            Type1 = Convert.ToString(data[35]);
            Type2 = String.IsNullOrEmpty(data[36]) ? "None" : Convert.ToString(data[36]);
            Weight = String.IsNullOrEmpty(data[37]) ? 0.0 : Convert.ToDouble(data[37]);
            Generation = Convert.ToInt32(data[38]);
            IsLegendary = data[39].Equals("1") ? true : false; // Convert to boolean

        }

        // public Pokemon getPokemon(int number) {} (do one that searches int.. overloading?)
        // public Pokemon getPokemon(string name) {}

        // Here is the CSV top line and order of data:
        // [x] abilities
        // [0] against_bug
        // [1] against_dark
        // [2] against_dragon
        // [3] against_electric
        // [4] against_fairy
        // [5] against_fight
        // [6] against_fire
        // [7] against_flying
        // [8] against_ghost
        // [9] against_grass
        // [10] against_ground
        // [11] against_ice
        // [12] against_normal
        // [13] against_poison
        // [14] against_psychic
        // [15] against_rock
        // [16] against_steel
        // [17] against_water
        // [18] attack
        // [19] base_egg_steps
        // [20] base_happiness
        // [21] base_total
        // [22] capture_rate
        // [23] classfication
        // [24] defense
        // [25] experience_growth
        // [26] height_m
        // [27] hp
        // [28] japanese_name
        // [29] name ***
        // [30] percentage_male
        // [31] pokedex_number ***
        // [32] sp_attack
        // [33] sp_defense
        // [34] speed
        // [35] type1
        // [36] type2
        // [37] weight_kg
        // [38] generation
        // [39] is_legendary

    }
}
