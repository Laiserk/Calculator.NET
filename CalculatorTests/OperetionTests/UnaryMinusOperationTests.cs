using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator.NET;
using Calculator.NET.Command;

namespace CalculatorTests
{
    [TestClass]
    public class UnaryMinusOperationTests
    {
        [TestMethod]
        public void UnaryMinus_4_Returned_negative4()
        {
            int x = 4;
            int expected = -4;

            Processor processor = new Processor();
            processor.SetOperation(new UnaryMinusOperation(x));
            processor.Run();
            int actual = (int)processor.operation.Result;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void UnaryMinus_0f4_Returned_negative0f4()
        {
            double x = 0.4;
            double expected = -0.4;

            Processor processor = new Processor();
            processor.SetOperation(new UnaryMinusOperation(x));
            processor.Run();
            double actual = processor.operation.Result;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void UnaryMinus_negative4_Returned_4()
        {
            int x = -4;
            int expected = 4;

            Processor processor = new Processor();
            processor.SetOperation(new UnaryMinusOperation(x));
            processor.Run();
            int actual = (int)processor.operation.Result;

            Assert.AreEqual(expected, actual);
        }
    }
}
