using System;
namespace PokemonTeamMaker
{
    public static class TeamMenu
    {
        public static int Display(Team team)
        {
            Console.Clear();
            string pika = @"ϞϞ(๑⚈ ․̫ ⚈๑)∩";
            Console.WriteLine("\n" + pika + "\t\tTeam Manager");
            Console.WriteLine("******************************************\n");
            Console.WriteLine("Team Name: " + team.Name);
            // Shows current pokemon added to team
            Console.Write(team);
            Console.WriteLine("\n******************************************");
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
            return 0;

        }

        public static void Run()
        {
            int input = 0;
            // Initialize a new team
            Team team = new Team("New Team", 6);
            do
            {
                try
                {
                    input = Display(team);

                    switch (input)
                    {
                        case 1:
                            Console.Write("Enter pokemon name: ");
                            try {
                                string name = Console.ReadLine();
                                team.AddByName(name);
                            }
                            catch (ArgumentException)
                            {
                                Console.WriteLine("MissingNo. Pokemon Not Found");
                                System.Threading.Thread.Sleep(1000);
                            }

                            break;
                        case 2:
                            Console.Write("Enter slot to empty: ");
                            var slotInput = Console.ReadLine();
                            if (Int32.TryParse(slotInput, out int slot)) {
                                if (slot > 0 && slot <= team.Pokemon.Count)
                                {
                                    team.Remove(slot);
                                }
                                else { Console.WriteLine("There is no Pokemon in that slot number."); }
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
                            Console.WriteLine("Loading team...");
                            team.LoadTeam();
                            System.Threading.Thread.Sleep(2000);
                            break;
                        case 5:
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

