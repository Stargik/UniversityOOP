using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4_2
{
    internal interface IGeographyObject
    {
        double X { get; }
        double Y { get; }
        string Name { get; }
        string Description { get; }
        void GetInformation();

    }
}
