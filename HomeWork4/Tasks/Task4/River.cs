using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class River : GeographyObject
    {
        private readonly double speed;
        private readonly double length;
        public River(double x, double y, string name, string description, double speed, double length) : base(x, y, name, description)
        {
            this.speed = speed > 0 ? speed : 0;
            this.length = length > 0 ? length : 0;
        }

        public override void GetInformation()
        {
            base.GetInformation();
            Console.WriteLine($"Speed: {speed}; Length: {length}");
        }
    }
}
