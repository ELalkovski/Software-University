namespace Exercise
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int loopsCount = int.Parse(Console.ReadLine());

            for (int i = 1; i <= loopsCount; i++)
            {
                Console.WriteLine(new string('*', loopsCount));
            }
        }
    }
}
