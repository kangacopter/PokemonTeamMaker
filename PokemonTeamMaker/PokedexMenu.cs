using System;
namespace PokemonTeamMaker
{
    public static class PokedexMenu
    {
        public static int Display()
        {
            //Console.Clear();
            Console.WriteLine();
            Console.WriteLine("Pokedex");
            Console.WriteLine("******************");
            Console.WriteLine();
            Console.WriteLine(" 1. View Pokedex");
            Console.WriteLine(" 2. Search by name");
            Console.WriteLine(" 3. Search by number");
            Console.WriteLine(" 3. Search by type");
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
                            Console.WriteLine("Show entire pokedex");
                            // Pokedex should show a listing (giant table)
                            // User can enter in the name/number they want to see
                            System.Threading.Thread.Sleep(1000);
                            break;
                        case 2:
                            Console.WriteLine("Enter name: ");
                            System.Threading.Thread.Sleep(1000);
                            break;
                        case 3:
                            Console.WriteLine("Enter Pokedex number: ");
                            System.Threading.Thread.Sleep(1000);
                            break;
                        case 4:
                            Console.WriteLine("Enter Pokemon type: ");
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
