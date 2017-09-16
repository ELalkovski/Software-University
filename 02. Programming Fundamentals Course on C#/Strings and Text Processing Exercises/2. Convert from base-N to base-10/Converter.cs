namespace _2.Convert_from_base_N_to_base_10
{
    using System;
    using System.Numerics;

    public class Convert
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split(' ');
            int baseN = int.Parse(input[0]);
            string number = input[1];
            BigInteger sum = 0;
            BigInteger result = 0;
            int power = 0;

            if (baseN >= 2 && baseN <= 10)
            {
                for (int i = number.Length - 1; i >= 0; i--)
                {
                    BigInteger currDigit = BigInteger.Parse(number[i].ToString());
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
