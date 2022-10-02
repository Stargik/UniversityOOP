using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class Worker
    {
        public string Name { get; private set; }
        public string Position { get; set; }
        public StringBuilder WorkDay { get; private set; }
        protected Worker(string name)
        {
            Name = name;
            WorkDay = new StringBuilder();
            Position = "Worker";
        }

        private void SetWorkActivity(string activity)
        {
            WorkDay.Append(activity);
        }
        public void Call()
        {
            SetWorkActivity("Make call; ");
        }
        public void WriteCode()
        {
            SetWorkActivity("Write code; ");
        }
        public void Relax()
        {
            SetWorkActivity("Relax; ");
        }
        public abstract void FillWorkDay();

    }
}
