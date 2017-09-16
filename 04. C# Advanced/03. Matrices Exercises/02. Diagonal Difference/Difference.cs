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

            var rows = int.Parse(Console.ReadLine());
            var leftDiagonalSum = 0;
            var leftCounter = 0;
            var rightDiagonalSum = 0;
            

                var colElements = Console.ReadLine()
                    .Split(new char[]{' '}, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

            var rightCounter = colElements.Length - 1;

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
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
            }

            Console.WriteLine(Math.Abs(leftDiagonalSum - rightDiagonalSum));
        }
    }
}
