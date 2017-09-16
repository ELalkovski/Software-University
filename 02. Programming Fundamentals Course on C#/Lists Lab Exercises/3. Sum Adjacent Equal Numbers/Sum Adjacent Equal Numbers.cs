namespace _3.Sum_Adjacent_Equal_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SumAdjacentEqualNumbers
    {
        public static void Main()
        {
            List<double> inputList = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToList();

            SumAdjacentEquals(inputList);

            Console.WriteLine(string.Join(" ", inputList));
        }

        private static void SumAdjacentEquals(List<double> inputList)
        {
            for (int i = 0; i < inputList.Count - 1;)
            {
                if (inputList[i] == inputList[i + 1])
                {
                    inputList[i] += inputList[i + 1];
                    inputList.RemoveAt(i + 1);
                    i--;

                    if (i < 0)
                    {
                        i = 0;
                    }
                }
                else
                {
                    i++;
                }
            }
        }
    }
}
