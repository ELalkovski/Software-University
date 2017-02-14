using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace _1.Most_Frequent_Number
{
    class MostFrequentNum
    {
        public static void Main()
        {
            var inputLines = File.ReadAllLines("Input.txt");

            var output = new List<string>();

            foreach (var line in inputLines)
            {
               var nums = line
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

                var frequence = 0;
                var bestNum = 0;

                for (int i = 0; i < nums.Length; i++)
                {
                    var currNum = nums[i];
                    var count = 0;

                    for (int j = i; j < nums.Length; j++)
                    {
                        if (currNum == nums[j])
                        {
                            count++;
                        }
                    }
                    if (count > frequence)
                    {
                        bestNum = currNum;
                        frequence = count;
                    }
                }
                Console.WriteLine(bestNum);
                output.Add(bestNum.ToString());
            }
            
            File.AppendAllLines("output.txt", output);
 
        }
    }
}
