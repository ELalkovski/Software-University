using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.Rectangle_Intersection
{
    public class StartUp
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            var rectanglesCount = input[0];
            var checksCount = input[1];
            var rectangles = new List<Rectangle>();

            for (int i = 0; i < rectanglesCount; i++)
            {
                var rectangleInfo = Console.ReadLine()
                    .Split(' ');

                var rectId = rectangleInfo[0];
                var height = double.Parse(rectangleInfo[1]);
                var width = double.Parse(rectangleInfo[2]);
                var leftX = double.Parse(rectangleInfo[3]);
                var leftY = double.Parse(rectangleInfo[4]);

                var currRectangle = new Rectangle(rectId, width, height, leftX, leftY);
                rectangles.Add(currRectangle);
            }

            for (int i = 0; i < checksCount; i++)
            {
                var checkTokens = Console.ReadLine()
                    .Split(' ');

                var firstRectId = checkTokens[0];
                var secondRectId = checkTokens[1];

                var firstRect = rectangles.Find(r => r.Id == firstRectId);
                var secondRect = rectangles.Find(r => r.Id == secondRectId);
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
