namespace _2.Ladybugs
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;


    public class Ladybugs
    {
        public static bool IsInRange(int index, int fieldSize)
        {
            bool isInRange = true;

            if (index < 0)
            {
                isInRange = false;
            }
            if (index >= fieldSize)
            {
                isInRange = false;
            }

            return isInRange;
        }
        public static void MoveRight (int[] arrayField, int startingIndex, int spaces)
        {
            if (arrayField[startingIndex] == 1)
            {
                arrayField[startingIndex] = 0;
                var landingIndex = startingIndex + spaces;

                while (IsInRange(landingIndex, arrayField.Length))
                {
                    if (arrayField[landingIndex] == 0)
                    {
                        arrayField[landingIndex] = 1;
                        break;
                    }

                    landingIndex += spaces;
                }
            }
        }

        public static void MoveLeft (int[] arrayField, int startingIndex, int spaces)
        {
            if (arrayField[startingIndex] == 1)
            {
                arrayField[startingIndex] = 0;
                var landingIndex = startingIndex - spaces;

                while (IsInRange(landingIndex, arrayField.Length))
                {
                    if (arrayField[landingIndex] == 0)
                    {
                        arrayField[landingIndex] = 1;
                        break;
                    }

                    landingIndex -= spaces;
                }
            }
        }

        public static void Main()
        {
            var fieldSize = int.Parse(Console.ReadLine());
            var bugsIndexes = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            var arrayField = new int [fieldSize];

            foreach (var index in bugsIndexes)
            {
                if (IsInRange(index, fieldSize))
                {
                    arrayField[index] = 1;
                }
            }

            var command = Console.ReadLine();

            while (command != "end")
            {
                var data = command.Split(' ');
                var startingIndex = int.Parse(data[0]);
                var direction = data[1];
                var spaces = int.Parse(data[2]);

                if (IsInRange(startingIndex, fieldSize))
                {
                    if (direction == "right")
                    {
                        if (spaces > 0)
                        {
                            MoveRight(arrayField, startingIndex, Math.Abs(spaces));
                        }
                        else if (spaces < 0)
                        {
                            MoveLeft(arrayField, startingIndex, Math.Abs(spaces));
                        }
                    }
                    else
                    {
                        if (spaces > 0)
                        {
                            MoveLeft(arrayField, startingIndex, Math.Abs(spaces));
                        }
                        else if (spaces < 0)
                        {
                            MoveRight(arrayField, startingIndex, Math.Abs(spaces));
                        }
                    }
                }

                
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ",arrayField));
        }
    }
}
