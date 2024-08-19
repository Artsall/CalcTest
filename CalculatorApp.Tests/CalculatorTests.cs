using Xunit;
using CalculatorApp;

namespace CalculatorApp.Tests
{
    public class CalculatorTests
    {
        [Fact]
        public void Add_TwoPositiveNumbers_ReturnsCorrectSum()
        {
            // Arrange
            var calculator = new Calculator();
            int a = 5;
            int b = 3;

            // Act
            int result = calculator.Add(a, b);

            // Assert
            Assert.Equal(8, result);
        }

        [Fact]
        public void Add_NegativeAndPositiveNumber_ReturnsCorrectSum()
        {
            // Arrange
            var calculator = new Calculator();
            int a = -5;
            int b = 3;

            // Act
            int result = calculator.Add(a, b);

            // Assert
            Assert.Equal(-2, result);
        }

        [Fact]
        public void Add_TwoNegativeNumbers_ReturnsCorrectSum()
        {
            // Arrange
            var calculator = new Calculator();
            int a = -5;
            int b = -3;

            // Act
            int result = calculator.Add(a, b);

            // Assert
            Assert.Equal(-8, result);
        }
    }
}
