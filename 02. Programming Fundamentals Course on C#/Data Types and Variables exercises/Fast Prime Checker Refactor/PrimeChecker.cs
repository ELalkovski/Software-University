namespace Fast_Prime_Checker_Refactor
{
    using System;

    public class PrimeChecker
    {
        public static void Main()
        {
            int num = int.Parse(Console.ReadLine());

            for (int searchedNum = 2; searchedNum <= num; searchedNum++)
            {
                bool isPrime = true;

                for (int checkNum = 2; checkNum <= Math.Sqrt(searchedNum); checkNum++)
                {
                    if (searchedNum % checkNum == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                Console.WriteLine($"{searchedNum} -> {isPrime}");
            }
        }
    }
}
