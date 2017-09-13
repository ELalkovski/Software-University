namespace RadiansToDegrees
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            Console.Write("rad = ");
            double rad = double.Parse(Console.ReadLine());
            double deg = rad * 180 / Math.PI;

            Console.WriteLine("deg = " + Math.Round(deg, 0));
        }
    }
}
