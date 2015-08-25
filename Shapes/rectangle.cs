using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class rectangle : Quadrilateral

    {
        private float top;

        public rectangle(float top)
        {
            this.top = top;
        }

        public rectangle(float Top, float Right, float Left, float Bottom)
        {
            this.Top = Top; //side1
            this.Right = Right; //side2
            this.Left = Left;
            this.Bottom = Bottom;
        }
        public override float Area()
        {
            return (Top * Right); //Side1 * Side2
        }

     /*   public override float Perimeter()
        {
            throw new NotImplementedException();
        } */ ///intellsense suggestion for rectangle
    }  
}
