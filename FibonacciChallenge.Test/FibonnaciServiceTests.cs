using FibonnaciChallenge;
using FluentAssertions;

namespace FibonacciChallenge.Test
{
    public class FibonnaciServiceTests
    {
        [Theory]
        [InlineData(0, 0)]
        [InlineData(1, 1)]
        [InlineData(2, 1)]
        [InlineData(3, 2)]
        [InlineData(4, 3)]
        [InlineData(5, 5)]
        [InlineData(6, 8)]
        [InlineData(7, 13)]
        [InlineData(8, 21)]
        [InlineData(9, 34)]
        [InlineData(10, 55)]
        public void GetFibonnaciNumber_WhenCalledWithN_ReturnsCorrectResult(int n, int expectedResult)
        {
            // Arrange
            var service = new FibonnaciService();

            // Act
            var result = service.ObtenerNumeroFibonnaciEnPosicion(n);

            // Assert
            result.Should().Be(expectedResult);
        }

        [Fact]
        public void GetFibonnaciSequence_WhenCalledWithN_ReturnsCorrectResult()
        {
            // Arrange
            var service = new FibonnaciService();

            // Act
            var result = service.ObtenerSecuenciaFibonnaci(10);

            // Assert
            result.Should().BeEquivalentTo(new int[] { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34 });
        }


        
    }
}