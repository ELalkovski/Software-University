namespace TrainingLab_TEST1
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            double width = double.Parse(Console.ReadLine()) * 100;
            double height = double.Parse(Console.ReadLine()) * 100;

            double cols = Math.Truncate((height - 100) / 70);
            double rows = Math.Truncate(width / 120);
            double seats = rows * cols - 3;

            Console.WriteLine(seats);
        }
    }
}
