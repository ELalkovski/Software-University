namespace Cinema
{
    using System;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            string projection = Console.ReadLine().ToLower();
            int rows = int.Parse(Console.ReadLine());
            int seats = int.Parse(Console.ReadLine());
            int tickets = rows * seats;

            switch (projection)
            {
                case "premiere": Console.WriteLine("{0:f2} leva", 12 * tickets);break;
                case "normal": Console.WriteLine("{0:f2} leva", 7.50 * tickets); break;
                case "discount": Console.WriteLine("{0:f2} leva", 5 * tickets); break;
            }
        }
    }
}
