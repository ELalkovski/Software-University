namespace Fibonacci_Numbers
{
    using System;

    public class FibonacciNumbers
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine(FibonacciNum(number));
        }

        private static int FibonacciNum(int n)
        {
            int firstNum = 0;
            int secondNum = 1;
            int nextNum = 1;

            for (int i = 1; i <= n; i++)
            {
                nextNum = firstNum + secondNum;
                firstNum = secondNum;
                secondNum = nextNum;

            }

            return nextNum;
        }
    }
}
