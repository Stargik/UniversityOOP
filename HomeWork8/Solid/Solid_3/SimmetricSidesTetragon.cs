using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_3
{
    internal abstract class SimmetricSidesTetragon
    {
        public virtual int Width { get; set; }
        public virtual int Height { get; set; }
        public int GetArea()
        {
            return Width * Height;
        }
    }
}
