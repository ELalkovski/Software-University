using System;
using _09.Collection_Hierarchy.Entities;
using _09.Collection_Hierarchy.Interfaces;

namespace _09.Collection_Hierarchy
{
    public class StartUp
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                .Split(' ');

            var addCollection = new AddCollection();
            var removeAddCollection = new AddRemoveCollection();
            var myList = new MyList();

            foreach (var word in input)
            {
                Console.Write($"{addCollection.AddItem(word)} ");
            }

            Console.WriteLine();

            foreach (var word in input)
            {
                Console.Write($"{removeAddCollection.AddItem(word)} ");
            }

            Console.WriteLine();

            foreach (var word in input)
            {
                Console.Write($"{myList.AddItem(word)} ");
            }

            Console.WriteLine();

            var wordsToRemove = int.Parse(Console.ReadLine());

            for (int i = 0; i < wordsToRemove; i++)
            {
                Console.Write($"{removeAddCollection.RemoveItem()} ");
            }

            Console.WriteLine();

            for (int i = 0; i < wordsToRemove; i++)
            {
                Console.Write($"{myList.RemoveItem()} ");
            }

            Console.WriteLine();
        }

        
    }
}
