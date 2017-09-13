namespace Equal_Sums
{
    using System;
    using System.Linq;

    public class EqualSums
    {
        public static void Main()
        {
            int[] inputArrayNums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            if (GetSearchedIndex(inputArrayNums) != -1)
            {
                Console.WriteLine(GetSearchedIndex(inputArrayNums));
            }

            else
            {
                Console.WriteLine("no");
            }
        }

        public static int GetSearchedIndex(int[] inputArrayNums)
        {
            int numIndex = -1;
            int leftSum = 0;
            int rightSum = 0;

            for (int i = 0; i < inputArrayNums.Length; i++)
            {
                leftSum = 0;
                rightSum = 0;

                for (int left = 0; left < i; left++)
                {
                    leftSum += inputArrayNums[left];
                }

                for (int right = i + 1; right < inputArrayNums.Length; right++)
                {
                    rightSum += inputArrayNums[right];
                }

                if (leftSum == rightSum)
                {
                    numIndex = i;
                    break;
                }
            }

            return numIndex;
        }
    }
}
