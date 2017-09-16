namespace Multiply_Evens_by_Odds
{
    using System;

    public class MultiplyEvensByOdds
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(GetMultipleOfEvensAndOdds(number));
        }

        private static int GetMultipleOfEvensAndOdds(int number)
        {
            return Math.Abs(GetSumOfEvenDigits(number) * GetSumOfOddDigits(number));
        }

        private static int GetSumOfEvenDigits(int number)
        {
            return GetSumOfDigits(number, 0);
        }

        private static int GetSumOfOddDigits(int number)
        {
            return GetSumOfDigits(number, 1);
        }

        private static int GetSumOfDigits(int number, int reminder)
        {
            int sum = 0;

            foreach (var symbol in number.ToString())
            {
                var digit = symbol - '0';
                if (digit % 2 == reminder) sum += digit;
            }

            return sum;
        }
    }
}
