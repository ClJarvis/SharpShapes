using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class rectangle : Quadrilateral

    {
        
        public rectangle(float length, float height)
        {
            this.Side1 = length;
            this.Side2 = height;
        }
        public override float Area()
        {
            return (Side1 * Side2);
        }
    }
}
