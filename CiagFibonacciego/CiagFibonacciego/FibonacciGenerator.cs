using System;
using System.Threading;

namespace CiagFibonacciego
{
    public class FibonacciGenerator
    {
        public static void Generate(int timePeriod)
        {
            long a = 1;
            long b = 0;

            for (; ; )
            {
                Thread.Sleep(1000);
                Console.WriteLine(b);
                b += a;
                a = b - a;
            }
        }
    }
}