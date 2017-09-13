namespace TriangleOfDollars
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int loopsCount = int.Parse(Console.ReadLine());

            for (int rows = 1; rows <= loopsCount; rows++)
            {
                Console.Write("$");

                for (int cols = 1; cols < rows; cols++)
                {
                    Console.Write(" $");
                }

                Console.WriteLine();
            }
        }
    }
}
