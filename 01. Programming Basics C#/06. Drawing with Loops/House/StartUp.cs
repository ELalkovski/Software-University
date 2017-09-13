namespace House
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int loopsCount = int.Parse(Console.ReadLine());
            int dashes = 0;
            int stars = 0;

            if (loopsCount % 2 == 0)
            {
                dashes = loopsCount - 2;
                stars = 2;
            }
            else if (loopsCount % 2 == 1)
            {
                dashes = loopsCount - 1;
                stars = 1;
            }

            for (int roof = 1; roof <= (loopsCount + 1)/ 2; roof++)
            {
                Console.Write("{0}{1}{0}", new string('-', (loopsCount - stars)/2), new string('*',stars));
                Console.WriteLine();
                dashes--;
                stars += 2;
            }

            for (int house = 1; house <= loopsCount / 2 ; house++)
            {
                Console.Write("|{0}|", new string('*', loopsCount - 2));
                Console.WriteLine();
            }
        }
    }
}
