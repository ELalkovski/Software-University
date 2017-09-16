namespace _1.Most_Frequent_Number
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.IO;

    public class MostFrequentNum
    {
        public static void Main()
        {
            string[] inputLines = File.ReadAllLines("Input.txt");

            List<string> output = new List<string>();

            foreach (var line in inputLines)
            {
                int[] nums = line
                 .Split(' ')
                 .Select(int.Parse)
                 .ToArray();

                int frequence = 0;
                int bestNum = 0;

                for (int i = 0; i < nums.Length; i++)
                {
                    int currNum = nums[i];
                    int count = 0;

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
