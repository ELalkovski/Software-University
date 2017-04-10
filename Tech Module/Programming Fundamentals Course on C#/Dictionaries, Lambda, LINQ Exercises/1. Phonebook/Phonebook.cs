namespace _1.Phonebook
{
    using System;
    using System.Collections.Generic;
    using System.Linq;


    class Phonebook
    {
        public static void AddEntry (Dictionary<string, string> phonebook, string [] input)
        {
            var key = input[1];
            var value = input[2];

            if (!phonebook.ContainsKey(key))
            {
                phonebook.Add(key, value);
            }
            else
            {
                phonebook[key] = value;
            }
        }

        public static void SearchPhonebook(Dictionary<string, string> phonebook, string[] input)
        {
            var key = input[1];
            bool isExist = false;

            foreach (var name in phonebook.Keys)
            {
                if (name == key)
                {
                    isExist = true;
                }
            }
            if (isExist)
            {
                Console.WriteLine("{0} -> {1}", key, phonebook[key]);
            }
            else
            {
                Console.WriteLine("Contact {0} does not exist.", key);
            }
        }

        public static void Main()
        {
            var phonebook = new Dictionary<string, string>();

            while (1 > 0)
            {
                var input = Console.ReadLine().Split(' ');

                if (input[0] == "A")
                {
                    AddEntry(phonebook, input);
                }
                if (input[0] == "S")
                {
                    SearchPhonebook(phonebook, input);
                }
                if (input[0] == "END")
                {
                    break;
                }
            }
        }
    }
}
