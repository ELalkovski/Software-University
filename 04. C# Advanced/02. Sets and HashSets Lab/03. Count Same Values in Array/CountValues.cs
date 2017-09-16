namespace _03.Count_Same_Values_in_Array
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CountValues
    {
        public static void Main()
        {
            /*
                This program counts, in a given array of double values, the number of occurrences of each value. 
             */

            var inputArr = Console.ReadLine()
                .Trim()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();

            var dict = new SortedDictionary<double, int>();

            for (int i = 0; i < inputArr.Length; i++)
            {
                if (dict.ContainsKey(inputArr[i]))
                {
                    dict[inputArr[i]]++;
                }
                else
                {
                     dict[inputArr[i]] = 1;
                }
               
            }

            foreach (var entry in dict)
            {
                Console.WriteLine($"{entry.Key} - {entry.Value} times");
            }
        }
    }
}
