using System.Collections.Generic;

namespace _03.Periodic_Table
{
    using System;

    public class PeriodicTable
    {
        public static void Main()
        {
            /*
             You are given an n number of chemical compounds. 
             This program keeps track of all chemical elements used in the compounds and at the end prints all unique ones in ascending order.
             */

            var loopLength = int.Parse(Console.ReadLine());
            var elementsSet = new SortedSet<string>();

            for (int i = 0; i < loopLength; i++)
            {
                var tokens = Console.ReadLine()
                    .Split(' ');

                foreach (var element in tokens)
                {
                    elementsSet.Add(element);
                }
            }

            Console.WriteLine(string.Join(" ", elementsSet));
        }
    }
}
