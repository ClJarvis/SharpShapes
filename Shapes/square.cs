using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class square : rectangle 
    {
        public square(float Top, float Right, float Left, float Bottom) : base(Top)
        {
            this.Top = Top; 
            this.Right = Right; 
            this.Left = Left;
            this.Bottom = Bottom;
        }
        public override float Area()
        {
            return Top * Right;
        }
    }
}
