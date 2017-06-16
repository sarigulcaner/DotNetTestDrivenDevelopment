using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestDrivenDevelopmentSample;
namespace TestDrivenDevelopmentTest
{
    [TestClass]
    public class CalculatorUnitTests
    {
        [TestMethod]
        [Description("Calculator do operation 3 plus 2 equals 5")]
        public void CalculatorAdd3Plus2Equal5()
        {
            Calculator calc = new Calculator();
            Assert.AreEqual(calc.AddNumbers(3, 2), 5);
        }
        [TestMethod]
        [Description("Calculator do operation 4 plus 3 equals 7")]
        public void CalculatorAdd4Plus3Equal7()
        {
            Calculator calc = new Calculator();
            Assert.AreEqual(calc.AddNumbers(4, 3), 7);
        }

        [TestMethod]
        [Description("Calculator do operation 3 minus 2 equals 1")]
        public void Calculator3Minus2Equals1()
        {
            Calculator calc = new Calculator();
            Assert.AreEqual(calc.MinusNumbers(3, 2), 1);
        }

        [TestMethod]
        [Description("Calculator do operation 4 divide 2 equals 2")]
        public void Calculator4Divide2Equals2()
        {
            Calculator calc = new Calculator();
            Assert.AreEqual(calc.DivideNumbers(4, 2), 2);
        }
        [TestMethod]
        [Description("Calculator do operation 2 multiply 2 equals 4")]
        public void Calculator2Multiply2Equals4()
        {
            Calculator calc = new Calculator();
            Assert.AreEqual(calc.MultiplyNumbers(2, 2), 4);
        }
        [TestMethod]
        [Description("Calculator divide by 0")]
        public void CalculatorDivideBy0()
        {
            Calculator calc = new Calculator();
            // Special Case
            Assert.AreEqual(calc.DivideNumbers(0, 0), 0);
        }
        [TestMethod]
        [Description("Calculator mix operations")]
        public void CalculatorDecideOperationWith2Numbers()
        {
            Calculator calc = new Calculator();
            Assert.AreEqual(calc.DecideAndDoOperation(2,"*", 2), 4);
            Assert.AreEqual(calc.DecideAndDoOperation(2, "/", 2), 1);
            Assert.AreEqual(calc.DecideAndDoOperation(2, "+", 2), 4);
            Assert.AreEqual(calc.DecideAndDoOperation(2, "-", 2), 0);
            Assert.AreEqual(calc.DecideAndDoOperation(2, "@", 2), 0);

            Assert.AreEqual(calc.DecideAndDoOperation(0, "*", 0), 0);
            Assert.AreEqual(calc.DecideAndDoOperation(0, "/", 0), 0);
      
        }
       
    }
}
