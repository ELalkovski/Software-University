namespace _1.Remove_Negatives_and_Reverse
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class RemoveNegativesReverse
    {
        public static void Main()
        {
            List<int> list = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            PrintTreatedList(list);
        }

        private static void PrintTreatedList(List<int> list)
        {
            list.RemoveAll(x => x < 0);
            list.Reverse();

            if (list.Count > 0)
            {
                foreach (var currNum in list)
                {
                    Console.Write("{0} ", currNum);
                }
            }
            else
            {
                Console.WriteLine("empty");
            }
        }
    }
}
