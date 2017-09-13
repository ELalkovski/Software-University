namespace RhombusOfStars
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int loopsCount = int.Parse(Console.ReadLine());
            int spaces = loopsCount - 1;

            for (int row = 1; row <= loopsCount; row++)
            {
                Console.Write(new string(' ', spaces));
                Console.Write("*");

                for (int cols = 1; cols < row; cols++)
                {
                    Console.Write(" *");

                }

                Console.WriteLine();
                spaces--;
            }

            spaces = 1;

            for (int row = 1; row <= loopsCount - 1; row++)
            {
                Console.Write(new string(' ', spaces));
                Console.Write("*");

                for (int cols = loopsCount-1; cols > row; cols--)
                {
                    Console.Write(" *");
                }

                Console.WriteLine();
                spaces++;
            }
        }
    }
}
