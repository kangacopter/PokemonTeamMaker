using System;
namespace PokemonTeamMaker
{
    public class Menu
    {
        public Menu()
        {

        }

        public static int Display()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("Pokemon Team Maker");
            Console.WriteLine("******************");
            Console.WriteLine();
            Console.WriteLine(" 1. View Pokedex");
            Console.WriteLine(" 2. Create Team");
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
                            Console.WriteLine("Show pokedex");
                            System.Threading.Thread.Sleep(1000);
                            break;
                        case 2:
                            Console.WriteLine("Create Team");
                            System.Threading.Thread.Sleep(1000);
                            break;
                        case 3:
                            Console.WriteLine("View Teams");
                            System.Threading.Thread.Sleep(1000);
                            break;
                        case -1:
                            Console.WriteLine("Exit");
                            System.Threading.Thread.Sleep(1000);
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