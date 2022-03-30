using System.Text;
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
        public void Get_the_number_of_secuence_fibonacci_by_position(int position, int expectedResult)
        {
            var fib = Fibonacci.CalculateFibonacci(position);

            fib.Should().Be(expectedResult);
        }

        [Theory]
        [InlineData(3,"0,1,1,2")]
        public void get_fibonacci_secuence_by_number(int input, string expectedResult)
        {
            var fib = Fibonacci.CalculateFibonacci(input);
            var fibSecuence = Fibonacci.getFibSerie();


            fibSecuence.Should().Be(expectedResult);
        }
    }
}
