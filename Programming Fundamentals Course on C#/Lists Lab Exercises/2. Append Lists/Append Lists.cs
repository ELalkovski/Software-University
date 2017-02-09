using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Append_Lists
{
    class Program
    {

        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split('|').ToList();
            input.Reverse();
            var resultsList = new List<string>();
            foreach (var item in input)
            {
                List<string> nums = item.Split(' ').ToList();

                foreach (var num in nums)
                {
                    if (num != "")
                    {
                        resultsList.Add(num);
                    }
                }
            }

            Console.WriteLine(string.Join(" ", resultsList));
        }
    }
}
