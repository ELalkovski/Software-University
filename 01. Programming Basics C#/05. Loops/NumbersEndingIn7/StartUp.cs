namespace NumbersEndingIn7
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            for (int num = 0; num <= 1000; num++)
            {
                if (num % 10 == 7)
                {
                    Console.WriteLine(num);
                }
            }
        }
    }
}
