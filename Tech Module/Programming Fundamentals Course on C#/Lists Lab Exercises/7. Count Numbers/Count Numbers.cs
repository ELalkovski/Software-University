using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Count_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nums = Console.ReadLine().Split(' ');
            var counts = new SortedDictionary<int, int>();

            foreach (var num in nums)
            {
                int parsedNum = int.Parse(num);

                if (!counts.ContainsKey(parsedNum))
                {
                    counts[parsedNum] = 0;
                   
                }
                counts[parsedNum]++;
            }

            foreach (var num in counts.Keys)
            {
                Console.WriteLine("{0} -> {1}",num, counts[num]);
            }
        }
    }
}
