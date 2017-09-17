namespace _05.Rubik_s_Matrix
{
    using System;
    using System.Linq;

    public class Rubik
    {
        public static void Main()
        {
            /*
             •	On the first line, the program recieves the integers R and C, separated by a space.
             •	On the second line, recieves an integer N, indicating the number of commands to follow
             •	On the next N lines, recieves commands in format {row/col} {direction} {moves}

            if command is "up" moves the matrix given colIndex up by every row, "down" do it backwards.
            if command is "left" moves the matrix given rowIndex by every col, "right" do it backwards.
            At the end, the program rearanges the matrix at it's previous state.
             */

            int[] matrixSizes = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int rows = matrixSizes[0];
            int cols = matrixSizes[1];
            
            int[][] matrix = new int[rows][];
            int elementCounter = 1;

            for (int currRow = 0; currRow < rows; currRow++)
            {
                matrix[currRow] = new int[cols];

                for (int currCol = 0; currCol < cols; currCol++)
                {
                    matrix[currRow][currCol] = elementCounter;
                    elementCounter++;
                }
            }

            int numberOfCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] currCommand = Console.ReadLine()
                    .Split(new [] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                int position = int.Parse(currCommand[0]);
                string direction = currCommand[1];
                int countMoves = int.Parse(currCommand[2]);

                switch (direction)
                {
                    case "up":
                        MoveUpDown(matrix, position, countMoves);
                        break;
                    case "down":
                        MoveUpDown(matrix, position, matrix.Length - countMoves % matrix.Length);
                        break;
                    case "left":
                        MoveLeftRight(matrix, position, countMoves);
                        break;
                    case "right":
                        MoveLeftRight(matrix, position, matrix[0].Length - countMoves % matrix[0].Length);
                        break;
                }
            }

            int counter = 1;

            for (int currRow = 0; currRow < rows; currRow++)
            {
                for (int currCol = 0; currCol < cols; currCol++)
                {
                    if (counter == matrix[currRow][currCol])
                    {
                        Console.WriteLine("No swap required");
                    }
                    else
                    {
                        for (int r = 0; r < rows; r++)
                        {
                            for (int c = 0; c < cols; c++)
                            {
                                int currNum = matrix[r][c];

                                if (counter == currNum)
                                {
                                    int temp = matrix[r][c];
                                    matrix[r][c] = matrix[currRow][currCol];
                                    matrix[currRow][currCol] = temp;

                                    Console.WriteLine($"Swap ({currRow}, {currCol}) with ({r}, {c})");
                                    break;
                                }
                            }
                        }
                    }

                    counter++;
                }
            }
        }

        private static void MoveLeftRight(int[][] matrix, int position, int countMoves)
        {
            int[] temp = new int[matrix[0].Length];

            for (int currCol = 0; currCol < matrix[0].Length; currCol++)
            {
                temp[currCol] = matrix[position][(currCol + countMoves) % matrix[0].Length];
            }

            for (int currCol = 0; currCol < matrix[0].Length; currCol++)
            {
                matrix[position][currCol] = temp[currCol];
            }
        }

        private static void MoveUpDown(int[][] matrix, int position, int countMoves)
        {
            int[] temp = new int[matrix.Length];

            for (int currRow = 0; currRow < matrix.Length; currRow++)
            {
                temp[currRow] = matrix[(currRow + countMoves) % matrix.Length][position];
            }

            for (int currRow = 0; currRow < matrix.Length; currRow++)
            {
                matrix[currRow][position] = temp[currRow];
            }
        }
    }
}