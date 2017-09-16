namespace _7.Count_Numbers
{
    using System;
    using System.Collections.Generic;

    public class CountNumbers
    {
        public static void Main()
        {
            string[] nums = Console.ReadLine().Split(' ');
            SortedDictionary<int, int> counts = new SortedDictionary<int, int>();

            foreach (var num in nums)
            {
                int parsedNum = int.Parse(num);

                if (!counts.ContainsKey(parsedNum))
                {
                    counts[parsedNum] = 0;
                   
                }

                counts[parsedNum]++;
            }

            foreach (int num in counts.Keys)
            {
                Console.WriteLine("{0} -> {1}",num, counts[num]);
            }
        }
    }
}
