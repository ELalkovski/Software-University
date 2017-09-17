namespace _05.Generic_Count_Method_String
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var linesCount = int.Parse(Console.ReadLine());
            var box = new Box<string>();

            for (int i = 0; i < linesCount; i++)
            {
                var str = Console.ReadLine();
                box.AddElement(str);
            }

            var border = Console.ReadLine();

            Console.WriteLine(box.GetBiggerValuesCount(border));
        }
    }
}
