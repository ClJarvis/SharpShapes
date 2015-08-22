using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes;

namespace UnitTestShapes
{
    [TestClass]
    public class UnitTest2 //QuadrilateralTests
    {
        public class MyFakeQuadilaterailTestClass : Quaddrilaterial
        {
            public override float Area()
            {
                throw new NotImplementedException();

            }
        }

        [TestMethod]
        public void TestQuadrilateralCanComputePermimeter()
        {
            Quaddrilaterial myQuaddrilaterial = new MyFakeQuadilaterailTestClass();
            myQuaddrilaterial.Side1 = 2;
            myQuaddrilaterial.Side2 = 4;
            myQuaddrilaterial.Side3 = 99;
            myQuaddrilaterial.Side4 = 6;
            Assert.AreEqual(myQuaddrilaterial.Perimeter(), 111);
        }

        [TestMethod]
        public void retangletest()
        {
            rectangle rectangle = new rectangle();
            rectangle.Side1 = 4;
            rectangle.Side2 = 5;
            rectangle.Side3 = 4;
            rectangle.Side4 = 5;
            Assert.AreEqual(20, rectangle.Area());
        }

        [TestMethod]
        public void myrectanglePermimeter()
        {
            rectangle rectangle = new rectangle();
            rectangle.Side1 = 4;
            rectangle.Side2 = 5;
            rectangle.Side3 = 4;
            rectangle.Side4 = 5;
            Assert.AreEqual(18, rectangle.Perimeter());
        }

        [TestMethod]
        public void MySquare()
        {
            square square = new square();
            square.Side1 = 3;
            square.Side2 = 3;
            Assert.AreEqual(9, square.Area());
        }
    }
}
