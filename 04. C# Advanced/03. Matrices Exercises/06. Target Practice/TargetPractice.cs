namespace _06.Target_Practice
{
    using System;
    using System.Linq;

    public class TargetPractice
    {
        public static void Main()
        {
            var matrixSizes = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            var rows = matrixSizes[0];
            var cols = matrixSizes[1];

            var matrix = new char[rows][];
            var snake = Console.ReadLine();

            FillMatrix(matrix, snake, cols);          

            var impactTokens = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            var impactRow = impactTokens[0];
            var impactCol = impactTokens[1];
            var impactRadius = impactTokens[2];

            KillSnakes(impactRow, impactCol, impactRadius, matrix);
            RearangeMatrix(matrix);
            PrintFinalMatrix(matrix);
        }

        private static void PrintFinalMatrix(char[][] matrix)
        {
            for (int currRow = 0; currRow < matrix.Length; currRow++)
            {
                for (int currCol = 0; currCol < matrix[currRow].Length; currCol++)
                {
                    Console.Write(matrix[currRow][currCol]);
                }
                Console.WriteLine();
            }
        }

        private static void RearangeMatrix(char[][] matrix)
        {
            for (int currRow = 0; currRow < matrix.Length - 1; currRow++)
            {
                for (int currCol = 0; currCol < matrix[currRow].Length; currCol++)
                {
                    var currElement = matrix[currRow][currCol];
                    var downElement = matrix[currRow + 1][currCol];

                    if (currElement != ' ' && downElement == ' ')
                    {
                        matrix[currRow + 1][currCol] = currElement;
                        matrix[currRow][currCol] = ' ';
                        currRow = 0;
                        currCol = -1;
                    }
                }
            }
        }

        private static void KillSnakes(int impactRow, int impactCol, int impactRadius, char[][] matrix)
        {
            for (int currRow = 0; currRow < matrix.Length; currRow++)
            {
                for (int currCol = 0; currCol < matrix[currRow].Length; currCol++)
                {
                    var distance = Math.Sqrt(Math.Pow(currRow - impactRow, 2) + Math.Pow(currCol - impactCol, 2));

                    if (distance <= impactRadius)
                    {
                        matrix[currRow][currCol] = ' ';
                    }
                }
            }
        }

        private static void FillMatrix(char[][] matrix, string snake, int cols)
        {
            var snakeIndex = 0;
            var zigZagCounter = 1;

            for (int currRow = matrix.Length - 1; currRow >= 0; currRow--)
            {
                matrix[currRow] = new char[cols];

                if (zigZagCounter % 2 != 0)
                {
                    for (int currCol = matrix[currRow].Length - 1; currCol >= 0; currCol--)
                    {
                        if (snakeIndex == snake.Length)
                        {
                            snakeIndex = 0;
                        }

                        matrix[currRow][currCol] = snake[snakeIndex];
                        snakeIndex++;
                    }
                }
                else
                {
                    for (int currCol = 0; currCol < matrix[currRow].Length; currCol++)
                    {
                        if (snakeIndex == snake.Length)
                        {
                            snakeIndex = 0;
                        }

                        matrix[currRow][currCol] = snake[snakeIndex];
                        snakeIndex++;
                    }
                }
                zigZagCounter++;
            }
        }
    }
}
