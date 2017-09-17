namespace _01_Matrix_of_Palindromes
{
    using System;
    using System.Linq;

    public class Palindromes
    {
        public static void Main()
        {
            /*
                This program recieves two integers, separated by space and then generates and prints
                the following matrix of palindromes of 3 letters with r rows and c columns.

                •	Rows define the first and the last letter: row 0 => ‘a’, row 1 => ‘b’, row 2 => ‘c’, …
                •	Columns + rows define the middle letter: 
            */

            int[] matrixSizes = Console.ReadLine()
                .Split(new [] {' ', ','}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rows = matrixSizes[0];
            int cols = matrixSizes[1];

            string[][] matrix = new string[rows][];

            char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();

            for (int currRow = 0; currRow < matrix.Length; currRow++)
            {
                matrix[currRow] = new string[cols];

                for (int currCol = 0; currCol < matrix[currRow].Length; currCol++)
                {
                    matrix[currRow][currCol] = "" + (char)('a' + currRow) + (char)('a' + currRow + currCol) + (char)('a' + currRow);
                }
            }

            for (int currRow = 0; currRow < matrix.Length; currRow++)
            {
                for (int currCol = 0; currCol < matrix[currRow].Length; currCol++)
                {
                    Console.Write($"{matrix[currRow][currCol]} ");
                }

                Console.WriteLine();
            }
        }
    }
}
