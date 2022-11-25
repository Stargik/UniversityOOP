using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_4
{
    internal class Book : IItem, ISaled
    {
        public double Price { get; private set; }
        public void ApplyDiscount(string discount)
        {
            //calculate price with discount
        }

        public void ApplyPromocode(string promocode)
        {
            //calculate pricee with promocode
        }

        public void SetPrice(double price)
        {
            //set price
        }
    }
}
