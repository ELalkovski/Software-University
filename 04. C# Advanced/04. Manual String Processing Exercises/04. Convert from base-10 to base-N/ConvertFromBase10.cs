namespace _04.Convert_from_base_10_to_base_N
{
    using System;
    using System.Numerics;
    using System.Text;

    public class ConvertFromBase10
    {
        public static void Main()
        {
            string[] inputNums = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            int baseN = int.Parse(inputNums[0]);
            BigInteger decimalNum = BigInteger.Parse(inputNums[1]);
            BigInteger remainder = 0;
            StringBuilder sb = new StringBuilder();

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
