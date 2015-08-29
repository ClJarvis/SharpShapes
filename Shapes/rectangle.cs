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

        

        public rectangle(float width, float length)
        {
            this.Top = width; //side1
            this.Right = length; //side2
            this.Left = length;
            this.Bottom = width;
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
