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
        private readonly StringBuilder workDay;
        public string WorkDay => workDay.ToString();
        protected Worker(string name)
        {
            Name = name;
            workDay = new StringBuilder();
            Position = "Worker";
        }

        private void SetWorkActivity(string activity)
        {
            workDay.Append(activity + "; ");
        }
        public void Call()
        {
            SetWorkActivity("Make call");
        }
        public void WriteCode()
        {
            SetWorkActivity("Write code");
        }
        public void Relax()
        {
            SetWorkActivity("Relax");
        }
        public abstract void FillWorkDay();

    }
}
