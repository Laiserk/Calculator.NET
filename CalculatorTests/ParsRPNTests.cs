using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator.NET;

namespace CalculatorTests
{
    [TestClass]
    public class ParsRPNTests
    {
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
    }
}
