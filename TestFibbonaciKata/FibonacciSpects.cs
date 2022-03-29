using FibbonaciKata;
using FluentAssertions;
using Xunit;

namespace TestFibbonaciKata
{
    public class FibonacciSpects
    {
        [Fact]
        public void Fibonacci_of_0_is_0()
        {
            var fib = Fibonacci.CalculateFibonacci(0);

            fib.Should().Be("0");
        }
    }
}
