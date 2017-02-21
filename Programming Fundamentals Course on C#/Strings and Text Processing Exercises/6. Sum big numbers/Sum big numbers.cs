using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _6.Sum_big_numbers
{
    public class SumBigNums
    {
        public static string GetResult (string firstNum, string multiplier)
        {
            var sum = 0;
            var numInMind = 0;
            var remainder = 0;
            StringBuilder result = new StringBuilder();

            for (int i = firstNum.Length - 1; i >= 0; i--)
            {
                sum = int.Parse(firstNum[i].ToString()) * int.Parse(multiplier.ToString()) + numInMind;
                numInMind = sum / 10;
                remainder = sum % 10;
                result.Append(remainder);

                if (i == 0 && numInMind != 0)
                {
                    result.Append(numInMind);
                }
            }
            var arrResult = result.ToString().ToCharArray();
            Array.Reverse(arrResult);

            return string.Join("", arrResult);

        }

        public static void Main()
        {
            var firstNum = Console.ReadLine().TrimStart(new char[] { '0' });
            var multiplier = Console.ReadLine();

            if (multiplier != "0")
            {
                Console.WriteLine(GetResult(firstNum, multiplier));
            }
            else
            {
                Console.WriteLine("0");
            }
        }
    }
}
