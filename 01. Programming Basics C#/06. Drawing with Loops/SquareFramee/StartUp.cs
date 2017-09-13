namespace SquareFramee
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int loopsCount = int.Parse(Console.ReadLine());

            Console.Write("+");

            for (int i = 0; i < loopsCount - 2; i++)
            {
                Console.Write(" -");
            }

            Console.Write(" +");
            Console.WriteLine();

            for (int a = 0; a < loopsCount - 2; a++)
            {
                Console.Write("|");

                for (int j = 0; j < loopsCount - 2; j++)
                {
                    Console.Write(" -");
                }

                Console.Write(" |");
                Console.WriteLine();
            }

            Console.Write("+");

            for (int b = 0; b < loopsCount - 2; b++)
            {
                Console.Write(" -");
            }

            Console.Write(" +");
            Console.WriteLine();
        }
    }
}
