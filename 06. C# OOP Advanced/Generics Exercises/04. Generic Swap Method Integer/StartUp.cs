namespace _04.Generic_Swap_Method_Integer
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            int linesCount = int.Parse(Console.ReadLine());
            Box<int> box = new Box<int>();

            for (int i = 0; i < linesCount; i++)
            {
                int integer = int.Parse(Console.ReadLine());
                box.AddElement(integer);
            }

            int[] indices = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            box.SwapElements(indices[0], indices[1]);

            Console.WriteLine(box.ToString());
        }
    }
}
