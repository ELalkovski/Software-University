using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiply_Evens_by_Odds
{
    class Program
    {
        public static int GetMultipleOfEvensAndOdds(int number)
        {
            return Math.Abs(GetSumOfEvenDigits(number) * GetSumOfOddDigits(number));
        }

        public static int GetSumOfEvenDigits(int number)
        {
            return GetSumOfDigits(number, 0);
        }

        public static int GetSumOfOddDigits(int number)
        {
            return GetSumOfDigits(number, 1);
        }

        public static int GetSumOfDigits(int number, int reminder)
        {
            int sum = 0;

            foreach (var symbol in number.ToString())
            {
                var digit = symbol - '0';
                if (digit % 2 == reminder) sum += digit;
            }

            return sum;
        }

        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(GetMultipleOfEvensAndOdds(number));
        }
    }
}
