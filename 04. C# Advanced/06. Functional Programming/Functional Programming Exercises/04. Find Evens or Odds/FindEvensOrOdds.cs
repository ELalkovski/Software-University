using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Find_Evens_or_Odds
{
    public class FindEvensOrOdds
    {
        public static void Main()
        {
            var limits = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            var nums = new List<int>();

            for (int i = limits[0]; i <= limits[1]; i++)
            {
                nums.Add(i);
            }

            var command = Console.ReadLine();
            Predicate<int> even = (a) => { return a % 2 == 0; };
            Predicate<int> odd = (a) => { return a % 2 != 0; };
            
             
            if (command == "even")
            {
                Console.WriteLine(string.Join(" ", nums.FindAll(even)));
            }
            else
            {
                Console.WriteLine(string.Join(" ", nums.FindAll(odd)));
            }         
        }
    }
}
