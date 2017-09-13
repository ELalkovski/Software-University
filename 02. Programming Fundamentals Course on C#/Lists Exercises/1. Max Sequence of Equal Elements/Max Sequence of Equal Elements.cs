
namespace _1.Max_Sequence_of_Equal_Elements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class MaxSequenceOfEqualNums
    {
        public static List<int> GetLongestSequence(List<int> inputNums)
        {
            List<int> currentSequence = new List<int>();
            List<int> longestSequence = new List<int>();

            currentSequence.Add(inputNums[0]);

            for (int i = 1; i < inputNums.Count; i++)
            {
                if (inputNums[i] == currentSequence[0])
                {
                    currentSequence.Add(inputNums[i]);
                }
                else
                {
                    if (currentSequence.Count > longestSequence.Count)
                    {
                        longestSequence.Clear();
                        longestSequence.AddRange(currentSequence);
                    }

                    currentSequence.Clear();
                    currentSequence.Add(inputNums[i]);
                }
            }

            if (currentSequence.Count > longestSequence.Count)
            {
                longestSequence.Clear();
                longestSequence.AddRange(currentSequence);
            }

            return longestSequence;
        }

        static void Main(string[] args)
        {
            var inputNums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            Console.WriteLine(string.Join(" ", GetLongestSequence(inputNums)));
        }
    }
}
