using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Multiply_Big_Numbers
{
    public class MultiplyBigNums
    {
        public static void Main()
        {
            var firstNum = Console.ReadLine();
            var multiplier = int.Parse(Console.ReadLine());

            if (multiplier > 0)
            {
                var result = MultiplyNumbers(firstNum, multiplier).TrimEnd('0').ToCharArray();
                Array.Reverse(result);
                Console.WriteLine(result);

                
            }
            else
            {
                Console.WriteLine(0);
            }
        }

        private static string MultiplyNumbers(string firstNum, int multiplier)
        {
            var numInMind = 0;
            var remainder = 0;
            var sb = new StringBuilder();

            for (int i = firstNum.Length - 1; i >= 0; i--)
            {
                var currDigit = int.Parse(firstNum[i].ToString());
                var currMultiplication = currDigit * multiplier + numInMind;
                numInMind = currMultiplication / 10;
                remainder = currMultiplication % 10;
                sb.Append(remainder);

                if (numInMind != 0 && i == 0)
                {
                    sb.Append(numInMind);
                }
            }

            return sb.ToString();
        }
    }
}
