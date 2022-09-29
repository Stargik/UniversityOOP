using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class Worker
    {
        public string Name { get; }
        public string Position { get; set; }
        public StringBuilder WorkDay { get; }
        protected Worker(string name)
        {
            Name = name;
            WorkDay = new StringBuilder();
        }
        public void Call()
        {
            WorkDay.Append("Make call; ");
        }
        public void WriteCode()
        {
            WorkDay.Append("Write code; ");
        }
        public void Relax()
        {
            WorkDay.Append("Relax; ");
        }
        public abstract void FillWorkDay();

    }
}
