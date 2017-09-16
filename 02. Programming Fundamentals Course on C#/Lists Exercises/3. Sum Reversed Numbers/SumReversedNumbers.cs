namespace _4.Sum_Reversed_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SumReversedNumbers
    {
        public static void Main()
        {
            List<string> inputNums = Console.ReadLine()
                .Split(' ')
                .ToList();

            Console.WriteLine(GetReversedSum(inputNums));
        }

        private static int GetReversedSum(List<string> inputNums)
        {
            int sum = 0;
            string reversedNum = "";


            for (int i = 0; i < inputNums.Count; i++)
            {
                IEnumerable<char> currNum = inputNums[i].Reverse();
                reversedNum = string.Join("", currNum);
                int currentNum = int.Parse(reversedNum);
                sum += currentNum;
            }

            return sum;
        }
    }
}
