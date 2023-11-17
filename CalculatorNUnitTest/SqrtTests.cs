using CSharpCalculator;

namespace CalculatorNUnitTest
{
    internal class SqrtTests
    {
        Calculator calculator = null;

        [SetUp]
        public void Setup()
        {
            calculator = new Calculator();
        }

        [Test]
        public void SqrtNumberTest()
        {
            //given
            double input = 9;
            double expectedResult = 3;

            //when
            double actualResult = calculator.Sqrt(input);

            //then
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(25, 5)]
        [TestCase(16, 4)]
        [TestCase(49, 7)]
        [TestCase(1, 1)]
        public void ValidatedInputsTest(object input, double expectedResult)
        {
            //when
            double actualResult = calculator.Sqrt(input);

            //then
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase("")]
        [TestCase("a")]
        [TestCase(false)]
        [TestCase(null)]
        public void InValidatedInputsThrowExceptionTest(object input)
        {
            Assert.Throws<ArithmeticException>(() => calculator.Sqrt(input));
        }
    }
}
