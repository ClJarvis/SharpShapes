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
            Quaddrilaterial myQuaddrilaterial = new Quaddrilaterial();
            myQuaddrilaterial.Side1 = 2;
            myQuaddrilaterial.Side2 = 4;
            myQuaddrilaterial.Side3 = 99;
            myQuaddrilaterial.Side4 = 6;
            Assert.AreEqual(myQuaddrilaterial.Perimeter(), 111);
        }
    }
}
