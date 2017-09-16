namespace Draw_a_Filled_Square
{
    using System;

    public class DrawFilledSquare
    {
        public static void Main()
        {
            int squareSide = int.Parse(Console.ReadLine());

            PrintFirstAndLastRow(squareSide);
            PrintAllCenterRows(squareSide);
            PrintFirstAndLastRow(squareSide);
        }

        private static void PrintFirstAndLastRow(int squareSide)
        {
            Console.WriteLine(new string('-', 2 * squareSide));
        }

        private static void PrintCenterRow(int squareSide)
        {
            Console.Write("-");

            for (int row = 1; row < squareSide; row++)
            {
                Console.Write(@"\/");
            }

            Console.WriteLine("-");
        }

        private static void PrintAllCenterRows(int squareSide)
        {
            for (int rows = 0; rows < squareSide - 2; rows++)
            {
                PrintCenterRow(squareSide);
            }
        }
    }
}
