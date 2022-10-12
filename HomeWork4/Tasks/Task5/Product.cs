using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class Product
    {
        public string Name { get; }
        public string Description { get; }
        public decimal Price { get; }
        public string Country { get; }
        public DateTime PackageDate { get; }
        public Product(string name, string description, decimal price, string country, DateTime packageDate)
        {
            Name = name;
            Description = description;
            Price = price;
            Country = country;
            PackageDate = packageDate;
        }


    }
}
