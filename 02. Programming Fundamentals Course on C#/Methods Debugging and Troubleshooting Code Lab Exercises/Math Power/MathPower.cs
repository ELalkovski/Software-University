namespace Math_Power
{
    using System;

    public class MathPower
    {
        public static void Main()
        {
            double number = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());

            Console.WriteLine(RaiseToPower(number,power));
        }

        private static double RaiseToPower(double number, int power)
        {
            double result = 1;

            for (int i = 0; i < power; i++)
            {
                result *= number;
            }

            return result;
        }
    }
}
