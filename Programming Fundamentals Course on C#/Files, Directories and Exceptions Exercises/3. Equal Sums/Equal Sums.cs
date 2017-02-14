using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace _3.Equal_Sums
{
    class EqualSums
    {
        public static void Main()
        {
            var inputStrings = File.ReadAllLines("Inputs.txt");

            foreach (var currentInput in inputStrings)
            {
                var currInputNums = currentInput
                    .Split(' ')
                    .Select(int.Parse)
                    .ToArray();


                var neededIndex = 0;

                for (int i = 0; i < currInputNums.Length; i++)
                {
                    var leftSum = 0;
                    var rightSum = 0;

                    for (int left = 0; left < i; left++)
                    {
                        leftSum += currInputNums[left];
                    }
                    for (int right = i + 1; right < currInputNums.Length; right++)
                    {
                        rightSum += currInputNums[right];
                    }

                    if (leftSum == rightSum)
                    {
                        neededIndex = i;
                        break;
                    }
                }
                if (neededIndex > 0)
                {
                    Console.WriteLine(neededIndex);
                    File.AppendAllText("output.txt", neededIndex.ToString()+ Environment.NewLine);
                }
                else if (currInputNums.Length == 1)
                {
                    neededIndex = 0;
                    Console.WriteLine(neededIndex);
                    File.AppendAllText("output.txt", neededIndex.ToString() + Environment.NewLine);
                }
                else
                {
                    Console.WriteLine("no");
                    File.AppendAllText("output.txt", "no" + Environment.NewLine);
                }
                
            }
        }
    }
}
