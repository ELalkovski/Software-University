namespace _05.Hot_Potato
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class MathPotato
    {
        public static class PrimeTool
        {
            public static bool IsPrime(int candidate)
            {
                // Test whether the parameter is a prime number.
                if ((candidate & 1) == 0)
                {
                    if (candidate == 2)
                    {
                        return true;
                    }

                    return false;
                }
                // Note:
                // ... This version was changed to test the square.
                // ... Original version tested against the square root.
                // ... Also we exclude 1 at the end.

                for (int i = 3; (i * i) <= candidate; i += 2)
                {
                    if ((candidate % i) == 0)
                    {
                        return false;
                    }
                }

                return candidate != 1;
            }
        }

        public static void Main()
        {
            string[] input = Console.ReadLine()
                .Split(' ')
                .ToArray();
            int counter = int.Parse(Console.ReadLine());
            Queue<string> queue = new Queue<string>(input);
            int cycles = 1;

            while (queue.Count > 1)
            {
                for (int i = 0; i < counter - 1; i++)
                {
                    queue.Enqueue(queue.Dequeue());
                }

                if (PrimeTool.IsPrime(cycles))
                {
                    Console.WriteLine("Prime {0}", queue.Peek());
                }
                else
                {
                    Console.WriteLine("Removed {0}", queue.Dequeue());
                }

                cycles++;
            }

            Console.WriteLine("Last is {0}", queue.Dequeue());
        }
    }
}
