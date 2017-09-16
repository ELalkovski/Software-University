namespace Printing_Triangle
{
    using System;

    public class TrianglePrint
    {
        public static void Main()
        {
            int side = int.Parse(Console.ReadLine());

            PrintTriangle(side);
        }

        private static void PrintTriangle(int side)
        {
            for (int row = 1; row <= side; row++)
            {
                PrintColumns(row);
            }

            for (int row = side - 1; row >= 1; row--)
            {
                PrintColumns(row);
            }
        }

        private static void PrintColumns(int row)
        {
            for (int col = 1; col <= row; col++)
            {
                Console.Write("{0} ", col);
            }

            Console.WriteLine();
        }
    }
}
