using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _07.Sum_Big_Numbers
{
    public class SumBigNumbers
    {
        public static void Main()
        {
            var firstNum = Console.ReadLine();
            var secondNum = Console.ReadLine();
            int numInMind = 0;
            int remainder = 0;
            var sb = new StringBuilder();

            var longestNum = Math.Max(firstNum.Length, secondNum.Length);

            var formatedFirstNum = string.Format("{0}", firstNum.PadLeft(longestNum, '0'));
            var formatedSecondNum = string.Format("{0}", secondNum.PadLeft(longestNum, '0'));

            for (int i = longestNum - 1; i >= 0; i--)
            {

                var sum = int.Parse(formatedFirstNum[i].ToString()) + int.Parse(formatedSecondNum[i].ToString()) + numInMind;
                numInMind = sum / 10;
                remainder = sum % 10;
                sb.Append(remainder);

                if (numInMind > 0 && i == 0)
                {
                    sb.Append(numInMind);

                }
            }

            var result = sb.ToString().TrimEnd('0').ToCharArray();
            Array.Reverse(result);
            Console.WriteLine(result);
        }
    }
}
