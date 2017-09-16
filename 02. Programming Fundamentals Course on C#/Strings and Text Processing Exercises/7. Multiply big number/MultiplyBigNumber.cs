namespace _08.Multiply_Big_Numbers
{
    using System;
    using System.Text;

    public class MultiplyBigNums
    {
        public static void Main()
        {
            string firstNum = Console.ReadLine();
            int multiplier = int.Parse(Console.ReadLine());

            if (multiplier > 0)
            {
                char[] result = MultiplyNumbers(firstNum, multiplier).TrimEnd('0').ToCharArray();
                Array.Reverse(result);

                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine(0);
            }
        }

        private static string MultiplyNumbers(string firstNum, int multiplier)
        {
            int numInMind = 0;
            int remainder = 0;
            StringBuilder sb = new StringBuilder();

            for (int i = firstNum.Length - 1; i >= 0; i--)
            {
                int currDigit = int.Parse(firstNum[i].ToString());
                int currMultiplication = currDigit * multiplier + numInMind;
                numInMind = currMultiplication / 10;
                remainder = currMultiplication % 10;
                sb.Append(remainder);

                if (numInMind != 0 && i == 0)
                {
                    sb.Append(numInMind);
                }
            }

            return sb.ToString();
        }
    }
}
