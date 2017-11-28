namespace _02.Generic_Box_of_Integer
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int linesCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < linesCount; i++)
            {
                int integer = int.Parse(Console.ReadLine());
                Console.WriteLine(new Box<int>(integer));
            }
        }
    }
}
