namespace _02.Maximum_sum_of_2x2_submatrix
{
    using System;
    using System.Linq;

    public class MaxSum
    {
        public static void Main()
        {
            /*
             This program reads a matrix from console. Then finds biggest sum of 2x2 submatrix and prints it to console.
             Input is in format:
             On first line matrix sizes in format "rows, columns".
             On next "rows" lines recieves arrays in format "number, number, ....columns - 1"
             */

            int[] matrixSizes = Console.ReadLine()
                .Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rows = matrixSizes[0];
            int cols = matrixSizes[1];

            int[][] matrix = new int[rows][];

            int bestRow = 0;
            int bestCol = 0;
            int maxSum = int.MinValue;

            for (int currRow = 0; currRow < matrix.Length; currRow++)
            {
                int[] rowElements = Console.ReadLine()
                    .Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                matrix[currRow] = new int[cols];

                for (int currCol = 0; currCol < cols; currCol++)
                {
                    matrix[currRow][currCol] = rowElements[currCol];
                }
            }

            for (int currRow = 0; currRow < matrix.Length - 1; currRow++)
            {
                for (int currCol = 1; currCol < matrix[currRow].Length; currCol++)
                {
                    int currSum = (matrix[currRow][currCol - 1] + matrix[currRow][currCol] +
                                  matrix[currRow + 1][currCol - 1] + matrix[currRow + 1][currCol]);

                    if (currSum > maxSum)
                    {
                        maxSum = currSum;
                        bestRow = currRow;
                        bestCol = currCol;
                    }
                }
            }

            for (int currRow = bestRow; currRow <= bestRow + 1; currRow++)
            {
                for (int currCol = bestCol - 1; currCol <= bestCol; currCol++)
                {
                    Console.Write($"{matrix[currRow][currCol]} ");
                }

                Console.WriteLine();
            }

            Console.WriteLine(maxSum);
        }
    }
}
