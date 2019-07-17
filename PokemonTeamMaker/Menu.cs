using System;
namespace PokemonTeamMaker
{
    public static class Menu
    {
        // Show initial menu
        public static int Display()
        {
            string title = @"
 +-+ +-+ +-+ +-+ +-+ +-+ +-+   +-+ +-+ +-+ +-+ +-+ +-+ +-+
 |p| |o| |k| |e| |m| |o| |n|   |m| |a| |n| |a| |g| |e| |r|
 +-+ +-+ +-+ +-+ +-+ +-+ +-+   +-+ +-+ +-+ +-+ +-+ +-+ +-+
";
            string pika = @"ϞϞ(๑⚈ ․̫ ⚈๑)∩";

            Console.WriteLine(title);
            Console.WriteLine(pika + "\tMain Menu");
            Console.WriteLine("***************************");
            Console.WriteLine();
            Console.WriteLine(" 1. Pokedex");
            Console.WriteLine(" 2. Pokemon Team Manager\n");
            Console.WriteLine(" Press 'q' to exit.");
            Console.WriteLine();
            Console.Write("Enter Selection >>>> ");
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

        // Initial menu functions
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
                            break;
                        case 2:
                            input = -1;
                            TeamMenu.Run();
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