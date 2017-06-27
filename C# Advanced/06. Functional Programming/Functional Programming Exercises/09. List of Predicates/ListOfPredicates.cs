using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.List_of_Predicates
{
    public class ListOfPredicates
    {
        public static void Main()
        {
            var range = int.Parse(Console.ReadLine());
            var nums = new List<int>();

            for (int i = 1; i <= range; i++)
            {
                nums.Add(i);
            }

            var divisibleNums = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            bool isTrue = false;

            foreach (var num in nums)
            {
                foreach (var divisible in divisibleNums)
                {
                    if (num % divisible != 0)
                    {
                        isTrue = false;
                        break;
                    }

                    isTrue = true;
                }

                if (isTrue)
                {
                    Console.Write("{0} ", num);
                }
            }

        }
    }
}
