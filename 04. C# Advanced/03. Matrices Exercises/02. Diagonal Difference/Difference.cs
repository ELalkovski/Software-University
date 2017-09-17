namespace _02.Diagonal_Difference
{
    using System;
    using System.Linq;

    public class Difference
    {
        public static void Main()
        {
            /*
             This program finds the difference between the sums of the square matrix diagonals (absolute value).
             */

            int rows = int.Parse(Console.ReadLine());
            int leftDiagonalSum = 0;
            int leftCounter = 0;
            int rightDiagonalSum = 0;
            

                int[] colElements = Console.ReadLine()
                    .Split(new []{' '}, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

            int rightCounter = colElements.Length - 1;

            for (int currRow = 0; currRow < rows; currRow++)
            {   
                leftDiagonalSum += colElements[leftCounter];
                leftCounter++;

                rightDiagonalSum += colElements[rightCounter];
                rightCounter--;

                if (currRow == rows - 1)
                {
                    break;
                }

                colElements = Console.ReadLine()
                    .Split(new [] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
            }

            Console.WriteLine(Math.Abs(leftDiagonalSum - rightDiagonalSum));
        }
    }
}
