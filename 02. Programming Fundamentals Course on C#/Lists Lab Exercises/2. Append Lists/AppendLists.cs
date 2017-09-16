namespace _2.Append_Lists
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class AppendLists
    {
        public static void Main()
        {
            List<string> input = Console.ReadLine()
                .Split('|')
                .ToList();
            input.Reverse();

            List<string> resultsList = new List<string>();

            foreach (string item in input)
            {
                List<string> nums = item
                    .Split(' ')
                    .ToList();

                foreach (string num in nums)
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
