using CSharpCalculator;

namespace CalculatorNUnitTest
{
    internal class AbsTests
    {
        Calculator calculator = null;

        [SetUp]
        public void Setup()
        {
            calculator = new Calculator();
        }

        [Test]
        public void AbsNumberTest()
        {
            //given
            double input = -2;
            double expectedResult = 2;

            //when
            double actualResult = calculator.Abs(input);

            //then
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(5, 5)]
        [TestCase(-3, 3)]
        [TestCase(0, 0)]
        [TestCase(-1.5, 1.5)]
        [TestCase(3.5, 3.5)]
        public void ValidatedInputsTest(object input, double expectedResult)
        {
            //when
            double actualResult = calculator.Abs(input);

            //then
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase("")]
        [TestCase("a")]
        [TestCase(false)]
        [TestCase(null)]
        public void InValidatedInputsThrowExceptionTest(object input)
        {
            Assert.Throws<NotFiniteNumberException>(() => calculator.Abs(input));
        }
    }
}
