namespace _03.Ferrari
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var driversName = Console.ReadLine();
            var car = new Ferrari(driversName);

            Console.WriteLine(car);
        }
    }
}
