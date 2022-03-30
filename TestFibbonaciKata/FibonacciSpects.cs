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

            fib.Should().Be(0);
        }

        [Fact]
        public void Fibonacci_of_1_is_1()
        {
            var fib = Fibonacci.CalculateFibonacci(1);

            fib.Should().Be(1);
        }

        [Fact]
        public void Fibonacci_of_2_is_1()
        {
            var fib = Fibonacci.CalculateFibonacci(2);

            fib.Should().Be(1);
        }

        [Fact]
        public void Fibonacci_of_3_is_2()
        {
            var fib = Fibonacci.CalculateFibonacci(3);

            fib.Should().Be(2);
        }


    }
}
