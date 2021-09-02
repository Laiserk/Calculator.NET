using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator.NET;
using Calculator.NET.Command;

namespace CalculatorTests
{
    [TestClass]
    public class DifferenceOperetionTests
    {
        [TestMethod]
        public void Difference_4_5_Returned_negative1()
        {
            int x = 4;
            int y = 5;
            int expected = -1;

            Processor processor = new Processor();
            processor.SetOperation(new DifferenceOperation(x, y));
            processor.Run();
            int actual = (int)processor.operation.Result;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Difference_5_4_Returned_1()
        {
            double x = 5;
            double y = 4;
            double expected = 1;

            Processor processor = new Processor();
            processor.SetOperation(new DifferenceOperation(x, y));
            processor.Run();
            double actual = processor.operation.Result;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Difference_4_0f5_Returned_3f5()
        {
            double x = 4;
            double y = 0.5;
            double expected = 3.5;

            Processor processor = new Processor();
            processor.SetOperation(new DifferenceOperation(x, y));
            processor.Run();
            double actual = processor.operation.Result;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Difference_negative4_5_Returned_negative9()
        {
            int x = -4;
            int y = 5;
            int expected = -9;

            Processor processor = new Processor();
            processor.SetOperation(new DifferenceOperation(x, y));
            processor.Run();
            int actual = (int)processor.operation.Result;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Difference_negative4_negative5_Returned_1()
        {
            int x = -4;
            int y = -5;
            int expected = 1;

            Processor processor = new Processor();
            processor.SetOperation(new DifferenceOperation(x, y));
            processor.Run();
            int actual = (int)processor.operation.Result;

            Assert.AreEqual(expected, actual);
        }

    }
}
