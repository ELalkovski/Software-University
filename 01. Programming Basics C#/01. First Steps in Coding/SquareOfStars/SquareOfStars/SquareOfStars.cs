namespace SquareOfStars
{
    using System;

    public class SquareOfStars
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string asterisks = new string('*', n);
           
            string spaces = new string(' ', n - 2);
            string starsSpaces = "*" + spaces + "*";

            Console.WriteLine(asterisks);

            for (int i = 1; i <= n-2; i++)
            {
                Console.WriteLine(starsSpaces);
               
            }

            Console.WriteLine(asterisks);
        }
    }
}
