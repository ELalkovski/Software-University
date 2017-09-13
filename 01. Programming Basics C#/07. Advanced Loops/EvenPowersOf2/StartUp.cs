namespace EvenPowersOf2
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int loopsCount = int.Parse(Console.ReadLine());
            int number = 1;

            for (int i = 0; i <= loopsCount; i+=2)
            {
                Console.WriteLine(number);

                number = number * 2 * 2;
            }
        }
    }
}
