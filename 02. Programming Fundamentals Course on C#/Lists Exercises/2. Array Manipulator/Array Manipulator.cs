﻿namespace _3.Array_Manipulator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ArrayManipulator
    {
        public static void Main()
        {
            List<int> inputNums = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            while (1 > 0)
            {
                List<string> input = Console.ReadLine().Split(' ').ToList();

                if (input[0] == "add")
                {
                    Add(inputNums, input);
                }
                else if (input[0] == "addMany")
                {
                    AddMany(inputNums, input);
                }
                else if (input[0] == "contains")
                {
                    Contains(inputNums, input);
                }
                else if (input[0] == "remove")
                {
                    Remove(inputNums, input);
                }
                else if (input[0] == "shift")
                {
                    Shift(inputNums, input);
                }
                else if (input[0] == "sumPairs")
                {
                    SumPairs(inputNums, input);
                }
                else if (input[0] == "print")
                {
                    Print(inputNums, input);
                    break;
                }
            }
        }

        private static void Add(List<int> inputNums, List<string> input)
        {
            int index = int.Parse(input[1]);
            int element = int.Parse(input[2]);
            inputNums.Insert(index, element);
        }

        private static void AddMany(List<int> inputNums, List<string> input)
        {
            int index = int.Parse(input[1]);
            List<int> collection = new List<int>();

            for (int i = 2; i < input.Count; i++)
            {
                collection.Add(int.Parse(input[i]));
            }

            inputNums.InsertRange(index, collection);
        }

        private static void Contains(List<int> inputNums, List<string> input)
        {
            int element = int.Parse(input[1]);
            bool isContain = false;

            for (int i = 0; i < inputNums.Count; i++)
            {
                if (inputNums[i] == element)
                {
                    isContain = true;
                    Console.WriteLine(i);
                    break;
                }
            }

            if (!isContain)
            {
                Console.WriteLine("-1");
            }
        }

        private static void Remove(List<int> inputNums, List<string> input)
        {
            int index = int.Parse(input[1]);
            inputNums.RemoveAt(index);
        }

        private static void Shift(List<int> inputNums, List<string> input)
        {
            var rotations = int.Parse(input[1]);
            var temp = 0;

            for (int i = 0; i < rotations; i++)
            {
                temp = inputNums[0];
                inputNums.RemoveAt(0);
                inputNums.Add(temp);
            }
        }

        private static void SumPairs(List<int> inputNums, List<string> input)
        {
            for (int i = 0; i < inputNums.Count - 1; i++)
            {
                int pair = inputNums[i] + inputNums[i + 1];
                inputNums.RemoveAt(i);
                inputNums.RemoveAt(i);
                inputNums.Insert(i, pair);
            }
        }

        private static void Print(List<int> inputNums, List<string> input)
        {
            Console.Write("[");
            Console.Write(string.Join(", ", inputNums));
            Console.Write("]");
            Console.WriteLine();
        }
    }
}
