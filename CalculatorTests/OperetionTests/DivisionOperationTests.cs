using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator.NET;
using Calculator.NET.Command;

namespace CalculatorTests
{
    [TestClass]
    public class DivisionOperetionTests
    {
        [TestMethod]
        public void Division_4_5_Returned_0f8()
        {
            int x = 4;
            int y = 5;
            double expected = 0.8;

            Processor processor = new Processor();
            processor.SetOperation(new DivisionOperation(x, y));
            processor.Run();
            double actual = processor.operation.Result;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Division_0f4_0f5_Returned_0f8()
        {
            double x = 0.4;
            double y = 0.5;
            double expected = 0.8;

            Processor processor = new Processor();
            processor.SetOperation(new DivisionOperation(x, y));
            processor.Run();
            double actual = processor.operation.Result;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Division_4_0f5_Returned_8()
        {
            int x = 4;
            double y = 0.5;
            double expected = 8;

            Processor processor = new Processor();
            processor.SetOperation(new DivisionOperation(x, y));
            processor.Run();
            double actual = processor.operation.Result;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Division_negative4_5_Returned_negative0f8()
        {
            int x = -4;
            int y = 5;
            double expected = -0.8;

            Processor processor = new Processor();
            processor.SetOperation(new DivisionOperation(x, y));
            processor.Run();
            double actual = processor.operation.Result;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Division_negative4_negative5_Returned_0f8()
        {
            int x = -4;
            int y = -5;
            double expected = 0.8;

            Processor processor = new Processor();
            processor.SetOperation(new DivisionOperation(x, y));
            processor.Run();
            double actual = processor.operation.Result;

            Assert.AreEqual(expected, actual);
        }

    }
}
