using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace FibbonaciKata
{
    public class Fibonacci
    {

        private static StringBuilder FibSerie { get; set; }

        public static string getFibSerie()
        {
            return FibSerie.ToString();
        }

        public static void Main(string[] args)
        {
        }

        public static int CalculateFibonacci(int num)
        {
            long Fib0 = 0;
            long Fib1 = 1;

            FibSerie?.Clear();

            if (num == 0) return 0;
            if (num <= 2) return 1;

            FibSerie = new StringBuilder();

            for (int i = 0; i < num; i++)
            {
                if (i == 0)
                {
                    FibSerie.Append(0.ToString());
                }

                var FibToSearch = Fib0;
                Fib0 = Fib1;
                Fib1 = FibToSearch + Fib0;
                FibSerie.Append(",");
                FibSerie.Append(Fib0.ToString());
            }

            return int.Parse(FibSerie.ToString().Split(',').Last());
        }
    }
}
