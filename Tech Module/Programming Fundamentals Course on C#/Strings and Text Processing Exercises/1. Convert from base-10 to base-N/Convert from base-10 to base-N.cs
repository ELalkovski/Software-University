using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace _1.Convert_from_base_10_to_base_N
{
    public class Converter
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                .Split(' ');

            var baseN = int.Parse(input[0]);
            BigInteger number = BigInteger.Parse(input[1]);
            BigInteger remains = 0;
            var result = string.Empty;

            if (baseN >= 2 && baseN <= 10)
            {
                while (number > 0)
                {
                    remains = number % baseN;
                    number /= baseN;
                    result = remains.ToString() + result;
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
