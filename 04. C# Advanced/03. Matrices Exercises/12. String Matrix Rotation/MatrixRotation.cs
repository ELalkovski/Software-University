namespace _12.String_Matrix_Rotation
{
    using System;
    using System.Collections.Generic;

    public class MatrixRotation
    {
        public static void Main()
        {
            string[] rotationDirection = Console.ReadLine()
                .Split(new []{'(', ')'}, StringSplitOptions.RemoveEmptyEntries);
            string matrixWords = Console.ReadLine();

            int rotationDegrees = int.Parse(rotationDirection[1]);
            List<string> wordsList = new List<string>();
            int rows = 0;
            int cols = 0;

            while (matrixWords != "END")
            {
                if (matrixWords.Length > cols)
                {
                    cols = matrixWords.Length;
                }

                rows++;
                wordsList.Add(matrixWords);
                matrixWords = Console.ReadLine();
            }

            char[][] matrix = new char[rows][];

            for (int currRow = 0; currRow < wordsList.Count; currRow++)
            {
                string currWord = wordsList[currRow];
                matrix[currRow] = new char[cols];

                for (int currCol = 0; currCol < currWord.Length; currCol++)
                {
                    matrix[currRow][currCol] = currWord[currCol];
                }

                if (currWord.Length < cols)
                {
                    for (int currCol = currWord.Length; currCol < cols; currCol++)
                    {
                        matrix[currRow][currCol] = ' ';
                    }
                }
            }

            int rotationCount = rotationDegrees / 90;

            for (int i = 0; i < rotationCount; i++)
            {
                matrix = RotateMatrix(matrix, rows, cols);
                int temp = rows;
                rows = cols;
                cols = temp;
            }

            PrintResult(matrix);
        }

        private static void PrintResult(char[][] matrix)
        {
            for (int row = 0; row < matrix.Length; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    Console.Write(matrix[row][col]);
                }

                Console.WriteLine();
            }
        }

        private static char[][] RotateMatrix(char[][] matrix, int rows, int cols)
        {
            char[][] rotatedMatrix = new char[cols][];
            int colsCounter = 0;

            for (int newMatrixRow = 0; newMatrixRow < cols; newMatrixRow++)
            {
                rotatedMatrix[newMatrixRow] = new char[rows];

                for (int newMatrixCol = rows - 1; newMatrixCol >= 0; newMatrixCol--)
                {
                    rotatedMatrix[newMatrixRow][colsCounter] = matrix[newMatrixCol][newMatrixRow];
                    colsCounter++;
                }

                colsCounter = 0;
            }

            return rotatedMatrix;
        }
    }
}
