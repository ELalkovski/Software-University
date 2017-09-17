namespace _04.Basic_Queue_Operations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;


    public class QueueOperations
    {
        public static void Main()
        {
            /*
             * 
            Input Format:
           On the first line you will be given N, S and X separated by a single space.
            On the next line you will be given N amount of integers.
            Output Format:
           On a single line prints either true if X is present in the queue otherwise prints the smallest element in the queue. 
            If the stack is empty prints 0.
            */

            int[] actionNums = Console.ReadLine()
                            .Trim()
                            .Split(' ')
                            .Select(int.Parse)
                            .ToArray();

            int numsCount = actionNums[0];
            int deQueueQuantity = actionNums[1];
            int checkNum = actionNums[2];
            int minNum = int.MaxValue;

            int[] nums = Console.ReadLine()
                .Trim()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            Queue<int> queue = new Queue<int>(nums);

            for (int i = 0; i < numsCount; i++)
            {
                if (i < deQueueQuantity)
                {
                    queue.Dequeue();

                    if (queue.Count == 0)
                    {
                        Console.WriteLine(0);
                    }
                }
                else
                {
                    if (queue.Peek() == checkNum)
                    {
                        Console.WriteLine("true");
                        break;
                    }

                    if (queue.Peek() < minNum)
                    {
                        minNum = queue.Peek();

                    }

                    queue.Dequeue();

                    if (i == numsCount - 1)
                    {
                        Console.WriteLine(minNum);
                    }
                }
            }
        }
    }
}
