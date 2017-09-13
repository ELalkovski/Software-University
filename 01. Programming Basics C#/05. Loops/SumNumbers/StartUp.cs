namespace SumNumbers
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int loopsCount = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i < loopsCount; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                sum = sum + currentNumber;
            }

            Console.WriteLine(sum);
        }
    }
}
