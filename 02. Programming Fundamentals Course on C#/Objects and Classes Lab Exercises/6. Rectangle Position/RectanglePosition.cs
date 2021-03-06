﻿namespace _6.Rectangle_Position
{
    using System;

    public class RectanglePosition
    {
        public static void Main()
        {
            string[] rectangleData1 = Console.ReadLine()
                   .Split(' ');
            string[] rectangleData2 = Console.ReadLine()
                .Split(' ');

            Rectangle r1 = ReadRectangle(rectangleData1);
            Rectangle r2 = ReadRectangle(rectangleData2);

            if (IsInside(r1, r2))
            {
                Console.WriteLine("Inside");
            }
            else
            {
                Console.WriteLine("Not inside");
            }
        }

        private static Rectangle ReadRectangle(string[] rectangleData)
        {
            Rectangle rectangleProperties = new Rectangle
            {
                Left = int.Parse(rectangleData[0]),
                Top = int.Parse(rectangleData[1]),
                Width = int.Parse(rectangleData[2]),
                Height = int.Parse(rectangleData[3])
            };

            return rectangleProperties;
        }

        private static bool IsInside(Rectangle r1, Rectangle r2)
        {
            bool isLeft = r1.Left >= r2.Left;
            bool isRight = r1.Right <= r2.Right;
            bool isBottom = r1.Bottom >= r2.Bottom;
            bool isTop = r1.Top <= r2.Top;

            return (isLeft && isRight
                    && isTop && isBottom);
        }
    }
}
