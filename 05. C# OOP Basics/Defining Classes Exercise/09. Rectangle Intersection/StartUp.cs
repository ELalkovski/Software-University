namespace _09.Rectangle_Intersection
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            int[] input = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int rectanglesCount = input[0];
            int checksCount = input[1];
            List<Rectangle> rectangles = new List<Rectangle>();

            for (int i = 0; i < rectanglesCount; i++)
            {
                string[] rectangleInfo = Console.ReadLine()
                    .Split(' ');

                string rectId = rectangleInfo[0];
                double height = double.Parse(rectangleInfo[1]);
                double width = double.Parse(rectangleInfo[2]);
                double leftX = double.Parse(rectangleInfo[3]);
                double leftY = double.Parse(rectangleInfo[4]);

                Rectangle currRectangle = new Rectangle(rectId, width, height, leftX, leftY);
                rectangles.Add(currRectangle);
            }

            for (int i = 0; i < checksCount; i++)
            {
                string[] checkTokens = Console.ReadLine()
                    .Split(' ');

                string firstRectId = checkTokens[0];
                string secondRectId = checkTokens[1];
                Rectangle firstRect = rectangles.Find(r => r.Id == firstRectId);
                Rectangle secondRect = rectangles.Find(r => r.Id == secondRectId);

                if (firstRect.IsIntersected(secondRect))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
            }
        }
    }
}
