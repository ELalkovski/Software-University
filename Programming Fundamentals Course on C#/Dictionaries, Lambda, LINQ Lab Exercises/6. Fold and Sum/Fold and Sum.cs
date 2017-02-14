namespace _6.Fold_and_Sum
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class FoldAndSum
    {
        public static List<int> SplitIntoTwoRowsAndSumThem(List<int> inputNums)
        {
            var k = inputNums.Count / 4;

            var secondRow = inputNums.Skip(k).Take(2 * k).ToList();
            var firstRowLeft = inputNums.Take(k).ToList();
            firstRowLeft.Reverse();
            inputNums.Reverse();
            var firstRowRight = inputNums.Take(k).ToList();
            var firstRow = firstRowLeft.Concat(firstRowRight).ToList();

            var sumRow = new List<int>();

            for (int i = 0; i < secondRow.Count; i++)
            {
                sumRow.Add(firstRow[i] + secondRow[i]);
            }

            return sumRow;
        }

        public static void Main()
        {
            var inputNums = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            Console.WriteLine(string.Join(" ", SplitIntoTwoRowsAndSumThem(inputNums)));
        }
    }
}
