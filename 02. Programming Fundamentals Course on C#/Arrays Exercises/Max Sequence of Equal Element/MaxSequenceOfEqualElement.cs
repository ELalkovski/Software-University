namespace Max_Sequence_of_Equal_Element
{
    using System;
    using System.Linq;

    public class MaxSequenceOfEqualElement
    {
        public static void Main()
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            GetBestSequence(array);
        }

        public static void GetBestSequence(int[] array)
        {
            int start = 0;
            int count = 0;
            int bestCount = 0;

            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] == array[i + 1])
                {
                    count++;

                    if (count > bestCount)
                    {
                        start = i - count;
                        bestCount = count;
                    }
                }

                else
                {
                    count = 0;
                }
            }

            for (int i = start + 1; i <= start + bestCount + 1; i++)
            {
                Console.Write("{0} ", array[i]);
            }

            Console.WriteLine();
        }
    }
}
