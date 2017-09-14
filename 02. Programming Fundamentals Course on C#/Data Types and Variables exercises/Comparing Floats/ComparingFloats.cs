namespace Comparing_Floats
{
    using System;

    public class ComparingFloats
    {
        public static void Main()
        {
            double firstNum = double.Parse(Console.ReadLine());
            double secondNum = double.Parse(Console.ReadLine());

            double eps = 0.000001;
            double difference = Math.Abs(firstNum - secondNum);
            bool equalityCheck = difference < eps;

            Console.WriteLine(equalityCheck);
        }
    }
}
