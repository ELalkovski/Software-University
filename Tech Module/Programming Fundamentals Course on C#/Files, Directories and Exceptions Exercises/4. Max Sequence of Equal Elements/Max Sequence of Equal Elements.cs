using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace _4.Max_Sequence_of_Equal_Elements
{
    class MaxSequence
    {
        public static void Main()
        {
            var inputStrings = File.ReadAllLines("Inputs.txt");

            foreach (var input in inputStrings)
            {
                var numsInput = input
                    .Split(' ')
                    .Select(int.Parse)
                    .ToArray();

                var start = 0;
                var count = 0;
                var bestCount = 0;

                for (int i = 0; i < numsInput.Length - 1; i++)
                {
                    

                    if (numsInput[i] == numsInput[i + 1])
                    {
                        count++;

                        if (count > bestCount)
                        {
                            start = i - count;
                            bestCount = count;
                        }

                    }
                    else
                    {
                        count = 0;
                    }
                }

                for (int i = start + 1; i <= start + bestCount + 1; i++)
                {
                    Console.Write("{0} ", numsInput[i]);
                    File.AppendAllText("output.txt", numsInput[i].ToString());
                }
                Console.WriteLine();
            }
        }
    }
}
