namespace _05.Hot_Potato
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class HotPotato
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(' ').ToArray();
            var counter = int.Parse(Console.ReadLine());
            var queue = new Queue<string>(input);

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
