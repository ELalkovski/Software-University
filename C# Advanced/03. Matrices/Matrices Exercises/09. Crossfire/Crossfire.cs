namespace _09.Crossfire
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Crossfire
    {
        public static void Main()
        {
            /*
             This program receives two integers which represent the dimensions of a matrix. 
             Then, fills the matrix with increasing integers starting from 1, and continuing on every row.
             The program also receives several commands in the form of 3 integers separated by a space. 
             Those 3 integers represents a row in the matrix, a column and a radius. 
             After every command destroys the cells which correspond to those arguments cross-like.             
             The input ends when the command “Nuke it from orbit” is recieved.

             */
            var dimensions = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            var rows = dimensions[0];
            var cols = dimensions[1];

            var matrix = FillMatrix(rows, cols);

            var inputParams = Console.ReadLine();

            while (inputParams != "Nuke it from orbit")
            {
                var coordinates = inputParams
                    .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                var impactRow = coordinates[0];
                var impactCol = coordinates[1];
                var radius = coordinates[2];
                

                for (int currRow = impactRow - radius; currRow <= impactRow + radius; currRow++)
                {
                    if (IsInMatrix(matrix, currRow, impactCol))
                    {
                        matrix[currRow][impactCol] = -1;
                    }
                }

                for (int currCol = impactCol - radius; currCol <= impactCol + radius; currCol++)
                {
                    if (IsInMatrix(matrix, impactRow, currCol))
                    {
                        matrix[impactRow][currCol] = -1;
                    }
                }
                DestroyCells(matrix);

                inputParams = Console.ReadLine();
            }

            PrintFinalMatrix(matrix);
        }

        private static void PrintFinalMatrix(List<List<int>> matrix)
        {
            for (int currRow = 0; currRow < matrix.Count; currRow++)
            {
                Console.WriteLine(string.Join(" ", matrix[currRow]));
            }
        }

        private static void DestroyCells(List<List<int>> matrix)
        {

            for (int currRow = matrix.Count - 1; currRow >= 0; currRow--)
            {
                for (int currCol = matrix[currRow].Count - 1; currCol >= 0; currCol--)
                {
                    if (matrix[currRow][currCol] == -1)
                    {
                        matrix[currRow].RemoveAt(currCol);
                    }
                    
                }
                if (matrix[currRow].Count == 0)
                {
                    matrix.RemoveAt(currRow);   
                }
            }
        }

        private static bool IsInMatrix(List<List<int>> matrix, int currRow, int impactCol)
        {
            if (currRow >= 0 && currRow < matrix.Count &&
                impactCol >= 0 && impactCol < matrix[currRow].Count)
            {
                return true;
            }

            return false;
        }


        private static List<List<int>> FillMatrix(int rows, int cols)
        {
            var matrix = new List<List<int>>();
            var element = 1;

            for (int curRow = 0; curRow < rows; curRow++)
            {
                var row = new List<int>();
                matrix.Add(row);

                for (int currCol = 0; currCol < cols; currCol++)
                {
                    matrix[curRow].Add(element);
                    element++;
                }
            }

            return matrix;
        }
    }
}
