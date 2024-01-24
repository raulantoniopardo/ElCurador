using NUnit.Framework;

namespace ElCurador.Tests
{
    [TestFixture]
    public class AdditionTests
    {
        private IAddition _addition;

        [SetUp]
        public void Setup()
        {
            _addition = new Addition();
        }

        [Test]
        public void SumDigits_ShouldReturnCorrectSum()
        {
            // Arrange
            int number = 12345;
            int expectedSum = 15;

            // Act
            int actualSum = _addition.SumDigits(number);

            // Assert
            Assert.AreEqual(expectedSum, actualSum);
        }

        [Test]
        public void SumDigits_ShouldReturnZeroForZeroNumber()
        {
            // Arrange
            int number = 0;
            int expectedSum = 0;

            // Act
            int actualSum = _addition.SumDigits(number);

            // Assert
            Assert.AreEqual(expectedSum, actualSum);
        }

        [Test]
        public void SumDigits_ShouldReturnSameNumberForSingleDigitNumber()
        {
            // Arrange
            int number = 7;
            int expectedSum = 7;

            // Act
            int actualSum = _addition.SumDigits(number);

            // Assert
            Assert.AreEqual(expectedSum, actualSum);
        }
    }
}
