using CSharpCalculator;

namespace CalculatorNUnitTest
{
    internal class PowTests
    {
        Calculator calculator = null;

        [SetUp]
        public void Setup()
        {
            calculator = new Calculator();
        }

        [Test]
        public void PowNumberTest()
        {
            //given
            double inputFirst = 2;
            double inputSecond = 2;
            double expectedResult = 4;

            //when
            double actualResult = calculator.Pow(inputFirst, inputSecond);

            //then
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(2, 3, 8)]
        [TestCase(5, 0, 1)]
        [TestCase(-3, 2, 9)]
        [TestCase(0, 2, 0)]
        public void ValidatedInputsTest(object inputFirst, object inputSecond, double expectedResult)
        {
            //when
            double actualResult = calculator.Pow(inputFirst, inputSecond);

            //then
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(0, 0)]
        [TestCase("", 2)]
        [TestCase(2, "")]
        [TestCase("a", 2)]
        [TestCase(2, "a")]
        [TestCase(false, 2)]
        [TestCase(null, 2)]
        [TestCase(2, null)]
        public void InValidatedInputsThrowExceptionTest(object inputFirst, object inputSecond)
        {
            Assert.Throws<NotFiniteNumberException>(() => calculator.Pow(inputFirst, inputSecond));
        }
    }
}
