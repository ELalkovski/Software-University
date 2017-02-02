namespace Extract_Middle_1__2_or_3_Elements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Extract
    {
        public static List<int> GetEvenMidNums (List<int> inputNums)
        {
            var evenMiddleNums = new List<int>();

            for (int i = inputNums.Count / 2 - 1; i <= inputNums.Count / 2; i++)
            {
                evenMiddleNums.Add(inputNums[i]);
            }

            return evenMiddleNums;
        }

        public static List<int> GetOddMidNums(List<int> inputNums)
        {
            var oddMiddleNums = new List<int>();

            for (int i = inputNums.Count / 2 - 1; i <= inputNums.Count / 2 + 1; i++)
            {
                oddMiddleNums.Add(inputNums[i]);
            }

            return oddMiddleNums;
        }

        static void Main()
        {
            var inputNums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            bool even = inputNums.Count % 2 == 0;

            if (even)
            {
                Console.Write("{");
                Console.Write(string.Join(", ",GetEvenMidNums(inputNums)));
                Console.Write("}");
                Console.WriteLine();
            }
            else if (inputNums.Count == 1)
            {
                Console.Write("{");
                Console.Write(inputNums[0]);
                Console.Write("}");
                Console.WriteLine();
            }
            else
            {
                Console.Write("{");
                Console.Write(string.Join(", ", GetOddMidNums(inputNums)));
                Console.Write("}");
                Console.WriteLine();
            }
        }
    }
}
