namespace Prime_Checker
{
    using System;

    public class PrimeChecker
    {
        public static void Main()
        {
            double numberToCheck = double.Parse(Console.ReadLine());
            
            Console.WriteLine(IsPrime(numberToCheck));
        }

        private static bool IsPrime(double numberToCheck)
        {
            bool isPrime = true;

            for (int i = 2; i <= Math.Sqrt(numberToCheck); i++)
            {
                if (numberToCheck % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if (numberToCheck == 0)
            {
                isPrime = false;
            }

            if (numberToCheck == 1)
            {
                isPrime = false;
            }

            return isPrime;
        }
    }
}
