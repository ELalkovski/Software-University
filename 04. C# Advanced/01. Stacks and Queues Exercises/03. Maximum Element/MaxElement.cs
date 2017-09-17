namespace _03.Maximum_Element
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class MaxElement
    {
        public static void Main()
        {
            /*
             
             You have an empty sequence, and you will be given N queries. Each query is one of these three types:
                1 x - Push the element x into the stack.
                2    - Delete the element present at the top of the stack.
                3    - Print the maximum element in the stack.

             */


            int sequenceLength = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>();
            Stack<int> maxNumsStack = new Stack<int>();
            int currNum = 0;
            int maxNum = 0;

            for (int i = 0; i < sequenceLength; i++)
            {
                string inputAction = Console.ReadLine();

                if (inputAction == "2")
                {
                    int poppedItem = stack.Pop();

                    if (poppedItem == maxNum)
                    {
                        maxNumsStack.Pop();

                        if (maxNumsStack.Count > 0)
                        {
                            maxNum = maxNumsStack.Peek();

                        }
                        else
                        {
                            maxNum = 0;
                        }
                    }
                }
                else if (inputAction == "3")
                {
                    Console.WriteLine(maxNumsStack.Peek());
                }
                else
                {
                    int[] addNumAction = inputAction.Trim()
                        .Split()
                        .Select(int.Parse)
                        .ToArray();

                    currNum = addNumAction[1];
                    stack.Push(currNum);

                    if (currNum > maxNum)
                    {
                        maxNumsStack.Push(currNum);
                        maxNum = currNum;
                    }
                }
            }
        }
    }
}
