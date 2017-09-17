namespace _05.Phonebook
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Phonebook
    {
        public static void Main()
        {
            /*
             This program recieves input {name}-{phoneNumber} until it recieves command "search" and puts them in dictionary.
             After recieves "search", continue recieves names and checks if they are present in the phonebook. If a name exists it prints it
             with it's phoneNumber.
             */

            string[] input = Console.ReadLine()
                .Split(new char[] {'-', ' '}, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            Dictionary<string, string> phonebook = new Dictionary<string, string>();

            while (input[0] != "search")
            {
                string currName = input[0];
                string currPhoneNum = input[1];

                if (!phonebook.ContainsKey(currName))
                {
                    phonebook.Add(currName, currPhoneNum);
                }
                else
                {
                    phonebook[currName] = currPhoneNum;
                }

                input = Console.ReadLine()
                    .Split(new [] { '-', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
            }

            string name = Console.ReadLine();

            while (name != "stop")
            {
                if (phonebook.ContainsKey(name))
                {
                    Console.WriteLine($"{name} -> {phonebook[name]}");
                }
                else
                {
                    Console.WriteLine($"Contact {name} does not exist.");
                }

                name = Console.ReadLine();
            }
        }
    }
}
