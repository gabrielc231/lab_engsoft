// CalculatorTests.cs
using MyApp;
using Xunit;

namespace MyApp.Tests
{
    public class CalculatorTests
    {
        [Fact]
        public void Add_ShouldReturnSum_WhenTwoIntegersAreGiven()
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
    }
}
