namespace _6.Fold_and_Sum
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class FoldAndSum
    {
        public static void Main()
        {
            var inputNums = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            Console.WriteLine(string.Join(" ", SplitIntoTwoRowsAndSumThem(inputNums)));
        }

        public static List<int> SplitIntoTwoRowsAndSumThem(List<int> inputNums)
        {
            int k = inputNums.Count / 4;

            List<int> secondRow = inputNums.Skip(k).Take(2 * k).ToList();
            List<int> firstRowLeft = inputNums.Take(k).ToList();

            firstRowLeft.Reverse();
            inputNums.Reverse();

            List<int> firstRowRight = inputNums.Take(k).ToList();
            List<int> firstRow = firstRowLeft.Concat(firstRowRight).ToList();

            List<int> sumRow = new List<int>();

            for (int i = 0; i < secondRow.Count; i++)
            {
                sumRow.Add(firstRow[i] + secondRow[i]);
            }

            return sumRow;
        }
    }
}
