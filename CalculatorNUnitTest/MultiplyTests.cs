using CSharpCalculator;

namespace CalculatorNUnitTest
{
    internal class MultiplyTests
    {
        Calculator calculator = null;

        [SetUp]
        public void Setup()
        {
            calculator = new Calculator();
        }


        [Test]
        public void MultiplyNumbersTest()
        {
            //given
            double inputFirst = 4;
            double inputSecond = 3;
            double expectedResult = 12;

            //when
            double actualResult = calculator.Multiply(inputFirst, inputSecond);

            //then
            Assert.AreEqual(actualResult, expectedResult);
        }

        [TestCase(4, 2, 8)]
        [TestCase(-10, 2, -20)]
        [TestCase(4, 2.2, 8.8)]
        [TestCase(0, 2, 0)]
        public void ValidatedInputsTest(double inputOne, double inputSecond, double expectedResult)
        {
            //when
            double actualResult = calculator.Multiply(inputOne, inputSecond);

            //then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
