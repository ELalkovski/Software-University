namespace GreaterNumber
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            double grade = double.Parse(Console.ReadLine());

            if (grade >= 5.50)
            {
                Console.WriteLine("Excellent!");
            }
        }
    }
}
