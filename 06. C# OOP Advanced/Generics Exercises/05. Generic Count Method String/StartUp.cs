namespace _05.Generic_Count_Method_String
{
    using System;

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

            string border = Console.ReadLine();

            Console.WriteLine(box.GetBiggerValuesCount(border));
        }
    }
}
