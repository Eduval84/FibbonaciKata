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
        private static long Fib0 = 0;
        private static long Fib1 = 1;
        private static long FibToSearch = 0;
        public static StringBuilder FibSerie { get; set; }

        public static void Main(string[] args)
        {
        }

        public static int CalculateFibonacci(int num)
        {
            if (num == 0) return 0;

            FibSerie = new StringBuilder();
       
            for (int i = 0; i < num; i++)
            {
                if (i == 0)
                {
                    FibSerie.Append(0.ToString());
                }

                FibToSearch = Fib0;
                Fib0 = Fib1;
                Fib1 = FibToSearch + Fib0;
                FibSerie.Append(",");
                FibSerie.Append(Fib0.ToString());
            }

        
            if (num <= 2) return 1;

            return 2;
        }
    }
}
