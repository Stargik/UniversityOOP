namespace ConsoleApp1
{
    public class Program
    {
        static List<Team> teams = new List<Team>();
        static void Main(string[] args)
        {
            bool exFlag = true;
            while (exFlag)
            {
                Console.WriteLine("Choose a command:");
                Console.WriteLine("1 - add a team");
                Console.WriteLine("2 - show all teams");
                Console.WriteLine("3 - Fiish");
                string? command = Console.ReadLine();
                int commandNumber;
                if (int.TryParse(command, out commandNumber))
                {
                    switch (commandNumber)
                    {
                        case 1:
                            AddTeam();
                            break;
                        case 2:
                            ShowCommands();
                            break;
                        case 3:
                            exFlag = false;
                            break;
                        default:
                            Console.WriteLine("Incorrect input. Try again");
                            break;
                    }
                }
            }
        }

        private static void ShowCommands()
        {
            if (teams.Count == 0)
            {
                Console.WriteLine("We don't have any team.");
            }
            else
            {
                Console.WriteLine("1 - show base info");
                Console.WriteLine("2 - show info with details");
                string? command = Console.ReadLine();
                int commandNumber;
                if (int.TryParse(command, out commandNumber))
                {
                    switch (commandNumber)
                    {
                        case 1:
                            foreach (var team in teams)
                            {
                                team.ShowTeamMembers();
                                Console.WriteLine(new String('-', 20));
                            }
                            break;
                        case 2:
                            foreach (var team in teams)
                            {
                                team.ShowTeamMembersWithDetails();
                                Console.WriteLine(new String('-', 20));
                            }
                            break;
                        default:
                            Console.WriteLine("Incorrect input. Try again");
                            break;
                    }
                }
            }
        }

        private static void AddTeam()
        {
            Console.WriteLine("Write a name of the team: ");
            string? name = Console.ReadLine();
            if (!String.IsNullOrEmpty(name))
            {
                Team newTeam = new Team(name);
                bool flag = true;
                while (flag)
                {
                    Console.WriteLine("Do you want to add a new Worker? (1 - yes, 2 - no)");
                    string? command = Console.ReadLine();
                    int commandNumber;
                    if (int.TryParse(command, out commandNumber))
                    {
                        if (commandNumber == 2)
                        {
                            flag = false;
                        }
                        else if(commandNumber == 1)
                        {
                            Console.WriteLine("Write a name:");
                            string? workerName = Console.ReadLine();
                            Console.WriteLine("Write a position:");
                            string? position = Console.ReadLine();
                            if (!String.IsNullOrEmpty(workerName) && !String.IsNullOrEmpty(position))
                            {
                                newTeam.AddWorker(workerName, position);
                            }
                            else
                            {
                                Console.WriteLine("Incorrect input. Try again.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Incorrect input. Try again.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Incorrect input. Try again.");
                    }
                }
                teams.Add(newTeam);
            }
            else
            {
                Console.WriteLine("Incorrect input. Try again.");
            }

        }
    }
}