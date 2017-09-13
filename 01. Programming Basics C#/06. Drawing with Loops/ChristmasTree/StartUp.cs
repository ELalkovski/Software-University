namespace ChristmasTree
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int loopsCount = int.Parse(Console.ReadLine());

            for (int rows = 0; rows <= loopsCount; rows++)
            {
                int spaces = loopsCount - rows;
                int stars = rows;

                Console.Write("{0}{1} ", new string(' ', spaces), new string('*', stars));
                Console.Write("|");
                Console.Write(" {0}", new string('*', stars));

                stars++;
                spaces--;

                Console.WriteLine();
            }
        }
    }
}
