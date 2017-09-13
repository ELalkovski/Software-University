namespace Exercise
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int rows = 10;
            int symbolsPerRow = 10;

            for (int i = 1; i <= rows; i++)
            {
                Console.WriteLine(new string ('*',symbolsPerRow));
            }
        }
    }
}
