﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes;



namespace UnitTestShapes
{
    [TestClass]
    public class QuadrilateralTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestQuadHasDefaultSize()
        {
            Quadrilateral myquad = new Quadrilateral();
            myquad.Perimeter();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestQuadNotNegativeSides()
        {
            Quadrilateral myquad = new Quadrilateral();
            myquad.Top = 2;
            myquad.Right = 2;
            myquad.Left = 2;
            myquad.Bottom = -2;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestQuadNoNegativeSidesInConstructor()
        {
            Quadrilateral myquad = new Quadrilateral(2, -2, 2, 2);
        }

        [TestMethod]
        public void TestQuadCanComputePerimeter()
        {
            Quadrilateral myquad = new Quadrilateral();
            myquad.Top = 2;
            myquad.Right = 2;
            myquad.Left = 2;
            myquad.Bottom = 2;
            Assert.AreEqual(8, myquad.Perimeter());
        }

        [TestMethod]
        public void TestQuadCanComputePerimeter2()
        {
            Quadrilateral myquad = new Quadrilateral(2, 2, 2, 2);
            Assert.AreEqual(8, myquad.Perimeter());
        }

        [TestMethod]
        public void TestQuadPerimetersAreTheSame()
        {
            Quadrilateral myquad1 = new Quadrilateral();
            myquad1.Top = 2;
            myquad1.Right = 2;
            myquad1.Left = 2;
            myquad1.Bottom = 2;
            Quadrilateral myquad2 = new Quadrilateral(2, 2, 2, 2);
            Assert.AreEqual(myquad1.Perimeter(), myquad2.Perimeter());
        }

        [TestMethod]
        public void TestQuadCanComputeArea()
        {
            Quadrilateral myquad = new Quadrilateral();
            myquad.Top = 3;
            myquad.Right = 3;
            myquad.Left = 3;
            myquad.Bottom = 3;
            Assert.AreEqual(9, myquad.Area());
        }


    [TestMethod]
        public void retangletest()
        {
            rectangle rectangle = new rectangle(4, 5, 4, 5);
            Assert.AreEqual(20, rectangle.Area());
        }

        [TestMethod]
        public void myrectanglePerimeter()
        {
            rectangle rectangle = new rectangle(4, 5, 4, 5);
            Assert.AreEqual(18, rectangle.Perimeter());
        }

        [TestMethod]
        public void MySquare()
        {
            square square = new square(3, 3, 3, 3);
            Assert.AreEqual(9, square.Area()); //should be 9 check square/quad
        }
        
    }

    }