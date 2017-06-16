using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestDrivenDevelopmentSample;
using Moq;
namespace TestDrivenDevelopmentMockSample
{
    [TestClass]

    public class CalculatorMockTests
    {
        [TestMethod]
        [TestCategory("By Using Moq")]
        public void MockAddNumbers()
        {
            var mockCalculator = new Mock<ICalculator>();
            mockCalculator.Setup(r => r.AddNumbers(3, 2)).Returns(5);
            var result = mockCalculator.Object.AddNumbers(3, 2);
            mockCalculator.Verify(r => r.AddNumbers(3, 2), Times.AtLeastOnce());
            Assert.AreEqual(result, 5);

        }
        [TestMethod]
        [TestCategory("By Using Moq")]
        public void MockMinusNumbers()
        {
            var mockCalculator = new Mock<ICalculator>();
            mockCalculator.Setup(r => r.MinusNumbers(3, 2)).Returns(1);
            var result = mockCalculator.Object.MinusNumbers(3, 2);
            mockCalculator.Verify(r => r.MinusNumbers(3, 2), Times.AtLeastOnce);
            Assert.AreEqual(result, 1);
        }

        [TestMethod]
        [TestCategory("By Using Moq")]
        public void MockDoOperationsNumbers()
        {
            var mockCalculator = new Mock<ICalculator>();

            mockCalculator.Setup(r => r.DecideAndDoOperation(1, "+", 1)).Returns(2);
            var result = mockCalculator.Object.DecideAndDoOperation(1, "+", 1);

            Assert.AreEqual(result, 2);
        }
    }
}
