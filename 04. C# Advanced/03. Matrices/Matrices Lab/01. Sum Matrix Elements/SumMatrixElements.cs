namespace _01.Sum_Matrix_Elements
{
    using System;
    using System.Linq;

    public class SumMatrixElements
    {
        public static void Main()
        {

            /*
             
             This program reads a matrix from console and prints:
                •	Count of rows
                •	Count of columns
                •	Sum of all matrix’s elements

             */

            var matrixSizes = Console.ReadLine()
                .Split(new []{", "}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var rows = matrixSizes[0];
            var cols = matrixSizes[1];

            var matrix = new int[rows][];
            var sum = 0;

            for (int currRow = 0; currRow < rows; currRow++)
            {
                var rowElements = Console.ReadLine()
                    .Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                matrix[currRow] = new int[cols];

                for (int currCol = 0; currCol < cols; currCol++)
                {
                    matrix[currRow][currCol] = rowElements[currCol];
                }

                sum += matrix[currRow].Sum();
            }

            Console.WriteLine(rows);
            Console.WriteLine(cols);
            Console.WriteLine(sum);
        }
    }
}
