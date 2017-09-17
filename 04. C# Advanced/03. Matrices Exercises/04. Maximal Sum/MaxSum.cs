namespace _04.Maximal_Sum
{
    using System;
    using System.Linq;

    public class MaxSum
    {
        public static void Main()
        {
            /*
             This program reads a rectangular integer matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements. 
             */

            int[] matrixSizes = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            if (matrixSizes.Length == 2)
            {
                int rows = matrixSizes[0];
                int cols = matrixSizes[1];

                if (rows >= 3 && cols >= 3)
                {
                    int[][] matrix = new int[rows][];

                    for (int currRow = 0; currRow < matrix.Length; currRow++)
                    {
                        int[] elements = Console.ReadLine()
                            .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                            .Select(int.Parse)
                            .ToArray();

                        if (elements.Length == cols)
                        {
                            matrix[currRow] = new int[cols];

                            for (int currCol = 0; currCol < matrix[currRow].Length; currCol++)
                            {
                                matrix[currRow][currCol] = elements[currCol];
                            }
                        }
                    }

                    int bestSum = int.MinValue;
                    int bestRow = 0;
                    int bestCol = 0;

                    for (int currRow = 0; currRow < matrix.Length - 2; currRow++)
                    {
                        for (int currCol = 0; currCol < matrix[currRow].Length - 2; currCol++)
                        {
                            int currSum = matrix[currRow][currCol] + matrix[currRow][currCol + 1] +
                                          matrix[currRow][currCol + 2] +
                                          matrix[currRow + 1][currCol] + matrix[currRow + 1][currCol + 1] +
                                          matrix[currRow + 1][currCol + 2] +
                                          matrix[currRow + 2][currCol] + matrix[currRow + 2][currCol + 1] +
                                          matrix[currRow + 2][currCol + 2];

                            if (currSum > bestSum)
                            {
                                bestSum = currSum;
                                bestRow = currRow;
                                bestCol = currCol;
                            }
                        }
                    }

                    Console.WriteLine($"Sum = {bestSum}");

                    for (int currRow = bestRow; currRow < bestRow + 3; currRow++)
                    {
                        for (int currCol = bestCol; currCol < bestCol + 3; currCol++)
                        {
                            Console.Write($"{matrix[currRow][currCol]} ");
                        }

                        Console.WriteLine();
                    }
                }
            }
        }
    }
}


