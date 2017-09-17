namespace _05.Convert_from_base_N_to_base_10
{
    using System;
    using System.Numerics;

    public class ConvertFromBaseN
    {
        public static void Main()
        {
            string[] inputNums = Console.ReadLine()
                .Split(' ');

            int baseN = int.Parse(inputNums[0]);
            string decimalNum = inputNums[1];
            BigInteger sum = 0;
            BigInteger result = 0;
            int power = 0;

            if (baseN >= 2 && baseN <= 10)
            {
                for (int i = decimalNum.Length - 1; i >= 0; i--)
                {
                    BigInteger currDigit = BigInteger.Parse(decimalNum[i].ToString());
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
