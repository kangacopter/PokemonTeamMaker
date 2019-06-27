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
        public bool IsLegendary { get; set; } // I'd like to take the 0/1

        public Pokemon()
        {
        }
    }
}
