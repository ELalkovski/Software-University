namespace _09.List_of_Predicates
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ListOfPredicates
    {
        public static void Main()
        {
            int range = int.Parse(Console.ReadLine());

            List<int> nums = new List<int>();

            for (int i = 1; i <= range; i++)
            {
                nums.Add(i);
            }

            List<int> divisibleNums = Console.ReadLine()
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
