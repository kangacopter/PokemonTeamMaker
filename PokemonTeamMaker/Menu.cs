using System;
namespace PokemonTeamMaker
{
    public static class Menu
    {

        public static int Display()
        {
            //Console.Clear();
            Console.WriteLine();
            Console.WriteLine("Pokemon Team Maker: Main Menu");
            Console.WriteLine("******************");
            Console.WriteLine();
            Console.WriteLine(" 1. Pokedex");
            Console.WriteLine(" 2. Create/Edit Team");
            Console.WriteLine(" 3. View Teams");
            Console.WriteLine(" Press 'q' to exit.");
            Console.WriteLine();
            Console.WriteLine(" Selection >>>>");
            var selection = Console.ReadLine();

            if (int.TryParse(selection, out int parsedVal))
            {
                return parsedVal;
            }
            else if (selection == "q" || selection == "Q")
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
                            input = -1;
                            var pokedex = new Pokedex();
                            PokedexMenu.Run();
                            //pokedex.GetPokedex();
                            //Console.WriteLine("Show pokedex");
                            //System.Threading.Thread.Sleep(1000);
                            break;
                        case 2:
                            input = -1;
                            TeamMenu.Run();
                            System.Threading.Thread.Sleep(1000);
                            break;
                        case 3:
                            Console.WriteLine("View Teams");
                            System.Threading.Thread.Sleep(1000);
                            break;
                        case -1:
                            Console.Clear();
                            Console.WriteLine("See ya later... gotta catch 'em all!");
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
            while (input != -1);
        }
    }
}