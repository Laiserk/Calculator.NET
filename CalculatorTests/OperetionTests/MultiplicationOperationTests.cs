using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator.NET;
using Calculator.NET.Command;

namespace CalculatorTests
{
    [TestClass]
    public class MultiplicationOperationTests
    {
        [TestMethod]
        public void Multiplication_4_5_Returned_20()
        {
            int x = 4;
            int y = 5;
            int expected = 20;

            Processor processor = new Processor();
            processor.SetOperation(new MultiplicationOperation(x, y));
            processor.Run();
            int actual = (int)processor.operation.Result;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Multiplication_0f4_0f5_Returned_0f2()
        {
            double x = 0.4;
            double y = 0.5;
            double expected = 0.2;

            Processor processor = new Processor();
            processor.SetOperation(new MultiplicationOperation(x, y));
            processor.Run();
            double actual = processor.operation.Result;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Multiplication_4_0f5_Returned_2()
        {
            int x = 4;
            double y = 0.5;
            double expected = 2;

            Processor processor = new Processor();
            processor.SetOperation(new MultiplicationOperation(x, y));
            processor.Run();
            double actual = processor.operation.Result;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Multiplication_negative4_5_Returned_negative20()
        {
            int x = -4;
            int y = 5;
            int expected = -20;

            Processor processor = new Processor();
            processor.SetOperation(new MultiplicationOperation(x, y));
            processor.Run();
            int actual = (int)processor.operation.Result;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Multiplication_negative4_negative5_Returned_20()
        {
            int x = -4;
            int y = -5;
            int expected = 20;

            Processor processor = new Processor();
            processor.SetOperation(new MultiplicationOperation(x, y));
            processor.Run();
            int actual = (int)processor.operation.Result;

            Assert.AreEqual(expected, actual);
        }
    }
}
