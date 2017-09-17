namespace _08.Recursive_Fibonacci
{
    using System;

    public class RecursiveFibonacci
    {
        private static long[] fibNumbers;

        public static void Main()
        {
            /*
             Prints Nth Fibonacci number using recursion and memoization.
             */

            int number = int.Parse(Console.ReadLine());
            fibNumbers = new long[number];
            long result = GetFibonacciNumber(number);

            Console.WriteLine(result);
        }

        private static long GetFibonacciNumber(int number)
        {
            if (number < 2)
            {
                return number;
            }
            if (fibNumbers[number - 1] != 0)
            {
                return fibNumbers[number - 1];
            }

            return fibNumbers[number - 1] = GetFibonacciNumber(number - 1) + GetFibonacciNumber(number - 2);
        }
    }
}
