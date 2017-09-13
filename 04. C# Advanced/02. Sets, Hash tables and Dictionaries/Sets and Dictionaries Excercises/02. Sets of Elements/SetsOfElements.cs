using System.Xml.Serialization;

namespace _02.Sets_of_Elements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SetsOfElements
    {
        public static void Main()
        {
            /*
             This program recieves, on the first line, the length of two sets N and M. 
             On the next N + M lines there are N numbers that are in the first set and M numbers that are in the second one. 
             Finaly it finds all non-repeating elements that appear in both of them, and prints them at the console.
             */

            var setsLength = Console.ReadLine()
                .Trim()
                .Split(' ')
                .ToArray();
            var n = int.Parse(setsLength[0]);
            var m = int.Parse(setsLength[1]);
            var firstSet = new HashSet<int>();
            var secondSet = new HashSet<int>();

            for (int i = 0; i < (n + m); i++)
            {
                var currNum = int.Parse(Console.ReadLine());

                if (i < n)
                {
                    firstSet.Add(currNum);
                }
                else
                {
                    secondSet.Add(currNum);
                }
            }

            var loopLength = Math.Max(firstSet.Count, secondSet.Count);

            var firstArr = firstSet.ToArray();
            var repeatingElements = new HashSet<int>();

            for (int i = 0; i < loopLength; i++)
            {
                var currNum = firstArr[i];
                if (secondSet.Contains(currNum))
                {
                    repeatingElements.Add(currNum);
                }
                
            }
            Console.WriteLine(string.Join(" ", repeatingElements));
        }
    }
}
