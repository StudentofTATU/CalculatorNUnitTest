using CSharpCalculator;

namespace CalculatorNUnitTest
{
    internal class SubTests
    {
        Calculator calculator = null;

        [SetUp]
        public void Setup()
        {
            calculator = new Calculator();
        }

        [Test]
        public void SubTwoNumbersTest()
        {
            //given
            double firstInput = 15;
            double secondInput = 3;
            double expectedResult = 12;

            //when
            double actualResult = calculator.Sub(firstInput, secondInput);

            //then
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(5, 2, 3)]
        [TestCase(2, 5, -3)]
        [TestCase(5, 5, 0)]
        [TestCase(0, 5, -5)]
        [TestCase(1, 0, 1)]
        [TestCase(1.5, 1.3, 0.2)]
        [TestCase(1.5, -1.3, -2.8)]
        [TestCase(-10, -3, -7)]
        [TestCase(-10, 3, -13)]
        public void ValidatedInputsTest(object inputOne, object inputSecond, double expectedResult)
        {
            //when
            double actualResult = calculator.Sub(inputOne, inputSecond);

            //then
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase("a", 2)]
        [TestCase(2, "a")]
        [TestCase("a", "a")]
        [TestCase(2, "")]
        [TestCase("", 2)]
        [TestCase("", "")]
        [TestCase(true, 3)]
        public void InValidatedInputsThrowExceptionTest(object inputFirst, object inputSecond)
        {
            Assert.Throws<NotFiniteNumberException>(() => calculator.Sub(inputFirst, inputSecond));
        }

        [TestCase(1, null)]
        [TestCase(null, 1)]
        [TestCase(null, null)]
        public void NullValueInputsThrowExceptionTest(object inputFirst, object inputSecond)
        {
            Assert.Throws<NotFiniteNumberException>(() => calculator.Sub(inputFirst, inputSecond));
        }
    }
}
