using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes;

namespace UnitTestShapes
{
    [TestClass]
    public class UnitTest2 //QuadrilateralTests
    {
        public class MyFakeQuadilaterailTestClass : Quadrilateral
        {
            public override float Area()
            {
                throw new NotImplementedException();

            }
        }


        [TestMethod]
        public void TestQuadHasDefaultSize()
        {
           Quadrilateral myquad = new Quadrilateral();
            myquad.Perimeter();
        }

        [TestMethod]
        public void TestQuadrilateralCanComputePermimeter()
        {
            Quadrilateral myQuaddrilaterial = new MyFakeQuadilaterailTestClass();
            myQuaddrilaterial.top = 2;
            myQuaddrilaterial.right = 2;
            myQuaddrilaterial.left = 2;
            myQuaddrilaterial.bottom = 2;
            Assert.AreEqual(8, myQuaddrilaterial.Perimeter());
        }

        [TestMethod]
        public void TestQuadrilateralCanComputePermimeter2()
        {
            Quadrilateral myQuaddrilaterial = new MyFakeQuadilaterailTestClass();
            myQuaddrilaterial.top = 2;
            myQuaddrilaterial.right = 2;
            myQuaddrilaterial.left = 2;
            myQuaddrilaterial.bottom = 2;
            Assert.AreEqual(8, myQuadrilateral2.Perimeter());
        }

        [TestMethod]
        public void testQudaPermietreAreTheSame()
        {
            Quadrilateral myquad = new Quaddrilaterial(2, 2, 2, 2);
            Assert.AreEqual(8, myquad.Perimeter());
        }

        [TestMethod]
        public void retangletest()
        {
            rectangle rectangle = new rectangle(4, 5);
            Assert.AreEqual(20, rectangle.Area());
        }

        [TestMethod]
        public void myrectanglePermimeter()
        {
            rectangle rectangle = new rectangle(4, 5);
            Assert.AreEqual(18, rectangle.Perimeter());
        }

        [TestMethod]
        public void MySquare()
        {
            square square = new square(3);
            Assert.AreEqual(9, square.Area());
        }
    }
}
