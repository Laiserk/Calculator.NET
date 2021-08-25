using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Calculator.NET;

namespace CalculatorTests
{
    [TestClass]
    public class Tests
    {
        //Tests Sum
        [TestMethod]
        public void Sum_4_5_Returned_9()
        {
            int x = 4;
            int y = 5;
            int expected = 9;

            IOperetions operetions = new OperetionRPN();
            int actual = (int)operetions.Sum(x, y);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Sum_0f4_0f5_Returned_0f9()
        {
            double x = 0.4;
            double y = 0.5;
            double expected = 0.9;

            IOperetions operetions = new OperetionRPN();
            double actual = operetions.Sum(x, y);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Sum_4_0f5_Returned_4f9()
        {
            int x = 4;
            double y = 0.5;
            double expected = 4.5;

            IOperetions operetions = new OperetionRPN();
            double actual = operetions.Sum(x, y);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Sum_negative4_5_Returned_1()
        {
            int x = -4;
            int y = 5;
            int expected = 1;

            IOperetions operetions = new OperetionRPN();
            int actual = (int)operetions.Sum(x, y);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Sum_negative4_negative5_Returned_negative9()
        {
            int x = -4;
            int y = -5;
            int expected = -9;

            IOperetions operetions = new OperetionRPN(); 
            int actual = (int)operetions.Sum(x, y);

            Assert.AreEqual(expected, actual);
        }
        //Tests Difference
        [TestMethod]
        public void Difference_4_5_Returned_negative1()
        {
            int x = 4;
            int y = 5;
            int expected = -1;

            IOperetions operetions = new OperetionRPN();
            int actual = (int)operetions.Difference(x, y);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Difference_5_4_Returned_1()
        {
            double x = 5;
            double y = 4;
            double expected = 1;

            IOperetions operetions = new OperetionRPN();
            double actual = operetions.Difference(x, y);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Difference_4_0f5_Returned_3f5()
        {
            double x = 4;
            double y = 0.5;
            double expected = 3.5;

            IOperetions operetions = new OperetionRPN();
            double actual = operetions.Difference(x, y);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Difference_negative4_5_Returned_negative9()
        {
            int x = -4;
            int y = 5;
            int expected = -9;

            IOperetions operetions = new OperetionRPN();
            int actual = (int)operetions.Difference(x, y);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Difference_negative4_negative5_Returned_1()
        {
            int x = -4;
            int y = -5;
            int expected = 1;

            IOperetions operetions = new OperetionRPN();
            int actual = (int)operetions.Difference(x, y);

            Assert.AreEqual(expected, actual);
        }
        //Tests Multiplication
        [TestMethod]
        public void Multiplication_4_5_Returned_20()
        {
            int x = 4;
            int y = 5;
            int expected = 20;

            IOperetions operetions = new OperetionRPN();
            int actual = (int)operetions.Multiplication(x, y);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Multiplication_0f4_0f5_Returned_0f2()
        {
            double x = 0.4;
            double y = 0.5;
            double expected = 0.2;

            IOperetions operetions = new OperetionRPN();
            double actual = operetions.Multiplication(x, y);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Multiplication_4_0f5_Returned_2()
        {
            int x = 4;
            double y = 0.5;
            double expected = 2;

            IOperetions operetions = new OperetionRPN();
            double actual = operetions.Multiplication(x, y);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Multiplication_negative4_5_Returned_negative20()
        {
            int x = -4;
            int y = 5;
            int expected = -20;

            IOperetions operetions = new OperetionRPN();
            int actual = (int)operetions.Multiplication(x, y);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Multiplication_negative4_negative5_Returned_20()
        {
            int x = -4;
            int y = -5;
            int expected = 20;

            IOperetions operetions = new OperetionRPN();
            int actual = (int)operetions.Multiplication(x, y);

            Assert.AreEqual(expected, actual);
        }
        //Tests Division
        [TestMethod]
        public void Division_4_5_Returned_0f8()
        {
            int x = 4;
            int y = 5;
            double expected = 0.8;

            IOperetions operetions = new OperetionRPN();
            double actual = operetions.Division(x, y);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Division_0f4_0f5_Returned_0f8()
        {
            double x = 0.4;
            double y = 0.5;
            double expected = 0.8;

            IOperetions operetions = new OperetionRPN();
            double actual = operetions.Division(x, y);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Division_4_0f5_Returned_8()
        {
            int x = 4;
            double y = 0.5;
            double expected = 8;

            IOperetions operetions = new OperetionRPN();
            double actual = operetions.Division(x, y);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Division_negative4_5_Returned_negative0f8()
        {
            int x = -4;
            int y = 5;
            double expected = -0.8;

            IOperetions operetions = new OperetionRPN();
            double actual = operetions.Division(x, y);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Division_negative4_negative5_Returned_0f8()
        {
            int x = -4;
            int y = -5;
            double expected = 0.8;

            IOperetions operetions = new OperetionRPN();
            double actual = operetions.Division(x, y);

            Assert.AreEqual(expected, actual);
        }

        //Tests passing expression
        [TestMethod]
        public void Exp_1_Sum_2_Returned_12Sum()
        {
            string x = "1+2";
            string expected = "1 2 + ";

            IPars pars = new ParsRPN();
            string actual = pars.Pars(x);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Exp_1_Sum_2_Mult_3_Returned_123MultSum()
        {
            string x = "1+2 * 3";
            string expected = "1 2 3 * + ";

            IPars pars = new ParsRPN();
            string actual = pars.Pars(x);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Exp_1_Sum_2_Mult_BR3_Div_4BR_Returned_1234DivMultSum()
        {
            string x = "1+2*(3/4)";
            string expected = "1 2 3 4 / * + ";

            IPars pars = new ParsRPN();
            string actual = pars.Pars(x);

            Assert.AreEqual(expected, actual);
        }

        //Tests compute expression
        [TestMethod]
        public void Exp_1_Sum_2_Returned_3()
        {
            string x = "1 2 + ";
            double expected = 3;

            ICompute pars = new ComputeRPN();
            double actual = pars.Compute(x);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Exp_1_Sum_2_Mult_3_Returned_7()
        {
            string x = "1 2 3 * + ";
            double expected = 7;

            ICompute comp = new ComputeRPN();
            double actual = comp.Compute(x);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Exp_1_Sum_2_Mult_BR3_Div_4BR_Returned_2f5()
        {
            string x = "1 2 3 4 / * + ";
            double expected = 2.5;

            ICompute comp = new ComputeRPN();
            double actual = comp.Compute(x);

            Assert.AreEqual(expected, actual);
        }
    }
}
