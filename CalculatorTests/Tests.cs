using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CalculatorLib;

namespace CalculatorTests
{
    [TestClass]
    public class Tests
    {
        //Test Sum
        [TestMethod]
        public void Sum_4_5_9returned()
        {
            int x = 4;
            int y = 5;
            int expected = 9;

            Calculator calc = new Calculator();
            int actual = (int)calc.Sum(x, y);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Sum_0f4_0f5_09returned()
        {
            double x = 0.4;
            double y = 0.5;
            double expected = 0.9;

            Calculator calc = new Calculator();
            double actual = calc.Sum(x, y);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Sum_4_0f5_4f9returned()
        {
            int x = 4;
            double y = 0.5;
            double expected = 4.5;

            Calculator calc = new Calculator();
            double actual = calc.Sum(x, y);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Sum_negative4_5_1returned()
        {
            int x = -4;
            int y = 5;
            int expected = 1;

            Calculator calc = new Calculator();
            int actual = (int)calc.Sum(x, y);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Sum_negative4_negative5_negative9returned()
        {
            int x = -4;
            int y = -5;
            int expected = -9;

            Calculator calc = new Calculator();
            int actual = (int)calc.Sum(x, y);

            Assert.AreEqual(expected, actual);
        }
        //Test Difference
        [TestMethod]
        public void Difference_4_5_negative1returned()
        {
            int x = 4;
            int y = 5;
            int expected = -1;

            Calculator calc = new Calculator();
            int actual = (int)calc.Difference(x, y);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Difference_5_4_1returned()
        {
            double x = 5;
            double y = 4;
            double expected = 1;

            Calculator calc = new Calculator();
            double actual = calc.Difference(x, y);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Difference_4_0f5_3f5returned()
        {
            double x = 4;
            double y = 0.5;
            double expected = 3.5;

            Calculator calc = new Calculator();
            double actual = calc.Difference(x, y);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Difference_negative4_5_negative9returned()
        {
            int x = -4;
            int y = 5;
            int expected = -9;

            Calculator calc = new Calculator();
            int actual = (int)calc.Difference(x, y);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Difference_negative4_negative5_1returned()
        {
            int x = -4;
            int y = -5;
            int expected = 1;

            Calculator calc = new Calculator();
            int actual = (int)calc.Difference(x, y);

            Assert.AreEqual(expected, actual);
        }
        //Test Multiplication
        [TestMethod]
        public void Multiplication_4_5_20returned()
        {
            int x = 4;
            int y = 5;
            int expected = 20;

            Calculator calc = new Calculator();
            int actual = (int)calc.Multiplication(x, y);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Multiplication_0f4_0f5_0f2returned()
        {
            double x = 0.4;
            double y = 0.5;
            double expected = 0.2;

            Calculator calc = new Calculator();
            double actual = calc.Multiplication(x, y);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Multiplication_4_0f5_2returned()
        {
            int x = 4;
            double y = 0.5;
            double expected = 2;

            Calculator calc = new Calculator();
            double actual = calc.Multiplication(x, y);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Multiplication_negative4_5_negative20returned()
        {
            int x = -4;
            int y = 5;
            int expected = -20;

            Calculator calc = new Calculator();
            int actual = (int)calc.Multiplication(x, y);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Multiplication_negative4_negative5_20returned()
        {
            int x = -4;
            int y = -5;
            int expected = 20;

            Calculator calc = new Calculator();
            int actual = (int)calc.Multiplication(x, y);

            Assert.AreEqual(expected, actual);
        }
        //Test Division
        [TestMethod]
        public void Division_4_5_0f8returned()
        {
            int x = 4;
            int y = 5;
            double expected = 0.8;

            Calculator calc = new Calculator();
            double actual = calc.Division(x, y);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Division_0f4_0f5_0f8returned()
        {
            double x = 0.4;
            double y = 0.5;
            double expected = 0.8;

            Calculator calc = new Calculator();
            double actual = calc.Division(x, y);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Division_4_0f5_8returned()
        {
            int x = 4;
            double y = 0.5;
            double expected = 8;

            Calculator calc = new Calculator();
            double actual = calc.Division(x, y);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Division_negative4_5_negative0f8returned()
        {
            int x = -4;
            int y = 5;
            double expected = -0.8;

            Calculator calc = new Calculator();
            double actual = calc.Division(x, y);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Division_negative4_negative5_0f8returned()
        {
            int x = -4;
            int y = -5;
            double expected = 0.8;

            Calculator calc = new Calculator();
            double actual = calc.Division(x, y);

            Assert.AreEqual(expected, actual);
        }
    }
}
