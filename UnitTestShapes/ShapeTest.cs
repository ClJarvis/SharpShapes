﻿using System;
//using System.Drawing;
using System.Windows.Media;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Reflection;


namespace UnitTestShapes
{
    [TestClass]
    public class ShapeTest
    {
        public class ConcreteShape : Shapes.Shape
        {
            public ConcreteShape()
            {
                BorderColor = Colors.NavajoWhite;
                FillColor = Colors.PapayaWhip;
            }
        }

        [TestMethod]
        public void TestAbstractShapeHasBorderColor()
        {
            ConcreteShape cs = new ConcreteShape();
            Assert.AreEqual(Colors.NavajoWhite, cs.BorderColor);
        }

        [TestMethod]
        public void TestAbstractShapeHasFillColor()
        {
            ConcreteShape cs = new ConcreteShape();
            Assert.AreEqual(Colors.PapayaWhip, cs.FillColor);
        }

        [TestMethod]
        [ExpectedException(typeof(NotImplementedException))]
        public void TestAbstractShapeHasArea()
        {
            ConcreteShape cs = new ConcreteShape();
            cs.Area();
        }

        [TestMethod]
        [ExpectedException(typeof(NotImplementedException))]
        public void TestAbstractShapeHasPerimeter()
        {
            ConcreteShape cs = new ConcreteShape();
            cs.Perimeter();
        }

        [TestMethod]
        public void FindShapesTest()
        {
            List<string> classes = new List<string> { "Square", "Rectangle", "Shape"};
            CollectionAssert.AreEqual(classes,Assembly.GetAssembly(typeof(Shapes.Shape)).GetTypes());
            //Assert.AreEqual(typeof(Shapes.Shape), typeof(ConcreteShape));
        }

        [TestMethod]
        public void TestSquareisASubclassofRectangle()
        {
            Assert.IsTrue(typeof(Shapes.square).IsSubclassOf(typeof(Shapes.Rectangle)));
        }

        [TestMethod]
        public void TestSquareisASubclassOfQuadrilateral()
        {
            Assert.IsTrue(typeof(Shapes.square).IsSubclassOf(typeof(Shapes.Rectangle)));
        }


    }
}