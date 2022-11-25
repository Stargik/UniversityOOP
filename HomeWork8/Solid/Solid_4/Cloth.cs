using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_4
{
    internal class Cloth : IItem, IColored, ISized, ISaled
    {
        public double Price { get; private set; }
        public double Color { get; private set; }
        public double Size { get; private set; }
        public void ApplyDiscount(string discount)
        {
            //calculate price with discount
        }

        public void ApplyPromocode(string promocode)
        {
            //calculate pricee with promocode
        }

        public void SetColor(byte color)
        {
            //set color
        }

        public void SetPrice(double price)
        {
            //set price
        }

        public void SetSize(byte size)
        {
            //set size
        }
    }
}
