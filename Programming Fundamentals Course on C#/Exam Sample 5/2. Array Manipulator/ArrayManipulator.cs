namespace _2.Array_Manipulator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;


    public class ArrayManipulator
    {
        public static int[] Exchange(int[] array, int splitIndex)
        {
            var arrFirstPart = new List<int>();
            var arrSecondPart = new List<int>();
            var exchangedArr = new List<int>();

            if (splitIndex >= 0 && splitIndex < array.Length)
            {
                for (int i = splitIndex + 1; i < array.Length; i++)
                {
                    arrFirstPart.Add(array[i]);
                }

                exchangedArr.AddRange(arrFirstPart);

                for (int i = 0; i <= splitIndex; i++)
                {
                    arrSecondPart.Add(array[i]);
                }

                exchangedArr.AddRange(arrSecondPart);

                for (int i = 0; i < exchangedArr.Count; i++)
                {
                    array[i] = exchangedArr[i];
                }
            }
            else
            {
                Console.WriteLine("Invalid index");
            }
            return array;
        }

        public static void MaxEvenOdd(int[] array, string evenOrOdd)
        {
            if (evenOrOdd == "even")
            {
                var filteredArr = array.Where(n => n % 2 == 0).ToArray();

                if (!array.Any(n => n % 2 == 0))
                {
                    Console.WriteLine("No matches");
                }
                else
                {
                    Console.WriteLine(Array.LastIndexOf(array, filteredArr.Max()).ToString());
                }
            }

            else if (evenOrOdd == "odd")
            {
                var filteredArr = array.Where(n => n % 2 != 0).ToArray();

                if (!array.Any(n => n % 2 != 0))
                {
                    Console.WriteLine("No matches");
                }
                else
                {
                    Console.WriteLine(Array.LastIndexOf(array, filteredArr.Max()).ToString());
                }
            }
        }

        public static void MinEvenOdd(int[] array, string evenOrOdd)
        {
            if (evenOrOdd == "even")
            {
                var filteredArr = array.Where(n => n % 2 == 0).ToArray();

                if (!array.Any(n => n % 2 == 0))
                {
                    Console.WriteLine("No matches");
                }
                else
                {
                    Console.WriteLine(Array.LastIndexOf(array, filteredArr.Min()).ToString());
                }
            }

            else if (evenOrOdd == "odd")
            {
                var filteredArr = array.Where(n => n % 2 != 0).ToArray();
                if (!array.Any(n => n % 2 != 0))
                {
                    Console.WriteLine("No matches");
                }
                else
                {
                    Console.WriteLine(Array.LastIndexOf(array, filteredArr.Min()).ToString());
                }
            }
        }

        public static void FirstEvenOdd(int[] array, int count, string evenOrOdd)
        {
            if (evenOrOdd == "even")
            {
                if (count == 0)
                {
                    Console.WriteLine("[]");
                }
                else if ((count > 0) && (count <= array.Length))
                {
                    var printArray = array
                        .Where(n => n % 2 == 0)
                        .ToArray();
                    
                    Console.Write("[");
                    Console.Write(string.Join(", ",printArray.Take(count)));
                    Console.Write("]");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Invalid count");
                }
            }

            if (evenOrOdd == "odd")
            {
                if (count == 0)
                {
                    Console.WriteLine("[]");
                }
                else if ((count > 0) && (count <= array.Length))
                {
                    var printArray = array
                        .Where(n => n % 2 != 0)
                        .ToArray();
                    Console.Write("[");
                    Console.Write(string.Join(", ", printArray.Take(count)));
                    Console.Write("]");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Invalid count");
                }
            }

        }

        public static void LastEvenOdd(int[] array, int count, string evenOrOdd)
        {
            if (evenOrOdd == "even")
            {
                if (count == 0)
                {
                    Console.WriteLine("[]");
                }
                else if ((count > 0) && (count <= array.Length))
                {
                    var printArray = array
                        .Reverse()
                        .Where(n => n % 2 == 0)
                        .ToArray();
                    var wantedArr = printArray.Take(count).Reverse();
                    Console.Write("[");
                    Console.Write(string.Join(", ", wantedArr));
                    Console.Write("]");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Invalid count");
                }
            }

            if (evenOrOdd == "odd")
            {
                if (count == 0)
                {
                    Console.WriteLine("[]");
                }
                else if ((count > 0) && (count <= array.Length))
                {
                    var printArray = array
                        .Reverse()
                        .Where(n => n % 2 != 0)
                        .ToArray();
                    var wantedArr = printArray.Take(count).Reverse();
                    Console.Write("[");
                    Console.Write(string.Join(", ", wantedArr));
                    Console.Write("]");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Invalid count");
                }
            }
        }

        public static void Main()
        {
            var array = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            var input = Console.ReadLine();

            while (input != "end")
            {
                var data = input
                    .Split(' ')
                    .ToList();

                var command = data[0];

                if (command == "exchange")
                {
                    var splitIndex = int.Parse(data[1]);
                    Exchange(array, splitIndex);
                }
                else if (command == "max")
                {
                    var evenOrOdd = data[1];
                    MaxEvenOdd(array, evenOrOdd);
                }
                else if (command == "min")
                {
                    var evenOrOdd = data[1];
                    MinEvenOdd(array, evenOrOdd);
                }
                else if (command == "first")
                {
                    var count = int.Parse(data[1]);
                    var evenOrOdd = data[2];
                    FirstEvenOdd(array, count, evenOrOdd);
                }
                else if (command == "last")
                {
                    var count = int.Parse(data[1]);
                    var evenOrOdd = data[2];
                    LastEvenOdd(array, count, evenOrOdd);
                }

                input = Console.ReadLine();
            }
            Console.Write("[");
            Console.Write(string.Join(", ", array));
            Console.Write("]");
            Console.WriteLine();
        }
    }
}
