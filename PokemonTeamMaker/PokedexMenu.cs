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
            else return 0;

        }

        // Deal with valid int input that is not on the menu!

        public static void Run()
        {
            int input = 0;

            do
            {
                try
                {
                    input = Display();

                    switch (input)
                    {
                        case 1:
                            input = 4;
                            Pokedex pokedex = new Pokedex();
                            pokedex.GetPokedex();
                            System.Threading.Thread.Sleep(1000);
                            break;
                        case 2:
                            Console.Write("Enter name: ");
                            // Ask for name, search for name, return pokemon entry
                            System.Threading.Thread.Sleep(1000);
                            break;
                        case 3:
                            Console.Write("Enter Pokemon type: ");
                            // Display a Pokemon type listing, choose, display list of pokemon
                            // This might be left for after project is submitted
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
