using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_Checker
{
    class PrimeChecker
    {
        public static bool IsPrime(double numberToCheck)
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

        static void Main(string[] args)
        {
            double numberToCheck = double.Parse(Console.ReadLine());
            //bool answer = IsPrime(numberToCheck);
            //string convertedString = Convert.ToString(answer);

            //Console.WriteLine(convertedString.ToLower());
            Console.WriteLine(IsPrime(numberToCheck));

        }
    }
}
