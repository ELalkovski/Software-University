using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Factorial_Trailing_Zeroes
{
    class Program
    {
        public static BigInteger CalculateFactorial(long input)
        {
            BigInteger factorial = 1;

            for (int i = 1; i <= input; i++)
            {
                factorial *= i;
            }

            return factorial;
        }

        public static int GetTrailingZeroesNumber(int input)
        {
            var count = 0;

            for (int i = 5; i <= input; i *= 5)
            {
                count += (input / i);
            }

            return count;
        }

        static void Main(string[] args)
        {
            var input = int.Parse(Console.ReadLine());

            Console.WriteLine(GetTrailingZeroesNumber(input));
        }
    }
}
