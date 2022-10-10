using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Mountain : GeographyObject
    {
        private double highestPoint;
        public Mountain(double x, double y, string name, string description, double highestPoint) : base(x, y, name, description)
        {
            this.highestPoint = highestPoint;
        }

        public override void GetInformation()
        {
            base.GetInformation();
            Console.WriteLine($"Highest point: {highestPoint}");
        }
    }
}
