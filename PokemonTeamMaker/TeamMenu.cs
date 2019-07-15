using System;
namespace PokemonTeamMaker
{
    public static class TeamMenu
    {
        public static int Display(Team team)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("Create Pokemon Team"); 
            Console.WriteLine("Current Team: " + team.Name);
            Console.WriteLine(team);
            // If new then New Team, or pull from loaded name
            // Make sure you only allow 6 pokemon per team...
            Console.WriteLine("******************");
            Console.WriteLine();
            Console.WriteLine(" 1. Add Pokemon");
            Console.WriteLine(" 2. Delete Pokemon");
            Console.WriteLine(" 3. Rename team");
            Console.WriteLine(" 4. Load team");
            Console.WriteLine(" 5. Save team");
            Console.WriteLine(" 6. Main Menu");
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

        // Deal with valid int input that is not on the menu!

        public static void Run()
        {
            int input = 0;
            // Initialize a new team
            Team team = new Team("New Team", 6);
            // Need to make sure the team does not exceed it's slot count
            do
            {
                try
                {
                    input = Display(team);

                    switch (input)
                    {
                        case 1:
                            Console.Write("Enter pokemon name: ");
                            string name = Console.ReadLine();
                            team.AddByName(name);
                            break;
                        case 2:
                            Console.Write("Enter slot to empty: ");
                            var slotInput = Console.ReadLine();
                            if (Int32.TryParse(slotInput, out int slot)) {
                                team.Remove(slot);
                            } else
                            {
                                Console.WriteLine("Invalid input: pick a slot number 1-6 to remove the Pokemon from.");
                            }
                            
                            System.Threading.Thread.Sleep(1000);
                            break;
                        case 3:
                            Console.Write("Enter new team name: ");
                            string newTeamName = Console.ReadLine();
                            team.EditTeamName(newTeamName);
                            System.Threading.Thread.Sleep(1000);
                            break;
                        case 4:
                            Console.WriteLine("Load team");
                            // Display a Pokemon type listing, choose, display list of pokemon
                            // This might be left for after project is submitted
                            team.LoadTeam(1);
                            System.Threading.Thread.Sleep(9000);
                            break;
                        case 5:
                            // Display a Pokemon type listing, choose, display list of pokemon
                            // This might be left for after project is submitted
                            team.SaveTeam();
                            System.Threading.Thread.Sleep(4000);
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

