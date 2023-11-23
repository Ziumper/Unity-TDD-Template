using Moq;
using NUnit.Framework;

namespace ThirdParty.Tests
{
    public class CalculatorTests
    {
        private ICalculator _calculator;

        /// <summary>
        /// This Setup method needs to be public, it's executed before each method with [Test] addnotation
        /// </summary>
        [SetUp]
        public void Setup()
        {
            _calculator = new Calculator();
        }

        /// <summary>
        /// This TearDown method needs to be public, it's execute after each method with [Test] finish execution
        /// </summary>
        [TearDown]
        public void TearDown()
        {
            _calculator = null;
        }

        /// <summary>
        /// Example tests that is showing base flow of tests execution
        /// </summary>
        [Test]
        public void IsTwoPlusTwoIsFour()
        {
            //Arrange
            int a = 2;
            int b = 2;

            //Act
            int result = _calculator.Add(a, b);

            //Assert
            Assert.AreEqual(4, result);
        }

        /// <summary>
        /// More complex example where we create more test cases
        /// </summary>
        /// <param name="a">First adding param</param>
        /// <param name="b">Second adding param</param>
        /// <param name="expected">Expected result of test</param>
        [Test]
        [TestCase(1, 1, 2)]
        [TestCase(2, 2, 4)]
        [TestCase(-3, 4, 1)]
        public void AddTests(int a, int b, int expected)
        {
            Assert.AreEqual(expected, _calculator.Add(a, b));
        }

        /// <summary>
        /// Example usage of moq library for making custom implementation and test cases
        /// more interesting
        /// </summary>
        [Test]
        [TestCase(1, 2)]
        [TestCase(-100, 20)]
        [TestCase(20, 5000)]
        public void CustomAddingTestWithMockAddAlwaysReturn2(int a, int b)
        {
            var mock = new Mock<IAdder>();
            mock.Setup(adder => adder.Add(It.IsAny<int>(), It.IsAny<int>())).Returns(2);

            _calculator = new Calculator(mock.Object);

            Assert.AreEqual(2, _calculator.Add(a, b));
        }
    }

}

