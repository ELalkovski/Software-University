namespace _2.Command_Interpreter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CommandInterpreter
    {
        public static bool IsValid(List<string> array, string[] data)
        {
            bool isValid = false;

            if (data.Length > 3)
            {
                var startIndex = int.Parse(data[2]);
                var count = int.Parse(data[4]);
                var length = startIndex + count;

                if (startIndex >= 0 && startIndex < array.Count
                && count >= 0 && length <= array.Count)
                {
                    return isValid = true;
                }
                else
                {
                    return isValid;
                }
            }
            else
            {
                var count = int.Parse(data[1]);
                if (count >= 0)
                {
                    return isValid = true;
                }
                else
                {
                    return isValid;
                }
            }
        }

        private static List<string> RollLeft(List<string> array)
        {
            var firstElement = array[0];
            array.Add(firstElement);
            array.RemoveAt(0);
            return array;
        }

        private static List<string> RollRight(List<string> array)
        {
            var lastElement = array[array.Count - 1];
            array.Insert(0, lastElement);
            array.RemoveAt(array.Count - 1);
            return array;
        }

        public static void Main()
        {
            var array = Console.ReadLine()
                .Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            var input = Console.ReadLine();

            while (input != "end")
            {
                var data = input.Split();
                var command = data[0];

                if (IsValid(array, data))
                {
                    switch (command)
                    {
                        case "reverse":
                            var revStartIndex = int.Parse(data[2]);
                            var revCount = int.Parse(data[4]);
                            array.Reverse(revStartIndex, revCount);
                            break;

                        case "sort":
                            var sortStartIndex = int.Parse(data[2]);
                            var sortCount = int.Parse(data[4]);
                            array.Sort(sortStartIndex, sortCount, StringComparer.InvariantCulture);
                            break;

                        case "rollLeft":
                            var countLeft = int.Parse(data[1]);
                            countLeft = countLeft % array.Count;
                            for (int i = 0; i < countLeft; i++)
                            {
                                RollLeft(array);
                            }                   
                            break;

                        case "rollRight":
                            var countRight = int.Parse(data[1]);
                            countRight = countRight % array.Count;
                            for (int i = 0; i < countRight; i++)
                            {
                                RollRight(array);
                            }
                            break;

                    }
                }
                else
                {
                    Console.WriteLine("Invalid input parameters.");
                }

                input = Console.ReadLine();
            }
            Console.WriteLine("[{0}]",string.Join(", ", array));
        }

        
    }
}
