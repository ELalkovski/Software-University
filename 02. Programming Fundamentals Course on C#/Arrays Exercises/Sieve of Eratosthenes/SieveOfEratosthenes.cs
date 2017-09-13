namespace Sieve_of_Eratosthenes
{
    using System;

    public class SieveOfEratosthenes
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int[] array = new int[n + 1];
            bool[] checkNums = new bool[n + 1];

            string primeNums = null;

            for (int i = 0; i <= n; i++)
            {
                array[i] = i;
                checkNums[i] = true;
            }

            primeNums = SieveOfErat(array, checkNums, primeNums);

            Console.WriteLine(primeNums.Trim());

        }

        private static string SieveOfErat(int[] array, bool[] checkNums, string primeNums)
        {
            checkNums[0] = false;
            checkNums[1] = false;

            for (int i = 0; i < array.Length; i++)
            {
                if (checkNums[i])
                {
                    primeNums += $"{array[i]} ";

                    for (int j = i + 1; j < array.Length; j++)
                    {
                        if (array[j] % i == 0 && checkNums[j] == true)
                        {
                            checkNums[j] = false;
                        }
                    }
                }
            }

            return primeNums;
        }
    }
}
