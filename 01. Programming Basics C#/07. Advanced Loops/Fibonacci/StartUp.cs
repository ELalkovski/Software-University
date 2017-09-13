namespace Fibonacci
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int nthFibNumber = int.Parse(Console.ReadLine());
            int fibFirstNum = 1;
            int fibSecondNum = 1;
            int fibSum = 0;

            if (nthFibNumber < 2)
            {
                Console.WriteLine(1);
            }
            else
            {
                for (int i = 0; i < nthFibNumber - 1; i++)
                {
                    fibSum = fibFirstNum + fibSecondNum;
                    fibFirstNum = fibSecondNum;
                    fibSecondNum = fibSum;
                }

                Console.WriteLine(fibSum);
            }
        }
    }
}
