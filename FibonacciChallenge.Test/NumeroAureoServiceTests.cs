using FibonnaciChallenge;
using FluentAssertions;

namespace FibonacciChallenge.Test
{
    public class NumeroAureoServiceTests
    {
        readonly IFibonnaciService _fibonnaciService;
        public NumeroAureoServiceTests()
        {
            _fibonnaciService = new FibonnaciService();
        }

        [Fact]
        public void GetGoldenNumber_WhenCalled_ReturnsCorrectResult()
        {
            // Arrange
            var service = new NumeroAureoService(_fibonnaciService);

            // Act
            var result = service.ObtenerNumeroAureo();

            // Assert
            result.Should().Be(1.618033988749895);
        }

        [Theory]
        [InlineData(4, 1.6666666666666667)]
        [InlineData(5, 1.6)]
        [InlineData(6, 1.625)]
        [InlineData(7, 1.6153846153846154)]
        [InlineData(8, 1.619047619047619)]
        [InlineData(9, 1.6176470588235294)]
        [InlineData(10, 1.6181818181818182)]
        public void GetGoldenNumberWithFibonnaci_WhenCalledWithN_ReturnsCorrectResult(int n, double expectedResult)
        {
            // Arrange
            var service = new NumeroAureoService(_fibonnaciService);

            // Act
            var result = service.ObtenerNumeroAureoConFibonnaci(n);

            // Assert
            result.Should().Be(expectedResult);
        }
    }
}
