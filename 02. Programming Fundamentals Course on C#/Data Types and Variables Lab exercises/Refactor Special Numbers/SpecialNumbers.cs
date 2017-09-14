namespace Refactor_Special_Numbers
{
    using System;

    public class SpecialNumbers
    {
        public static void Main()
        {
            int numbersCount = int.Parse(Console.ReadLine());
            int sum = 0;
            int digit;
            bool answer = (sum == 5) || (sum == 7) || (sum == 11);

            for (int i = 1; i <= numbersCount; i++)
            {
                digit = i;

                while (digit > 0)
                {
                    sum += digit % 10;
                    digit = digit / 10;
                }

                Console.WriteLine($"{i} -> {answer}");
                sum = 0;
            }
        }
    }
}
