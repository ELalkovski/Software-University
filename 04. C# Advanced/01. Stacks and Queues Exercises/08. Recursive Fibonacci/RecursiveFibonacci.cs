namespace _08.Recursive_Fibonacci
{
    using System;

    public class RecursiveFibonacci
    {
        private static long[] fibNumbers;

        public static long GetFibonacciNumber(int n)
        {

            if (n < 2)
            {
                return n;
            }
            if (fibNumbers[n - 1] != 0)
            {
                return fibNumbers[n - 1];
            }
            return fibNumbers[n - 1] = GetFibonacciNumber(n - 1) + GetFibonacciNumber(n - 2);
        }

        public static void Main()
        {
            /*
             Prints Nth Fibonacci number using recursion and memoization.
             */

            var n = int.Parse(Console.ReadLine());
            fibNumbers = new long[n];
            var result = GetFibonacciNumber(n);
            Console.WriteLine(result);
        }
  
    }
}
