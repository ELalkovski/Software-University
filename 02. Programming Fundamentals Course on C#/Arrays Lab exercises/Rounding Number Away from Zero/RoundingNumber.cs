namespace Rounding_Number_Away_from_Zero
{
    using System;
    using System.Linq;

    public class RoundingNumber
    {
        public static void Main()
        {
            double[] array = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();

            for (int i = 0; i < array.Length; i++)
            {
                double currNum = array[i];

                if (currNum != 0)
                {
                    Console.WriteLine("{0} => {1}", currNum, Math.Round(currNum,MidpointRounding.AwayFromZero));
                }
                else
                {
                    Console.WriteLine("0 => 0");
                }
            }
        }
    }
}
