using CSharpCalculator;

namespace CalculatorNUnitTest
{
    [TestFixture]
    public class AddTests
    {
        Calculator calculator = null;

        [SetUp]
        public void Setup()
        {
            calculator = new Calculator();
        }

        [Test]
        public void AddTwoNumbersTest()
        {
            //given
            double firstInput = 2;
            double secondInput = 3;
            double expectedResult = 5;

            //when
            double actualResult = calculator.Add(firstInput, secondInput);

            //then
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(5, 7, 12)]
        [TestCase(-5, 5, 0)]
        [TestCase(0, 5, 5)]
        [TestCase(1.5, 1.1, 2.6)]
        [TestCase(1.5, -2.1, -0.6)]
        [TestCase(-10, 2.5, -7.5)]
        public void ValidatedInputsTest(object inputOne, object inputSecond, double expectedResult)
        {
            //when
            double actualResult = calculator.Add(inputOne, inputSecond);

            //then
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase("", 3)]
        [TestCase(2, "a")]
        [TestCase("a", "a")]
        [TestCase(1, "")]
        [TestCase("", 1)]
        [TestCase("", "")]
        [TestCase(true, false)]
        public void InValidatedInputsThrowExceptionTest(object inputOne, object inputSecond)
        {
            Assert.Throws<NotFiniteNumberException>(() => calculator.Add(inputOne, inputSecond));
        }

        [TestCase(1, null)]
        [TestCase(null, 1)]
        [TestCase(null, null)]
        public void NullValueInputsThrowExceptionTest(object inputOne, object inputSecond)
        {
            Assert.Throws<NotFiniteNumberException>(() => calculator.Add(inputOne, inputSecond));
        }
    }
}
