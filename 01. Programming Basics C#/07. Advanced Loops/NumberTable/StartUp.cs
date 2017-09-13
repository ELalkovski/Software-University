namespace NumberTable
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int loopsCount = int.Parse(Console.ReadLine());
            int number = 0;

            for (int rows = 0; rows < loopsCount; rows++)
            {
                for (int cols = 0; cols < loopsCount; cols++)
                {
                    number = rows + cols + 1;

                    if (number > loopsCount)
                    {
                        number = 2 * loopsCount - number;
                    }

                    Console.Write("{0} ",number);
                }

                Console.WriteLine();
            }
        }
    }
}
