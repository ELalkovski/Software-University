namespace NumberPyramid
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int nthNumber = int.Parse(Console.ReadLine());
            int num = 1;

            for (int row = 1; row <= nthNumber; row++)
            {
                for (int cols = 1; cols <= row; cols++)
                {
                    if (cols > 1)
                    {
                        Console.Write(" ");
                        Console.Write(num);
                        num++;
                    }

                    if (num > nthNumber)
                    {
                        break;
                    }
                }

                Console.WriteLine();

                if (num > nthNumber)
                {
                    break;
                }
            }
        }
    }
}
