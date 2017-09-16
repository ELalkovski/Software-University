namespace _6.Square_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SquareNumbers
    {
        public static void Main()
        {
            List<double> inputNums = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToList();

            Console.WriteLine(string.Join(" ", GetSquareRootNums(inputNums)));
        }

        private static List<double> GetSquareRootNums(List<double> inputNums)
        {
            List<double> squareNums = new List<double>();

            foreach (var currNum in inputNums)
            {
                if (Math.Sqrt(currNum) == (int)Math.Sqrt(currNum))
                {
                    squareNums.Add(currNum);
                }
            }

            squareNums.Sort((a, b) => b.CompareTo(a));

            return squareNums;
        }
    }
}
