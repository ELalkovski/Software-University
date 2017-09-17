namespace _05.Hot_Potato
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class HotPotato
    {
        public static void Main()
        {
            string[] input = Console.ReadLine()
                .Split(' ')
                .ToArray();
            int counter = int.Parse(Console.ReadLine());
            Queue<string> queue = new Queue<string>(input);

            while (queue.Count > 1)
            {
                for (int i = 0; i < counter - 1; i++)
                {
                    string reminder = queue.Dequeue();
                    queue.Enqueue(reminder);
                }

                Console.WriteLine("Removed {0}", queue.Dequeue());
            }

            Console.WriteLine("Last is {0}", queue.Dequeue());
        }
    }
}
