using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes;
using System.Drawing;

namespace UnitTestShapes
{
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
            omgMyShape.FillColor = Color.PapayaWhip;
            Assert.AreEqual(Color.PapayaWhip, omgMyShape.FillColor);
        }
        [TestMethod]
        public void TestingAbstractClassHasBorderColor()
        {
            omgMyShape.BorderColor = Color.NavajoWhite;
           // omgMyShape.BorderColor = Color.PapayaWhip;
            Assert.AreEqual(Color.NavajoWhite, omgMyShape.BorderColor);
        }
        
    }
}
