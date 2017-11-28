namespace _03.Generic_Swap_Method_String
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            int linesCount = int.Parse(Console.ReadLine());
            Box<string> box = new Box<string>();

            for (int i = 0; i < linesCount; i++)
            {
                string str = Console.ReadLine();
                box.AddElement(str);
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
