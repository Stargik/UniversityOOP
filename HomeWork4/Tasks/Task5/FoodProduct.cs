using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class FoodProduct : Product
    {
        public DateTime ExpirationDate { get; }
        public int Quantity { get; }
        public string MeasureUnit { get; }
        public FoodProduct(string name, string description, decimal price, string country, DateTime packageDate, DateTime expirationDate, int quantity, string measureUnit)
            : base(name, description, price, country, packageDate)
        {
            ExpirationDate = expirationDate;
            Quantity = quantity;
            MeasureUnit = measureUnit;
        }
    }
}
