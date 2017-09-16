using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _04.Convert_from_base_10_to_base_N
{
    public class ConvertFromBase10
    {
        public static void Main()
        {
            var inputNums = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var baseN = int.Parse(inputNums[0]);
            var decimalNum = BigInteger.Parse(inputNums[1]);
            BigInteger remainder = 0;
            var sb = new StringBuilder();

            if (baseN >= 2 && baseN <= 10)
            {
                while (decimalNum != 0)
                {
                    remainder = decimalNum % baseN;
                    decimalNum /= baseN;
                    sb.Insert(0, remainder);
                }

                Console.WriteLine(sb.ToString());
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
