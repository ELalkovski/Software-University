namespace CheckPrime
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int loopsCount = int.Parse(Console.ReadLine());
            bool isPrime = loopsCount > 1;

            for (int i = 2; i <= Math.Sqrt(loopsCount); i++)
            {
                if (loopsCount % i == 0)
                {
                    isPrime = false;
                }
            }

            if (isPrime)
            {
                Console.WriteLine("Prime");
            }
            else
            {
                Console.WriteLine("Not prime");
            }
        }
    }
}
