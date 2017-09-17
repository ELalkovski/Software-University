namespace _07.Lego_Blocks
{
    using System;
    using System.Linq;

    public class LegoBlocks
    {
        public static void Main()
        {
            /*
             This program recieves two jagged arrays. Each array represents a Lego block containing integers. 
             After that it reverses the second jagged array and then checks if it would fit perfectly in the first jagged array. 
             */

            int rows = int.Parse(Console.ReadLine());

            int[][] firstMatrix = new int[rows][];
            int[][] secondMatrix = new int[rows][];

            for (int currRow = 0; currRow < rows; currRow++)
            {
                int[] elements = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                firstMatrix[currRow] = new int[elements.Length];

                for (int currCol = 0; currCol < elements.Length; currCol++)
                {
                    firstMatrix[currRow][currCol] = elements[currCol];
                }
            }

            for (int currRow = 0; currRow < rows; currRow++)
            {
                int[] elements = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                secondMatrix[currRow] = new int[elements.Length];

                for (int currCol = 0; currCol < elements.Length; currCol++)
                {
                    secondMatrix[currRow][currCol] = elements[currCol];
                }
            }

            int[][] combinedMatrix = new int[rows][];
            int totalCols = 0;

            for (int currRow = 0; currRow < rows; currRow++)
            {
                combinedMatrix[currRow] = new int[firstMatrix[currRow].Length + secondMatrix[currRow].Length];

                for (int mFirstCol = 0; mFirstCol < firstMatrix[currRow].Length; mFirstCol++)
                {
                    combinedMatrix[currRow][mFirstCol] = firstMatrix[currRow][mFirstCol];
                }

                int reversedIndex = secondMatrix[currRow].Length - 1;

                for (int mSecondCol = 0; mSecondCol < secondMatrix[currRow].Length; mSecondCol++)
                {
                    int continueIndex = firstMatrix[currRow].Length + mSecondCol;
                    combinedMatrix[currRow][continueIndex] = secondMatrix[currRow][reversedIndex];
                    reversedIndex--;
                }

                totalCols += combinedMatrix[currRow].Length;
            }

            if (totalCols % combinedMatrix[0].Length == 0)
            {
                for (int currRow = 0; currRow < combinedMatrix.Length; currRow++)
                {
                    Console.Write("[");
                    Console.Write(string.Join(", ", combinedMatrix[currRow]));
                    Console.Write("]");
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine($"The total number of cells is: {totalCols}");
            }
        }
    }
}
