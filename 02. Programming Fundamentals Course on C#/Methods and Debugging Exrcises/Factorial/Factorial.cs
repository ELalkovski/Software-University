namespace Factorial
{
    using System;
    using System.Numerics;

    public class Factorial
    {
        public static void Main()
        {
            long input = long.Parse(Console.ReadLine());
            Console.WriteLine(CalculateFactorial(input));
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
    }
}
