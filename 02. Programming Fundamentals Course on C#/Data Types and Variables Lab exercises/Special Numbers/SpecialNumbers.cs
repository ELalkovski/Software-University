namespace Special_Numbers
{
    using System;

    public class SpecialNumbers
    {
        public static void Main()
        {
            int numbersCount = int.Parse(Console.ReadLine());

            for (int num = 0; num <= numbersCount; num++)
            {
                int sum = 0;
                int digits = num;

                while (digits > 0)
                {
                    sum += digits % 10;
                    digits = digits / 10;
                }

                bool answer = (sum == 5) || (sum == 7) || (sum == 11);

                Console.WriteLine("{0} -> {1}",num, answer);
            }
        }
    }
}
