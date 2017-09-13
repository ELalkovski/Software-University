namespace GreatestCommonDivisor
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            while (secondNum != 0)
            {
                int temp = secondNum;
                secondNum = firstNum % secondNum;
                firstNum = temp;
            }

            Console.WriteLine(firstNum);
        }
    }
}
