namespace _02.Basic_Stack_Operations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

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
            var actionNums = Console.ReadLine()
                .Trim()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            var pushQuantity = actionNums[0];
            var popQuantity = actionNums[1];
            var checkNum = actionNums[2];

            var inputNums = Console.ReadLine()
                .Trim()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            var stack = new Stack<int>();
            var minNum = int.MaxValue;

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
                    else
                    {
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
}
