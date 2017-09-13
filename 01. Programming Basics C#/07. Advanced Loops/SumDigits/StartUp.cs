namespace SumDigits
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            int sum = 0;

            do
            {
                sum = sum + (num % 10);
                num = num / 10;

            } while (num > 0);

            Console.WriteLine(sum);
        }
    }
}
