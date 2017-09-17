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

            string[] setsLength = Console.ReadLine()
                .Trim()
                .Split(' ')
                .ToArray();
            int firstCollectionNumbers = int.Parse(setsLength[0]);
            int secondCollectionNumbers = int.Parse(setsLength[1]);
            HashSet<int> firstCollection = new HashSet<int>();
            HashSet<int> secondCollection = new HashSet<int>();

            for (int i = 0; i < (firstCollectionNumbers + secondCollectionNumbers); i++)
            {
                var currNum = int.Parse(Console.ReadLine());

                if (i < firstCollectionNumbers)
                {
                    firstCollection.Add(currNum);
                }
                else
                {
                    secondCollection.Add(currNum);
                }
            }

            int loopLength = Math.Max(firstCollection.Count, secondCollection.Count);
            int[] firstArr = firstCollection.ToArray();
            HashSet<int> repeatingElements = new HashSet<int>();

            for (int i = 0; i < loopLength; i++)
            {
                int currNum = firstArr[i];

                if (secondCollection.Contains(currNum))
                {
                    repeatingElements.Add(currNum);
                }
            }

            Console.WriteLine(string.Join(" ", repeatingElements));
        }
    }
}
