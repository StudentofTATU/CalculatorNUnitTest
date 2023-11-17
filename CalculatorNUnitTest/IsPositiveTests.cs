using CSharpCalculator;

namespace CalculatorNUnitTest
{
    internal class IsPositiveTests
    {
        Calculator calculator = null!;

        [SetUp]
        public void Setup()
        {
            calculator = new Calculator();
        }

        [Test]
        public void IsPositiveNumberTest()
        {
            //given
            double input = 5;
            bool expectedResult = true;

            //when
            bool actualResult = calculator.isPositive(input);

            //then
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(1, true)]
        [TestCase(50, true)]
        [TestCase(10.1, true)]
        [TestCase(3.4, true)]
        public void ValidatedInputsTest(double input, bool expectedResult)
        {
            //when
            bool actualResult = calculator.isPositive(input);

            //then
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(0, true)]
        [TestCase(-2, true)]
        [TestCase(-7, true)]
        [TestCase(-6.2, true)]
        public void NegativeInputsAreNotEqualTest(double input, bool notExpectedResult)
        {
            //when
            bool actualResult = calculator.isPositive(input);

            //then
            Assert.AreNotEqual(notExpectedResult, actualResult);
        }


        [TestCase("")]
        [TestCase("i")]
        [TestCase(false)]
        [TestCase(null)]
        public void InValidatedInputsThrowExceptionTest(object input)
        {
            Assert.Throws<NotFiniteNumberException>(() => calculator.isPositive(input));
        }
    }
}
