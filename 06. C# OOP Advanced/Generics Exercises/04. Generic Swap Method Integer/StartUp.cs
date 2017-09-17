namespace _04.Generic_Swap_Method_Integer
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var linesCount = int.Parse(Console.ReadLine());
            var box = new Box<int>();

            for (int i = 0; i < linesCount; i++)
            {
                var integer = int.Parse(Console.ReadLine());
                box.AddElement(integer);
            }

            var indices = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            box.SwapElements(indices[0], indices[1]);
            Console.WriteLine(box.ToString());
        }
    }
}
