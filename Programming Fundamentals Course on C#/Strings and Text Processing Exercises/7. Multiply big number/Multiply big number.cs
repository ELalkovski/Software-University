using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _7.Multiply_big_number
{
    public class MultiplyBigNums
    {
        public static string GetResult(string firstNum, string secondNum)
        {
            if (firstNum.Length > secondNum.Length)
            {
                secondNum = secondNum.PadLeft(firstNum.Length, '0');
            }
            else
            {
                firstNum = firstNum.PadLeft(secondNum.Length, '0');
            }

            var sum = 0;
            var numInMind = 0;
            var remainder = 0;
            StringBuilder result = new StringBuilder();

            for (int i = firstNum.Length - 1; i >= 0; i--)
            {
                sum = int.Parse(firstNum[i].ToString()) + int.Parse(secondNum[i].ToString()) + numInMind;
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

        }
    }
}
