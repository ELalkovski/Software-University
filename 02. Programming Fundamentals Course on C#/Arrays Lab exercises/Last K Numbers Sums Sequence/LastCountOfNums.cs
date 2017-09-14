namespace Last_K_Numbers_Sums_Sequence
{
    using System;

    public class LastCountOfNums
    {
        public static void Main()
        {
            int numsCount = int.Parse(Console.ReadLine());
            int pairCount = int.Parse(Console.ReadLine());

            long[] array = new long[numsCount];
            array[0] = 1;

            for (int i = 0; i < numsCount; i++)
            {
                long sum = 0;

                for (int prev = i - pairCount; prev <= i - 1; prev++)
                {
                    if (prev >= 0)
                    {
                        sum += array[prev];
                        array[i] = sum;
                    }
                }
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
