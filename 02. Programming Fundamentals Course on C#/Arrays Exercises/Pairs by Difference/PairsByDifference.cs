namespace Pairs_by_Difference
{
    using System;
    using System.Linq;

    public class PairsByDifference
    {
        static void Main()
        {
            int[] arrayInput = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int differenceInput = int.Parse(Console.ReadLine());
            
            Console.WriteLine(GetSumPairsNumber(arrayInput, differenceInput));
        }

        public static int GetSumPairsNumber(int[] arrayInput, int differenceInput)
        {
            int countSumPairs = 0;

            for (int i = 0; i < arrayInput.Length; i++)
            {
                for (int j = i + 1; j < arrayInput.Length; j++)
                {
                    if (Math.Abs(arrayInput[i] - arrayInput[j]) == differenceInput)
                    {
                        countSumPairs++;
                    }
                }
            }

            return countSumPairs;
        }
    }
}
