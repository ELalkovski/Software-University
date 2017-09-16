using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _05.Convert_from_base_N_to_base_10
{
    public class ConvertFromBaseN
    {
        public static void Main()
        {
            var inputNums = Console.ReadLine()
                .Split(' ');

            var baseN = int.Parse(inputNums[0]);
            var decimalNum = inputNums[1];
            BigInteger sum = 0;
            BigInteger result = 0;
            var power = 0;

            if (baseN >= 2 && baseN <= 10)
            {
                for (int i = decimalNum.Length - 1; i >= 0; i--)
                {
                    var currDigit = BigInteger.Parse(decimalNum[i].ToString());
                    sum = BigInteger.Multiply(currDigit, BigInteger.Pow(baseN, power));
                    result += sum;
                    power++;
                }
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine(0);
            }

        }
    }
}
