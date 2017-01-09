using NUnit.Framework;
using NunitTesting;

namespace Calculator.Tests
{
    [TestFixture]
    public class SimpleCalculatorTests
    {
        [TestCase(1, 3, 4)]
        [TestCase(2, 10, 12)]
        [TestCase(5, 5, 10)]

        public void ShouldAddTwoNumbers(int firstNum, int secondNum, int expectedNum)
        {
            var sut = new SimpleCalculator();

            var result = sut.Add(firstNum, secondNum);

            Assert.That(result, Is.EqualTo(expectedNum));

        }

        [Test]
        public void ShouldMultiplyTwoNumbers()
        {
            var sut = new SimpleCalculator();

            var result = sut.Multiply(2, 10);

            Assert.That(result, Is.EqualTo(20));

        }

        [Test]
        [MaxTime(1)]
        [Repeat(10000)]
        public void ShouldAddTwoNumbers([Values(10, 20, 30, 0, 18)]int firstNum, [Values(0, 10, 20, 30, 100, 9999999)]int secondNum)
        {
            var sut = new SimpleCalculator();

            sut.Add(firstNum, secondNum);



        }
    }
}
