using System;
using Shapes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestShapes
{

    [TestClass]
    public class SquareTests
    {

        [TestMethod]
        public void MySquareAreaTest()
        {
            square square = new square(3);
            Assert.AreEqual(9, square.Area());
        }

    }
}
