namespace Max_Method
{
    using System;

    public class MaxMethod
    {
        public static void Main()
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());

            if (GetMax(firstNum, secondNum) > thirdNum)
            {
                Console.WriteLine(GetMax(firstNum, secondNum));
            }
            else
            {
                Console.WriteLine(thirdNum);
            }
        }

        private static int GetMax(int firstNum, int secondNum)
        {
            if (firstNum > secondNum)
            {
                return firstNum;
            }

            return secondNum;
        }
    }
}
