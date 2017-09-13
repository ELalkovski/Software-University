namespace LeftRightSum
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int loopsCount = int.Parse(Console.ReadLine());
            int leftSum = 0;
            int rightSum = 0;
            
            for (int i = 0; i < loopsCount; i++)
            {
                leftSum = leftSum + int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < loopsCount; i++)
            {
                rightSum = rightSum + int.Parse(Console.ReadLine());
            }

            if (leftSum == rightSum)
            {
                Console.WriteLine("Yes, sum = {0}", leftSum);
            }
            else
            {
                Console.WriteLine("No, diff = {0}", Math.Abs(leftSum - rightSum));
            }
        }
    }
}
