using CSharpCalculator;

namespace CalculatorNUnitTest
{
    internal class CosTests
    {
        Calculator calculator = null;

        [SetUp]
        public void Setup()
        {
            calculator = new Calculator();
        }

        [Test]
        public void CosTest()
        {
            //given
            double angle = 180;
            double input = angle * (Math.PI / 180);
            double expectedResult = -1;

            //when
            double actualResult = calculator.Cos(input);

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
            Assert.Throws<NotFiniteNumberException>(() => calculator.Cos(input));
        }
    }
}
