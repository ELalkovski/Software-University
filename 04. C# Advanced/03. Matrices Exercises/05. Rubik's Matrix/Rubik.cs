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

            var matrixSizes = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            var rows = matrixSizes[0];
            var cols = matrixSizes[1];


            var matrix = new int[rows][];
            var elementCounter = 1;

            for (int currRow = 0; currRow < rows; currRow++)
            {
                matrix[currRow] = new int[cols];

                for (int currCol = 0; currCol < cols; currCol++)
                {
                    matrix[currRow][currCol] = elementCounter;
                    elementCounter++;
                }
            }

            var numberOfCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCommands; i++)
            {
                var currCommand = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                var position = int.Parse(currCommand[0]);
                var direction = currCommand[1];
                var countMoves = int.Parse(currCommand[2]);
                var temp = 0;

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

            var counter = 1;
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
                                var currNum = matrix[r][c];
                                if (counter == currNum)
                                {
                                    var temp = matrix[r][c];
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
            var temp = new int[matrix[0].Length];

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
            var temp = new int[matrix.Length];

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