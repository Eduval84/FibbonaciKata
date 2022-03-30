using FibbonaciKata;
using FluentAssertions;
using Xunit;

namespace TestFibbonaciKata
{
    public class FibonacciSpects
    {
        [Theory]
        [InlineData(0,0)]
        [InlineData(1, 1)]
        [InlineData(2, 1)]
        [InlineData(3, 2)]
        public void Fibonacci_of_0_is_0(int input, int expectedResult)
        {
            var fib = Fibonacci.CalculateFibonacci(input);

            fib.Should().Be(expectedResult);
        }

    }
}
