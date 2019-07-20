using System;
namespace PokemonTeamMaker
{
    public static class PokedexMenu
    {
        public static int Display()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("Pokedex");
            Console.WriteLine("******************");
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
            if (selection == "q" || selection == "Q")
            {
                return -1;
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
                            Console.Write("Enter name: ");
                            string pokemonSearch = Console.ReadLine();
                            Pokemon result = pokedex.GetPokemonByName(pokemonSearch);
                            Console.WriteLine(result);
                            // Ask for name, return pokemon entry
                            System.Threading.Thread.Sleep(9000);
                            break;
                        case 3:
                            Console.Write("Enter Pokemon type: ");
                            // Display a Pokemon type listing, choose, display list of pokemon
                            System.Threading.Thread.Sleep(1000);
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
