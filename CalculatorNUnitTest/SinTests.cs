using CSharpCalculator;

namespace CalculatorNUnitTest
{
    internal class SinTests
    {
        Calculator calculator = null;

        [SetUp]
        public void Setup()
        {
            calculator = new Calculator();
        }

        [Test]
        public void SinTest()
        {
            //given
            double angle = 90;
            double input = angle * (Math.PI / 180);
            double expectedResult = 1;

            //when
            double actualResult = calculator.Sin(input);

            //then
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase("")]
        [TestCase(" ")]
        [TestCase("p")]
        [TestCase(true)]
        [TestCase(null)]
        public void InValidatedInputsThrowExceptionTest(object input)
        {
            Assert.Throws<NotFiniteNumberException>(() => calculator.Sin(input));
        }
    }
}
