namespace Factorial_Trailing_Zeroes
{
    using System;
    using System.Numerics;

    public class FactorialZeroes
    {
        public static void Main()
        {
            int input = int.Parse(Console.ReadLine());

            Console.WriteLine(GetTrailingZeroesNumber(input));
        }

        private static BigInteger CalculateFactorial(long input)
        {
            BigInteger factorial = 1;

            for (int i = 1; i <= input; i++)
            {
                factorial *= i;
            }

            return factorial;
        }

        private static int GetTrailingZeroesNumber(int input)
        {
            int count = 0;

            for (int i = 5; i <= input; i *= 5)
            {
                count += (input / i);
            }

            return count;
        }
    }
}
