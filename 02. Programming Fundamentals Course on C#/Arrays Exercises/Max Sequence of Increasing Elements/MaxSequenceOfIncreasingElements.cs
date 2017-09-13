namespace Max_Sequence_of_Equal_Element
{
    using System;
    using System.Linq;

    public class MaxSequenceOfIncreasingElements
    {
        public static void Main()
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int l = array.Length;

            MaxIncSequence(array, l);
        }

        public static void MaxIncSequence(int[] array, int l)
        {
            int count = 0;
            int start = 0;
            int bestCount = 0;
            int bestStart = 0;

            for (int i = 1; i < l; i++)
            {
                if (array[i] - array[i - 1] >= 1)
                {
                    count++;
                    start = i - count;

                    if (count > bestCount)
                    {
                        bestCount = count;
                        bestStart = start;
                    }
                }
                else
                {
                    count = 0;
                }
            }

            for (int iWrite = bestStart; iWrite <= (bestStart + bestCount); iWrite++)
            {
                Console.Write(array[iWrite] + " ");
            }

            Console.WriteLine();
        }
    }
}



