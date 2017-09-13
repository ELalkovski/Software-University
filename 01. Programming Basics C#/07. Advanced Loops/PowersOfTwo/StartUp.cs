namespace PowersOfTwo
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int nthNumber = int.Parse(Console.ReadLine());
            int number = 1;

            for (int nums = 0; nums <= nthNumber; nums++)
            {
                Console.WriteLine(number);

                number = number * 2;
            }
        }
    }
}
