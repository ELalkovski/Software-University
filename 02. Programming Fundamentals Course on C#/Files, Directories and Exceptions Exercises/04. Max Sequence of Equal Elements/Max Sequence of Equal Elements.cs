namespace _4.Max_Sequence_of_Equal_Elements
{
    using System;
    using System.Linq;
    using System.IO;

    public class MaxSequence
    {
        public static void Main()
        {
            string[] inputStrings = File.ReadAllLines("Inputs.txt");

            foreach (var input in inputStrings)
            {
                int[] numsInput = input
                    .Split(' ')
                    .Select(int.Parse)
                    .ToArray();

                int start = 0;
                int count = 0;
                int bestCount = 0;

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
