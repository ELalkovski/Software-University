namespace Sequence2K_1
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int nthNumber = int.Parse(Console.ReadLine());
            int currentNumber = 1;

            while (currentNumber <= nthNumber)
            {
                Console.WriteLine(currentNumber);

                currentNumber = (currentNumber * 2) + 1;
            }
        }
    }
}
