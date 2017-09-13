namespace Tomatoes_TEST1
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            double vegetablesPrice = double.Parse(Console.ReadLine());
            double fruitsPrice = double.Parse(Console.ReadLine());
            int vegetablesKG = int.Parse(Console.ReadLine());
            int fruitsKG = int.Parse(Console.ReadLine());

            double vegetablesOut = vegetablesPrice * vegetablesKG;
            double fruitsOut = fruitsPrice * fruitsKG;
            double money = (vegetablesOut + fruitsOut) / 1.94;

            Console.WriteLine(money);
        }
    }
}
