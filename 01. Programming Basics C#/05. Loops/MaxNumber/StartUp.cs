namespace MaxNumber
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int loopsCount = int.Parse(Console.ReadLine());
            int currentNumber = int.Parse(Console.ReadLine());
            int max = currentNumber;

            for (int i = 0; i < loopsCount - 1; i++)
            {
                currentNumber = int.Parse(Console.ReadLine());

                if (currentNumber > max)
                {
                    max = currentNumber;
                }
            }

            Console.WriteLine(max);
        }
    }
}
