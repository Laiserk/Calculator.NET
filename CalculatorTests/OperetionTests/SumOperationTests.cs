using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator.NET;
using Calculator.NET.Command;

namespace CalculatorTests
{
    [TestClass]
    public class SumOperationTests
    {
        [TestMethod]
        public void Sum_4_5_Returned_9()
        {
            int x = 4;
            int y = 5;
            int expected = 9;

            Processor processor = new Processor();
            processor.SetOperation(new SumOperation(x, y));
            processor.Run();
            int actual = (int)processor.operation.Result;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Sum_0f4_0f5_Returned_0f9()
        {
            double x = 0.4;
            double y = 0.5;
            double expected = 0.9;

            Processor processor = new Processor();
            processor.SetOperation(new SumOperation(x, y));
            processor.Run();
            double actual = processor.operation.Result;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Sum_4_0f5_Returned_4f9()
        {
            int x = 4;
            double y = 0.5;
            double expected = 4.5;

            Processor processor = new Processor();
            processor.SetOperation(new SumOperation(x, y));
            processor.Run();
            double actual = processor.operation.Result;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Sum_negative4_5_Returned_1()
        {
            int x = -4;
            int y = 5;
            int expected = 1;

            Processor processor = new Processor();
            processor.SetOperation(new SumOperation(x, y));
            processor.Run();
            int actual = (int)processor.operation.Result;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Sum_negative4_negative5_Returned_negative9()
        {
            int x = -4;
            int y = -5;
            int expected = -9;

            Processor processor = new Processor();
            processor.SetOperation(new SumOperation(x, y));
            processor.Run();
            int actual = (int)processor.operation.Result;

            Assert.AreEqual(expected, actual);
        }
    }
}
