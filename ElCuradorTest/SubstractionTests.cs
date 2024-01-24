using NUnit.Framework;
using ElCurador;

namespace ElCurador.Tests
{
    public class SubstractionTests
    {
        [Test]
        public void Execute_Subtracts9FromNumber_ReturnsCorrectResult()
        {
            // Arrange
            Substraction substraction = new Substraction();
            int number = 15;
            int expected = 6;

            // Act
            int result = substraction.Execute(number);

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}
