using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Controls;

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

        //Comes from the Concreteshape class in ShapeTest.
        public Shape()
        {
            BorderColor = Color.NavajoWhite;
            FillColor = Color.PapayaWhip;
        }

        public virtual void DrawOnTo(Canvas theCanvas, int x, int y) { throw new NotImplementedException(); }
        public virtual void Scale(int percent) { throw new NotImplementedException(); }
        public virtual float Area() { throw new NotImplementedException(); }

        public virtual float Perimeter() {throw new NotImplementedException(); }
    }
       
    }

