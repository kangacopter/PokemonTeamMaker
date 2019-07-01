using System;
namespace PokemonTeamMaker
{
    public class Pokemon
    {   
        // Abilities
        public string[] abilities;

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
        public bool IsLegendary { get; set; } // 0/1 === false/true

        public Pokemon()
        {
        }

        // public Pokemon getPokemon(int number) {} (do one that searches int.. overloading?)
        // public Pokemon getPokemon(string name) {}

        // Here is the CSV top line and order of data:
        // [0] abilities
        // [1] against_bug
        // [2] against_dark
        // [3] against_dragon
        // [4] against_electric
        // [5] against_fairy
        // [6] against_fight
        // [7] against_fire
        // [8] against_flying
        // [9] against_ghost
        // [10] against_grass
        // [11] against_ground
        // [12] against_ice
        // [13] against_normal
        // [14] against_poison
        // [15] against_psychic
        // [16] against_rock
        // [17] against_steel
        // [18] against_water
        // [19] attack
        // [20] base_egg_steps
        // [21] base_happiness
        // [22] base_total
        // [23] capture_rate
        // [24] classfication
        // [25] defense
        // [26] experience_growth
        // [27] height_m
        // [28] hp
        // [29] japanese_name
        // [30] name ***
        // [31] percentage_male
        // [32] pokedex_number ***
        // [33] sp_attack
        // [34] sp_defense
        // [35] speed
        // [36] type1
        // [37] type2
        // [38] weight_kg
        // [39] generation
        // [40] is_legendary

    }
}
