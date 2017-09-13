namespace HalfSumElement
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int loopsCount = int.Parse(Console.ReadLine());
            int maxNumber = 0;
            int sum = 0;

            for (int userNum = 0; userNum < loopsCount; userNum++)
            {
                int currentNumber = int.Parse(Console.ReadLine());

                if (maxNumber <= currentNumber)
                {
                    maxNumber = currentNumber;
                    
                }

                sum = sum + currentNumber;
            }

            sum -= maxNumber;

            if (maxNumber == sum)
            {
                Console.WriteLine("Yes Sum = "+ maxNumber);
            }
            else
            {
                Console.WriteLine("No Diff = {0}", Math.Abs(maxNumber - sum));
            }
        }
    }
}
