namespace OddEvenSum
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int loopsCount = int.Parse(Console.ReadLine());
            int oddSum = 0;
            int evenSum = 0;

            for (int userNum = 0; userNum < loopsCount; userNum++)
            {
                int element = int.Parse(Console.ReadLine());

                if (userNum % 2 == 0)
                {
                    oddSum += element;

                }
                else
                {
                    evenSum += element;
                }

            }

            if (oddSum == evenSum)
            {
                Console.WriteLine("Yes Sum = " + oddSum);
            }
            else
            {
                Console.WriteLine("No Diff = " + Math.Abs(oddSum - evenSum));
            }
        }
    }
}
