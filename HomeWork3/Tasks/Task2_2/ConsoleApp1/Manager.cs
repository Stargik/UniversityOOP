using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Manager : Worker
    {
        private readonly Random random;
        public Manager(string name) : base(name)
        {
            Position = "Менеджер";
            random = new Random();
        }

        public override void FillWorkDay()
        {
            for (int i = 0; i < random.Next(1, 10); i++)
            {
                Call();
            }
            Relax();
            for (int i = 0; i < random.Next(1, 5); i++)
            {
                Call();
            }
        }
    }
}
