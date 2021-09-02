using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator.NET;

namespace CalculatorTests
{
    [TestClass]
    public class ComputeRPNTests
    {
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
