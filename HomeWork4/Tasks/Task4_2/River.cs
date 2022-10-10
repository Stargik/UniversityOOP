using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4_2
{
    internal class River : IGeographyObject
    {
        public double X { get; }
        public double Y { get; }
        public string Name { get; }
        public string Description { get; }
        public double Speed { get; }
        public double Length { get; }
        public River(double x, double y, string name, string description, double speed, double length)
        {
            this.X = x;
            this.Y = y;
            this.Name = name;
            this.Description = description;
            this.Speed = speed > 0 ? speed : 0;
            this.Length = length > 0 ? length : 0;
        }

        public void GetInformation()
        {
            Console.WriteLine($"X: {X}; Y: {Y}; Name: {Name}; Description: {Description}; Speed: {Speed}; Length: {Length}");
        }
    }
}
