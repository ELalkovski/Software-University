namespace Master_Numbers
{
    using System;

    public class MasterNumbers
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i <= number; i++)
            {
                if (IsPalindrome(i) && IsSumDivisibleToSeven(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        private static bool IsPalindrome(int number)
        {
            bool isPalindrome;
            string stringNum = number.ToString();
            string reverse = "";

            for (int i = stringNum.Length - 1; i >= 0; i--)
            {
                reverse += stringNum[i];
            }

            isPalindrome = (stringNum == reverse);

            return isPalindrome;
        }

        private static bool IsSumDivisibleToSeven(int number)
        {
            int sum = 0;
            bool divisible = false;
            bool evenDigit = false;

            while (number > 0)
            {
                int currNum = number % 10;
                if (currNum % 2 == 0) evenDigit = true;
                sum += currNum;
                number /= 10;
            }

            if (sum % 7 == 0)
            {
                divisible = true;
            }

            if (evenDigit && divisible)
            {
                return true;
            }

            return false;
        }
    }
}
