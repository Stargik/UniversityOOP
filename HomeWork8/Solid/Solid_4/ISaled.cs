using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_4
{
    internal interface ISaled
    {
        void ApplyDiscount(String discount);
        void ApplyPromocode(String promocode);
    }
}
