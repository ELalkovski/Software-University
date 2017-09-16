namespace _1.Count_Real_Numbers
{
    using System;
    using System.Collections.Generic;

    public class CountRealNumbers
    {
        public static void Main()
        {
            string[] inputNums = Console.ReadLine().Split(' ');
            SortedDictionary<double, int> counts = new SortedDictionary<double, int>();

            PrintRealNumbersCount(inputNums, counts);
        }

        public static void PrintRealNumbersCount(string[] inputNums, SortedDictionary<double, int> counts)
        {
            foreach (var num in inputNums)
            {
                var parsedNum = double.Parse(num);

                if (!counts.ContainsKey(parsedNum))
                {
                    counts[parsedNum] = 0;
                }

                counts[parsedNum]++;
            }

            foreach (var num in counts.Keys)
            {
                Console.WriteLine("{0} -> {1}", num, counts[num]);
            }
        }
    }
}
