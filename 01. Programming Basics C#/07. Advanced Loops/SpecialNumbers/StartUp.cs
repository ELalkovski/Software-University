namespace SpecialNumbers
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int nthNumber = int.Parse(Console.ReadLine());

            for (int a = 1; a <= 9; a++)
            {
                for (int b = 1; b <= 9; b++)
                {
                    for (int c = 1; c <= 9; c++)
                    {
                        for (int d = 1; d <= 9; d++)
                        {
                            if (nthNumber % a == 0 && nthNumber % b == 0 && nthNumber % c == 0 && nthNumber % d == 0)
                            {
                                Console.Write("{0}{1}{2}{3} ", a, b, c, d);
                            }
                        }
                    }
                }
            }

            Console.WriteLine();
        }
    }
}
