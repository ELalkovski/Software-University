namespace SunGlasses
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int loopsCount = int.Parse(Console.ReadLine());
            int horisontalFrame = 2 * loopsCount;
            int spaces = loopsCount;

            Console.Write("{0}{1}{0}", new string('*', horisontalFrame), new string(' ', spaces));
            Console.WriteLine();

            for (int verticalF = 1; verticalF <= loopsCount - 2; verticalF++)
            {
                Console.Write("*{0}*", new string('/', (2 * loopsCount) - 2));

                if ((loopsCount % 2) == 0 && verticalF == (loopsCount - 2)/2 )
                {
                    Console.Write("{0}", new string('|', spaces));
                }
                else if ((loopsCount % 2) == 1 && verticalF == ((loopsCount - 2) / 2)+1)
                {
                    Console.Write("{0}", new string('|', spaces));
                }
                else
                {
                    Console.Write("{0}", new string(' ', spaces));
                }
                
                Console.Write("*{0}*", new string('/', (2 * loopsCount) - 2));
                Console.WriteLine();
            }

            Console.Write("{0}{1}{0}", new string('*', horisontalFrame), new string(' ', spaces));
            Console.WriteLine();
        }
    }
}
