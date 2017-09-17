namespace _02.Basic_Stack_Operations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class BasicOperations
    {
        /*
            Input Format:
           On the first line you will be given N, S and X separated by a single space.
            On the next line you will be given N amount of integers.
            Output Format:
           On a single line prints either true if X is present in the stack otherwise prints the smallest element in the stack. 
            If the stack is empty prints 0.
        */

        public static void Main()
        {
            int[] actionNums = Console.ReadLine()
                .Trim()
                .Split(' ') 
                .Select(int.Parse)
                .ToArray();

            int pushQuantity = actionNums[0];
            int popQuantity = actionNums[1];
            int checkNum = actionNums[2];

            int[] inputNums = Console.ReadLine()
                .Trim()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            Stack<int> stack = new Stack<int>();
            int minNum = int.MaxValue;

            for (int i = 0; i < pushQuantity; i++)
            {
                stack.Push(inputNums[i]);
            }

            for (int i = 0; i < pushQuantity; i++)
            {
                if (i < popQuantity)
                {
                    stack.Pop();

                    if (stack.Count == 0)
                    {
                        Console.WriteLine(0);
                    }
                }
                else
                {
                    if (stack.Peek() == checkNum)
                    {
                        Console.WriteLine("true");
                        break;
                    }

                    if (stack.Peek() < minNum)
                    {
                        minNum = stack.Peek();
                    }

                    stack.Pop();

                    if (i == pushQuantity - 1)
                    {
                        Console.WriteLine(minNum);
                    }
                }
            }
        }
    }
}
