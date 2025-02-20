using NetTestDemo.App;

namespace NetTestDemo.Test
{
    public class LogicTest
    {
        private Logic _logic;

        [SetUp]
        public void Setup()
        {
            _logic = new Logic();
        }

        [Test]
        public void Sum_WhenCalled_ReturnsSumOfTwoIntegers()
        {
            int result = _logic.Sum(2, 3);
            Assert.That(result, Is.EqualTo(5));
        }

        [Test]
        public void Subtract_WhenCalled_ReturnsDifferenceOfTwoIntegers()
        {
            int result = _logic.Subtract(5, 3);
            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        public void Multiply_WhenCalled_ReturnsProductOfTwoIntegers()
        {
            int result = _logic.Multiply(2, 3);
            Assert.That(result, Is.EqualTo(6));
        }

        [Test]
        public void Divide_WhenCalled_ReturnsQuotientOfTwoIntegers()
        {
            int result = _logic.Divide(6, 3);
            Assert.That(result, Is.EqualTo(2));
        }
    }
}
