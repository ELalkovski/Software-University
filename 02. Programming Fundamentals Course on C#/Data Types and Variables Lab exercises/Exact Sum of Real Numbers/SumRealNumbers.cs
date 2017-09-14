namespace Exact_Sum_of_Real_Numbers
{
    using System;

    public class SumRealNumbers
    {
        public static void Main()
        {
            int numbersCount = int.Parse(Console.ReadLine());
            decimal sum = 0;

            for (int i = 0; i < numbersCount; i++)
            {
                decimal number = decimal.Parse(Console.ReadLine());
                sum += number;
            }

            Console.WriteLine(sum);
        }
    }
}
