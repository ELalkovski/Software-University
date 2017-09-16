namespace _3.Equal_Sums
{
    using System;
    using System.Linq;
    using System.IO;

    public class EqualSums
    {
        public static void Main()
        {
            string[] inputStrings = File.ReadAllLines("Inputs.txt");

            foreach (var currentInput in inputStrings)
            {
                int[] currInputNums = currentInput
                    .Split(' ')
                    .Select(int.Parse)
                    .ToArray();


                int neededIndex = 0;

                for (int i = 0; i < currInputNums.Length; i++)
                {
                    int leftSum = 0;
                    int rightSum = 0;

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
