namespace _1.Convert_from_base_10_to_base_N
{
    using System;
    using System.Numerics;

    public class Converter
    {
        public static void Main()
        {
            string[] input = Console.ReadLine()
                .Split(' ');

            int baseN = int.Parse(input[0]);
            BigInteger number = BigInteger.Parse(input[1]);
            BigInteger remains = 0;
            string result = string.Empty;

            if (baseN >= 2 && baseN <= 10)
            {
                while (number > 0)
                {
                    remains = number % baseN;
                    number /= baseN;
                    result = remains + result;
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
