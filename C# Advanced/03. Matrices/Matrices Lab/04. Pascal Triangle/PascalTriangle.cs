namespace _04.Pascal_Triangle
{
    using System;

    public class PascalTriangle
    {
        public static void Main()
        {
            /*
             This program recieves integer number and prints the pascal triangle for it.
             */

            var n = int.Parse(Console.ReadLine());

            var pascal = new long[n][];
            pascal[0] = new long[1];
            pascal[0][0] = 1;
            var cols = 2;

            for (int currRow = 1; currRow < n; currRow++)
            {
                
                pascal[currRow] = new long[cols];
                pascal[currRow][0] = 1;
                pascal[currRow][cols - 1] = 1;

                for (int currCol = 1; currCol < cols - 1; currCol++)
                {
                    pascal[currRow][currCol] = pascal[currRow - 1][currCol - 1] +
                                               pascal[currRow - 1][currCol];
                }
                cols++;
            }

            for (int currRow = 0; currRow < pascal.Length; currRow++)
            {
                for (int currCol = 0; currCol < pascal[currRow].Length; currCol++)
                {
                    Console.Write($"{pascal[currRow][currCol]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
