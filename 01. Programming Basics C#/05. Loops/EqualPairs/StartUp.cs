namespace EqualPairs
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int loopsCount = int.Parse(Console.ReadLine());
            int firstPair = 0;
            int secondPair = 0;
            int thirdPair = 0;
            int diff = 0;
            int sum = 0;
            int allSum = 0;

            for (int rows = 1; rows <= loopsCount; rows++)
            {
                int firstNum = int.Parse(Console.ReadLine());
                int secondNum = int.Parse(Console.ReadLine());

                sum = firstNum + secondNum;
                allSum += sum;

                if (rows > 1)
                {
                    diff = allSum - sum;
                }
            }

            Console.WriteLine(diff);
        }
    }
}
