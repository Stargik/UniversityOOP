using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal abstract class GeographyObject
    {
        protected readonly double x;
        protected readonly double y;
        protected readonly string name;
        protected readonly string description;

        protected GeographyObject(double x, double y, string name, string description)
        {
            this.x = x;
            this.y = y;
            this.name = name;
            this.description = description;
        }
        
        public virtual void GetInformation()
        {
            Console.WriteLine($"X: {x}; Y: {y}; Name: {name}; Description: {description}");
        }
    }
}
