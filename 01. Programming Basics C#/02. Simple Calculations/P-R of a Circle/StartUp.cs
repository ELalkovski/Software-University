namespace P_R_of_a_Circle
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var r = double.Parse(Console.ReadLine());

            var area = Math.PI * r * r;
            var perimeter = 2 * Math.PI * r;

            Console.WriteLine("area = " + area);
            Console.WriteLine("perimeter = " + perimeter);
        }
    }
}
