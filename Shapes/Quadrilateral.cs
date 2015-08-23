using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public abstract class Quadrilateral : Shape
    {
        public float top { get; set; }
        public float right { get; set; }
        public float left { get; set; }
        public float bottom { get; set; }

        // Calls Shape's Constructor that provides default fill & border colors.
        public Quadrilateral  () : base() {}

        public abstract override float Area();

        public override float Perimeter(/*float top, float bottom, float left, float right*/)
        {
            return this.top + this.right + this.left + this.bottom;
        }

        public float Perimeter()
        {
            if (top == 0.0 || bottom == 0.0 || left == 0.0 || right == 0.0)
            {
                throw new ArgumentException()
            } else
            {

            }
        }
    }
}
