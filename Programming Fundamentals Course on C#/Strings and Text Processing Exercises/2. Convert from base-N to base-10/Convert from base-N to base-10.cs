using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace _2.Convert_from_base_N_to_base_10
{
    public class Convert
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(' ');
            var baseN = int.Parse(input[0]);
            var number = input[1];
            BigInteger sum = 0;
            BigInteger result = 0;
            var power = 0;

            if (baseN >= 2 && baseN <= 10)
            {
                for (int i = number.Length - 1; i >= 0; i--)
                {
                    var currDigit = BigInteger.Parse(number[i].ToString());
                    sum = BigInteger.Multiply(currDigit,BigInteger.Pow(baseN, power));
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
