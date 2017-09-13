namespace _03._2x2_Squares_Matrix
{
    using System;
    using System.Linq;

    public class SquaresMatrix
    {
        public static void Main()
        {
            /*
             This program finds the count of 2 x 2 squares of equal chars in a matrix.
             */

            var matrixSizes = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            if (matrixSizes.Length < 2 || matrixSizes[0] < 2 || matrixSizes[1] < 2)
            {
                Console.WriteLine(0);
            }
            else
            {
                var rows = matrixSizes[0];
                var cols = matrixSizes[1];

                var matrix = new char[rows][];
                var squaresCount = 0;

                for (int currRow = 0; currRow < matrix.Length; currRow++)
                {
                    var elements = Console.ReadLine()
                        .Split(new [] {' '}, StringSplitOptions.RemoveEmptyEntries)
                        .Select(char.Parse)
                        .ToArray();

                    if (elements.Length != cols)
                    {
                        Console.WriteLine(0);
                        return;
                    }

                    matrix[currRow] = new char[cols];

                    for (int currCol = 0; currCol < matrix[currRow].Length; currCol++)
                    {
                        matrix[currRow][currCol] = elements[currCol];
                    }

                }

                for (int currRow = 0; currRow < matrix.Length - 1; currRow++)
                {
                    for (int currCol = 1; currCol < matrix[currRow].Length; currCol++)
                    {
                        if (matrix[currRow][currCol - 1] == matrix[currRow][currCol] &&
                            matrix[currRow][currCol - 1] == matrix[currRow + 1][currCol] &&
                            matrix[currRow][currCol - 1] == matrix[currRow + 1][currCol - 1])
                        {
                            squaresCount++;
                        }
                    }
                }

                Console.WriteLine(squaresCount);
            }
            
        }
    }
}
