using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Team
    {
        private readonly List<Worker> workers;
        private readonly string Name;
        public Team(string name)
        {
            Name = name;
            workers = new List<Worker>();
        }
        public void AddWorker(string name, string position)
        {
            switch (position)
            {
                case "Розробник":
                    Worker developer = new Developer(name);
                    developer.FillWorkDay();
                    workers.Add(developer);
                    break;
                case "Менеджер":
                    Worker manager = new Manager(name);
                    manager.FillWorkDay();
                    workers.Add(manager);
                    break;
                default:
                    Console.WriteLine("Incorrect position");
                    break;
            }
        }
        public void ShowTeamMembers()
        {
            Console.WriteLine($"Команда '{Name}': ");
            foreach (Worker worker in workers)
            {
                Console.WriteLine($"{worker.Name}");
            }
        }
        public void ShowTeamMembersWithDetails()
        {
            Console.WriteLine($"Команда '{Name}': ");
            foreach (Worker worker in workers)
            {
                Console.WriteLine($"<{worker.Name}> - <{worker.Position}> - <{worker.WorkDay}>");
            }
        }
    }
}
