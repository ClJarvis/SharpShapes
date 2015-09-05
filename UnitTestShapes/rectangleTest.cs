using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Shapes
{
    public class Rectangle : Quadrilateral

    {
        // private float top;



        public Rectangle(float width, float length) : base(width, width, length, length)
        {
            this.Top = width; //side1
            this.Right = length; //side2
            this.Left = length;
            this.Bottom = width;
        }

        /// <summary>
        ///Calculate Area for a Shape!
        /// </summary>
        /// <returns>Returns area as a flost</returns>
        public override float Area()
        {
            return (Top * Right); //Side1 * Side2
        }

        [TestMethod]
        public void TestCorrectNumberofArguments()
        {
            var theClass = Assembly.GetAssembly(typeof(Shapes.Shape)).GetTypes().Where(shapeType => shapeType.Name == "Rectangle").First(); // This is a Collection. Get the First
            var theClassConstructor = theClass.GetConstructors().First();
            Assert.AreEqual(2,theClassConstructor.GetParameters().Length);
        }
}
}
