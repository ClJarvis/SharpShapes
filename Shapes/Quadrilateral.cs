using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Shapes
{
    public  class Quadrilateral : Shape //added abstract
    {
        private float top;
        private float bottom;
        private float left;
        private float right;
        public float Top
        {
            get { return top; }
            set
            {
                if (value <= 0.0)
                {
                    throw new ArgumentException();
                }
                else
                {
                    top = value;
                }
            }
        }
        public float Bottom
        {
            get { return bottom; }
            set
            {
                if (value <= 0.0)
                {
                    throw new ArgumentException();
                }
                else
                {
                    bottom = value;
                }
            }
        }
        public float Left
        {
            get { return left; }
            set
            {
                if (value <= 0.0)
                {
                    throw new ArgumentException();
                }
                else
                {
                    left = value;
                }
            }

        }
        public float Right
        {
            get { return right; }
            set
            {
                if (value <= 0.0)
                {
                    throw new ArgumentException();
                }
                else
                {
                    right = value;
                }
            }
        }

        // Calls Shape's Constructor that provides default fill and border colors.
        public Quadrilateral() : base() { }

        public Quadrilateral(float top, float bottom, float left, float right) : base()
        {
            this.Top = top;
            this.Bottom = bottom;
            this.Left = left;
            this.Right = right;
        }

        //public abstract override float Area();

        public override float Area() 
        {
            if (Top == 0.0 || Bottom == 0.0 || Left == 0.0 || Right == 0.0)
            {
                throw new ArgumentException();
            }
            else
            {
                return Top * Right;
            }
        }


        // Shape's Constructor is called BEFORE the supplied code block.
        public override float Perimeter()
        {
            if (Top == 0.0 || Bottom == 0.0 || Left == 0.0 || Right == 0.0)
            {
                throw new ArgumentException();
            }
            else
            {
                return Top + Bottom + Left + Right;
            }

        }

        public override void Scale(int percent)
        {
            if (percent == 0 || percent <= -100)
            {
                throw new ArgumentException();
            }
                this.Top = Top * (100  + percent) / 100;
                this.Bottom = Bottom * (100 + percent) / 100;
                this.Left = Left * (100 + percent) / 100;
                this.Right = Right * (100 + percent) / 100;
        }

        public override void DrawOnTo(Canvas theCanvas, int x, int y)
        {
            base.DrawOnTo(theCanvas, x, y);
        }
    }
}
