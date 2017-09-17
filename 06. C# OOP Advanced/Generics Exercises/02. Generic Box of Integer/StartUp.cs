using System;

namespace _02.Generic_Box_of_Integer
{
    public class StartUp
    {
        public static void Main()
        {
            var linesCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < linesCount; i++)
            {
                var integer = int.Parse(Console.ReadLine());
                Console.WriteLine(new Box<int>(integer));
            }
        }
    }
}
