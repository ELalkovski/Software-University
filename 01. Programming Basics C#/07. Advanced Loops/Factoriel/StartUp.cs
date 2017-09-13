namespace Factoriel
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int loopsCount = int.Parse(Console.ReadLine());

            int factoriel = 1;
            do
            {
                factoriel = factoriel * loopsCount;
                loopsCount--;

            } while (loopsCount > 1);

            Console.WriteLine(factoriel);
        }
    }
}
