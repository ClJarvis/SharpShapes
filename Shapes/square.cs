using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class square : rectangle
    {
        public square(float side1) : base(side1, side1)
        {
            
        }
        public override float Area()
        {
            return (Top * Top);
        }
    }
}
