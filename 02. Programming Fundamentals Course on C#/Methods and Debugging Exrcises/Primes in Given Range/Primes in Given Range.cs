namespace Primes_in_Given_Range
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class PrimesInRange
    {
        public static void Main()
        {
            int startNum = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());

            if (startNum > endNum)
            {
                Console.WriteLine("(empty list)");
            }
            else
            {
                List<int> list = FindPrimesInRange(startNum, endNum);
                int lenght = list.Count();

                for (int i = 0; i <= lenght - 2; i++)
                {

                    Console.Write("{0}, ", list.ElementAt(i));

                }

                Console.Write("{0} ", list.ElementAt(lenght - 1));
                Console.WriteLine();
            }
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

        private static List<int> FindPrimesInRange(int startNum, int endNum)
        {
            List<int> localList = new List<int>();

            for (int i = startNum; i <= endNum; i++)
            {
                if (IsPrime(i))
                {
                    localList.Add(i);
                }
            }

            return localList;
        }
    }
}
