namespace Fold_and_Sum
{
    using System;
    using System.Linq;

    public class FoldAndSum
    {
        public static void Main()
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int k = (array.Length) / 4;

            int[] firstRow = new int[k * 2];
            int[] secondRow = new int[k * 2];

            ReverseAndCreateFirstRowOfArray(array, firstRow);
            CreateSecondRow(array, secondRow);

            SumTwoRowsAndPrintResult(firstRow, secondRow);
            Console.WriteLine();
        }

        public static void ReverseAndCreateFirstRowOfArray(int[] array, int[] firstRow)
        {
            int k = (array.Length) / 4;

            for (int reverseNums = 0; reverseNums < k; reverseNums++)
            {
                firstRow[reverseNums] = array[k - 1 - reverseNums];
            }

            int countForLastDigits = array.Length - 1;

            for (int reverseNums = k; reverseNums < (2 * k); reverseNums++)
            {
                firstRow[reverseNums] = array[countForLastDigits];
                countForLastDigits--;
            }
        }

        public static void CreateSecondRow(int[] array, int[] secondRow)
        {
            int k = (array.Length) / 4;
            int countIndex = 0 + k;

            for (int centerOfArray = 0; centerOfArray < 2 * k; centerOfArray++)
            {
                secondRow[centerOfArray] = array[countIndex];
                countIndex++;
            }
        }

        public static void SumTwoRowsAndPrintResult(int[] firstRow, int[] secondRow)
        {
            int[] sumOfArrays = new int[firstRow.Length];

            for (int i = 0; i < firstRow.Length; i++)
            {
                sumOfArrays[i] = firstRow[i] + secondRow[i];
            }

            for (int i = 0; i < sumOfArrays.Length; i++)
            {
                Console.Write("{0} ", sumOfArrays[i]);
            }
        }
    }
}
