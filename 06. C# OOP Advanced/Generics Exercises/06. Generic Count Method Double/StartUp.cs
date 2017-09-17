namespace _06.Generic_Count_Method_Double
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var linesCount = int.Parse(Console.ReadLine());
            var box = new Box<double>();

            for (int i = 0; i < linesCount; i++)
            {
                var floatingNum = double.Parse(Console.ReadLine());
                box.AddElement(floatingNum);
            }

            var border = double.Parse(Console.ReadLine());

            Console.WriteLine(box.GetBiggerValuesCount(border));
        }
    }
}
