namespace Diamond
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int loopsCount = int.Parse(Console.ReadLine());
            int midDashes = 0;
            int oddMidDashes = 1;
            int leftRightDashes = (loopsCount - 2) / 2;
            int oddleftRightDashes = (loopsCount - 3) / 2;

            if (loopsCount <= 2)
            {
                Console.Write("{0}", new string('*', loopsCount));
                Console.WriteLine();
            }
            else
            {
                if (loopsCount % 2 == 0)
                {
                    for (int uprows = 1; uprows <= loopsCount / 2; uprows++)
                    {
                        Console.Write("{0}*{1}*{0}", new string('-', leftRightDashes), new string('-', midDashes));
                        Console.WriteLine();
                        midDashes += 2;
                        leftRightDashes--;

                    }

                    leftRightDashes = 1;
                    midDashes = loopsCount - 2 - 2;

                    for (int drows = 1; drows <= (loopsCount / 2) - 1; drows++)
                    {
                        Console.Write("{0}*{1}*{0}", new string('-', leftRightDashes), new string('-', midDashes));
                        Console.WriteLine();
                        midDashes -= 2;
                        leftRightDashes++;

                    }
                }
                else if (loopsCount % 2 == 1)
                {
                    for (int uprows = 1; uprows <= (loopsCount / 2) + 1; uprows++)
                    {
                        if (uprows == 1)
                        {
                            Console.Write("{0}*{0}", new string('-', (loopsCount - 1) / 2));
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.Write("{0}*{1}*{0}", new string('-', oddleftRightDashes), new string('-', oddMidDashes));
                            Console.WriteLine();
                            oddMidDashes += 2;
                            oddleftRightDashes--;
                        }
                    }

                    oddleftRightDashes = 1;
                    oddMidDashes = loopsCount - 2 - 2;

                    for (int uprows = 1; uprows <= loopsCount / 2; uprows++)
                    {
                        if (uprows == (loopsCount / 2))
                        {
                            Console.Write("{0}*{0}", new string('-', (loopsCount - 1) / 2));
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.Write("{0}*{1}*{0}", new string('-', oddleftRightDashes), new string('-', oddMidDashes));
                            Console.WriteLine();
                            oddMidDashes -= 2;
                            oddleftRightDashes++;
                        }
                    }
                }
            }
        }
    }
}
