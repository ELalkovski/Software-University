namespace _2.Ladybugs
{
    using System;
    using System.Linq;

    public class Ladybugs
    {
        public static void Main()
        {
            int fieldSize = int.Parse(Console.ReadLine());
            int[] bugsIndexes = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int[] arrayField = new int [fieldSize];

            foreach (var index in bugsIndexes)
            {
                if (IsInRange(index, fieldSize))
                {
                    arrayField[index] = 1;
                }
            }

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] data = command.Split(' ');
                int startingIndex = int.Parse(data[0]);
                string direction = data[1];
                int spaces = int.Parse(data[2]);

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

        public static bool IsInRange(int index, int fieldSize)
        {
            if (index >= 0 && index < fieldSize)
            {
                return true;
            }

            return false;
        }

        public static void MoveRight(int[] arrayField, int startingIndex, int spaces)
        {
            if (arrayField[startingIndex] == 1)
            {
                arrayField[startingIndex] = 0;

                int landingIndex = startingIndex + spaces;

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

        public static void MoveLeft(int[] arrayField, int startingIndex, int spaces)
        {
            if (arrayField[startingIndex] == 1)
            {
                arrayField[startingIndex] = 0;

                int landingIndex = startingIndex - spaces;

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
    }
}
