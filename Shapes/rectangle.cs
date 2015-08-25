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
            this.Top = length; //side1
            this.Right = height; //side2
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
