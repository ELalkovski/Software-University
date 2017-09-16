namespace _07.Sum_Big_Numbers
{
    using System;
    using System.Text;

    public class SumBigNumbers
    {
        public static void Main()
        {
            string firstNum = Console.ReadLine();
            string secondNum = Console.ReadLine();
            int numInMind = 0;
            int remainder = 0;
            StringBuilder sb = new StringBuilder();

            int longestNum = Math.Max(firstNum.Length, secondNum.Length);

            string formatedFirstNum = string.Format("{0}", firstNum.PadLeft(longestNum, '0'));
            string formatedSecondNum = string.Format("{0}", secondNum.PadLeft(longestNum, '0'));

            for (int i = longestNum - 1; i >= 0; i--)
            {
                int sum = int.Parse(formatedFirstNum[i].ToString()) + int.Parse(formatedSecondNum[i].ToString()) + numInMind;
                numInMind = sum / 10;
                remainder = sum % 10;
                sb.Append(remainder);

                if (numInMind > 0 && i == 0)
                {
                    sb.Append(numInMind);
                }
            }

            char[] result = sb.ToString().TrimEnd('0').ToCharArray();
            Array.Reverse(result);

            Console.WriteLine(result);
        }
    }
}
