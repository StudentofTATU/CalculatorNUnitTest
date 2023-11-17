using CSharpCalculator;

namespace CalculatorNUnitTest
{
    internal class IsNegativeTests
    {
        Calculator calculator = null;

        [SetUp]
        public void Setup()
        {
            calculator = new Calculator();
        }

        [Test]
        public void IsNegativeNumberTest()
        {
            //given
            double input = -3;
            bool expectedResult = true;

            //when
            bool actualResult = calculator.isNegative(input);

            //then
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(-4, true)]
        [TestCase(-1, true)]
        [TestCase(-10.7, true)]
        [TestCase(-2.5, true)]
        public void ValidatedInputsTest(double input, bool expectedResult)
        {
            //when
            bool actualResult = calculator.isNegative(input);

            //then
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(0, true)]
        [TestCase(1, true)]
        [TestCase(4.7, true)]
        [TestCase(2.5, true)]
        public void PositiveInputsAreNotEqualTest(double input, bool notExpectedResult)
        {
            //when
            bool actualResult = calculator.isNegative(input);

            //then
            Assert.AreNotEqual(notExpectedResult, actualResult);
        }

        [TestCase("")]
        [TestCase("b")]
        [TestCase(true)]
        [TestCase(null)]
        public void InValidatedInputsThrowExceptionTest(object input)
        {
            Assert.Throws<NotFiniteNumberException>(() => calculator.isNegative(input));
        }
    }
}
