using Moq;
using NUnit.Framework;

namespace ElCurador.Tests
{
    [TestFixture]
    public class OperatorTests
    {
        [Test]
        public void Execute_Should_Return_Correct_Result()
        {
            // Arrange
            int valor = 5;
            int product = valor * 8;
            int sum = 13;
            int expectedResult = 7;

            var additionMock = new Mock<IAddition>();
            additionMock.Setup(a => a.SumDigits(product)).Returns(sum);

            var substractionMock = new Mock<ISubstraction>();
            substractionMock.Setup(s => s.Execute(sum)).Returns(expectedResult);

            var operatorObj = new Operator();
            operatorObj.Addition = additionMock.Object;
            operatorObj.Susbtraction = substractionMock.Object;

            // Act
            int result = operatorObj.Execute(valor);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}
