using CSharpCalculator;

namespace CalculatorNUnitTest
{
    internal class DivideTests
    {
        Calculator calculator = null;

        [SetUp]
        public void Setup()
        {
            calculator = new Calculator();
        }

        [Test]
        public void DivideNumbersTest()
        {
            //given
            double inputFirst = 9;
            double inputSecond = 3;
            double expectedResult = 3;

            //when
            double actualResult = calculator.Divide(inputFirst, inputSecond);

            //then
            Assert.AreEqual(actualResult, expectedResult);
        }

        [TestCase(4, 2, 2)]
        [TestCase(-10, 2, -5)]
        [TestCase(5, 2, 2.5)]
        [TestCase(0, 2, 0)]
        public void ValidatedInputsTest(double inputOne, double inputSecond, double expectedResult)
        {
            //when
            double actualResult = calculator.Divide(inputOne, inputSecond);

            //then
            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestCase(4, 0)]
        public void InValidInputsThrowExceptionTest(double inputOne, double inputSecond)
        {
            Assert.Throws<NotFiniteNumberException>(() => calculator.Divide(inputOne, inputSecond));
        }
    }
}
