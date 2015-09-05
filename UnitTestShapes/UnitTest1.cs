using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes;
using System.Drawing;
using System.Windows.Media;

namespace UnitTestShapes
{ /// <summary>
/// /Alternate Version of abstract tets
/// </summary>
    [TestClass]
    public class AbstractShapeTests
    {
        private class MyMockShape : Shape
        {
         

            public override float Area()
            {
                throw new NotImplementedException();
            }

            public override float Perimeter()
            {
                throw new NotImplementedException();
            }
        }

        MyMockShape omgMyShape = new MyMockShape();

        [TestMethod]
        public void TestingAbstractClassHasFillColor()
        {
            omgMyShape.FillColor = Colors.PapayaWhip;
            Assert.AreEqual(Colors.PapayaWhip, omgMyShape.FillColor);
        }
        [TestMethod]
        public void TestingAbstractClassHasBorderColor()
        {
            omgMyShape.BorderColor = Colors.NavajoWhite;
           // omgMyShape.BorderColor = Color.PapayaWhip;
            Assert.AreEqual(Colors.NavajoWhite, omgMyShape.BorderColor);
        }
        
    }
}
