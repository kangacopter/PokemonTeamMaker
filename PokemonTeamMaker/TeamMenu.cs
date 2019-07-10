using System;
namespace PokemonTeamMaker
{
    public static class TeamMenu
    {
        public static int Display()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("Create Pokemon Team"); 

            // Initialize a new team
            Team team = new Team("New Team", 6, new System.Collections.Generic.List<Pokemon>());

            Console.WriteLine("Current Team: " + team.Name);
            // If new then New Team, or pull from loaded name
            // Make sure you only allow 6 pokemon per team...
            Console.WriteLine("******************");
            Console.WriteLine();
            Console.WriteLine(" 1. Add from Pokedex");
            Console.WriteLine(" 2. Add by name");
            Console.WriteLine(" 3. Add by number");
            Console.WriteLine(" 4. Load team");
            Console.WriteLine(" 5. Save team");
            Console.WriteLine(" 6. Main Menu");
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
                            Console.WriteLine("Add from pokedex");
                            // Pokedex should show a listing (giant table)
                            // User can enter in the name/number they want to see
                            System.Threading.Thread.Sleep(1000);
                            break;
                        case 2:
                            Console.WriteLine("Add by name");
                            // Ask for name, search for name, return pokemon entry
                            System.Threading.Thread.Sleep(1000);
                            break;
                        case 3:
                            Console.WriteLine("Add by dex number");
                            // Ask for number, search number, return pokemon entry
                            System.Threading.Thread.Sleep(1000);
                            break;
                        case 4:
                            Console.WriteLine("Load team");
                            // Display a Pokemon type listing, choose, display list of pokemon
                            // This might be left for after project is submitted
                            System.Threading.Thread.Sleep(1000);
                            break;
                        case 5:
                            Console.WriteLine("Save team");
                            // Display a Pokemon type listing, choose, display list of pokemon
                            // This might be left for after project is submitted
                            System.Threading.Thread.Sleep(1000);
                            break;
                        case 6:
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
            while (input != 6);
        }
    }

}

