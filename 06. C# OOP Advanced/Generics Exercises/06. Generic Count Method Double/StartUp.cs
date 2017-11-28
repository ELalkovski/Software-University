namespace _06.Generic_Count_Method_Double
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int linesCount = int.Parse(Console.ReadLine());
            Box<double> box = new Box<double>();

            for (int i = 0; i < linesCount; i++)
            {
                double floatingNum = double.Parse(Console.ReadLine());
                box.AddElement(floatingNum);
            }

            double border = double.Parse(Console.ReadLine());

            Console.WriteLine(box.GetBiggerValuesCount(border));
        }
    }
}
