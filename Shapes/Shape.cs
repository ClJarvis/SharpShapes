using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public abstract class Shape : IShape
    {
        // we need info about colors
        public float Area() { throw new NotImplementedException(); }
        public float Perimeter() { throw new NotImplementedException(); }
    }
}
