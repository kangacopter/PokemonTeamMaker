using System;
namespace PokemonTeamMaker
{
    public static class PokedexMenu
    {
        public static int Display()
        {
            Console.Clear();
            string pika = @"ϞϞ(๑⚈ ․̫ ⚈๑)∩";
            Console.WriteLine("\n" + pika + "\tPokedex");
            Console.WriteLine("***************************");
            Console.WriteLine();
            Console.WriteLine(" 1. View All Pokemon");
            Console.WriteLine(" 2. Search by name");
            Console.WriteLine(" 3. Search by type");
            Console.WriteLine(" 4. Main Menu");
            Console.WriteLine();
            Console.Write("Enter Selection >>>> ");
            var selection = Console.ReadLine();

            if (int.TryParse(selection, out int parsedVal))
            {
                return parsedVal;
            }
            return 0;
        }

        public static void Run()
        {
            int input = 0;
            Pokedex pokedex = new Pokedex();

            do
            {
                try
                {
                    input = Display();

                    switch (input)
                    {
                        case 1:
                            input = 4;
                            pokedex.GetPokedex();
                            System.Threading.Thread.Sleep(1000);
                            break;
                        case 2:
                            // Ask for name, return pokemon entry
                            Console.Write("Enter name: ");
                            try
                            {
                                string pokemonSearch = Console.ReadLine();
                                Pokemon result = pokedex.GetPokemonByName(pokemonSearch);
                                result.PokedexEntry();
                                Console.Write("Press Enter to go back...");
                                Console.ReadLine();
                                Console.Clear();
                            }
                            catch (ArgumentException)
                            {
                                Console.WriteLine("Please enter a valid Pokemon name.");
                                System.Threading.Thread.Sleep(2000);
                            }
                            break;
                        case 3:
                            // Display a Pokemon type listing, choose, display entires of pokemon
                            Console.WriteLine("Choose from one of these types: ");
                            pokedex.ShowTypeListing();
                            Console.Write("Enter Pokemon type: ");
                            try
                            {
                                string typeSearch = Console.ReadLine();
                                var typeResult = pokedex.GetPokemonByType(typeSearch);
                                foreach (Pokemon pkmn in typeResult)
                                {
                                    Console.WriteLine(pkmn);
                                }
                                Console.Write("Press Enter to go back...");
                                Console.ReadLine();
                                Console.Clear();
                            }
                            catch (ArgumentException)
                            {
                                Console.WriteLine("Enter a valid Pokemon type.");
                                System.Threading.Thread.Sleep(2000);
                            }
                            break;
                        case 4:
                            Console.Clear();
                            Menu.Run();
                            break;
                        default:
                            Console.WriteLine("Invalid choice");
                            System.Threading.Thread.Sleep(1000);
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine();
                    Console.WriteLine(" ERROR: " + e);
                }
            }
            while (input != 4);
        }
    }
}
