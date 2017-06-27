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


            var sequenceLength = int.Parse(Console.ReadLine());
            var stack = new Stack<int>();
            var maxNumsStack = new Stack<int>();
            var currNum = 0;
            var maxNum = 0;

            for (int i = 0; i < sequenceLength; i++)
            {
                var inputAction = Console.ReadLine();

                if (inputAction == "2")
                {
                    var poppedItem = stack.Pop();

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
                    var addNumAction = inputAction.Trim()
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
