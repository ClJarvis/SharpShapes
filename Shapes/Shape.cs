using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Shapes
{
    public abstract class Shape : IShape
    {
        // we need info about colors
       // protected Color fillColor;
       //protected Color borderColor;

            /// <summary>
            /// "protected Set" allows child classes to use the setter!
            /// </summary>
        public Color FillColor { get; /*protected  */set; }
        public Color BorderColor { get; /*protected */ set; }

        public abstract float Area();

        public abstract float Perimeter();
       
    }
}
