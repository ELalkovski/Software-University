namespace _01.Reverse_Numbers_with_a_Stack
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ReverseNumbers
    {
        public static void Main()
        {
            /* Write a program that reads N integers from the console and reverses them using a stack. Use the Stack<int> class. 
            Just put the input numbers in the stack and pop them. */

            int[] inputNums = Console.ReadLine()
                .Trim()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            Stack<int> stack = new Stack<int>(inputNums);

            for (int i = stack.Count; i != 0; i = stack.Count)
            {
                Console.Write("{0} ", stack.Pop()); 
            }
              
            Console.WriteLine();
        }
    }
}
