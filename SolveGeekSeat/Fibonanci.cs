using System;

namespace SolveGeekSeat
{
    static class Fibonanci
    {
        //const int MAX = 1000;

        //public static int[] fibonanciSeries = new int[MAX];

        //public static int Fib(int n)
        //{
        //    if (n <= 0)
        //        return 0;

        //    // fib(1) and fib(2) = 1
        //    if (n <= 2)
        //        return fibonanciSeries[n] = 1;

        //    // if fibonanci series already calculate, just return it
        //    if (fibonanciSeries[n] == 1)
        //        return fibonanciSeries[n];

        //    int k = ((n & 1) == 1) ? (n + 1) / 2 : n / 2;

        //    if ((n & 1) == 1)
        //    {
        //        fibonanciSeries[n] = (Fib(k) * Fib(k) + Fib(k - 1) * Fib(k - 1));
        //    }
        //    else
        //    {
        //        fibonanciSeries[n] = (2 * Fib(k - 1) + Fib(k)) * Fib(k);
        //    }

        //    return fibonanciSeries[n];
        //}

        // Source: http://www.maths.surrey.ac.uk/hosted-sites/R.Knott/Fibonacci/fibFormula.html
        static int Fib(int n)
        {
            double phi = (1 + Math.Sqrt(5)) / 2;

            return (int)Math.Round(Math.Pow(phi, n) / Math.Sqrt(5));
        }

        public static int Sum(int n)
        {
            return Fib(n + 2) - 1;
        }
    }
}
