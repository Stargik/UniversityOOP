using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4_2
{
    internal class Mountain : IGeographyObject
    {
        public double X { get; }
        public double Y { get; }
        public string Name { get; }
        public string Description { get; }
        public double HighestPoint { get; }
        public Mountain(double x, double y, string name, string description, double highestPoint)
        {
            this.X = x;
            this.Y = y;
            this.Name = name;
            this.Description = description;
            this.HighestPoint = highestPoint;
        }

        public void GetInformation()
        {
            Console.WriteLine($"X: {X}; Y: {Y}; Name: {Name}; Description: {Description}; Highest point: {HighestPoint}");
        }
    }
}
