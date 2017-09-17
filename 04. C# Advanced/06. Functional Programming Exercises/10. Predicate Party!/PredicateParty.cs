namespace _10.Predicate_Party_
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class PredicateParty
    {
        private static Predicate<string> findPerson;
        private static List<string> people = new List<string>();
        private static List<string> peopleToBeAdded = new List<string>();

        public static void Main()
        {
            people = Console.ReadLine()
                    .Split(' ')
                    .ToList();
            string input = Console.ReadLine();

            while (input != "Party!")
            {
                string[] tokens = input.Split(' ');
                string command = tokens[0];
                string criteria = tokens[1];
                string criteriaBoundry = tokens[2];

                if (command == "Remove")
                {
                    switch (criteria)
                    {
                        case "StartsWith":
                            findPerson = (person) => { return person.StartsWith(criteriaBoundry); };
                            people.RemoveAll(findPerson);
                            break;
                        case "EndsWith":
                            findPerson = (person) => { return person.EndsWith(criteriaBoundry); };
                            people.RemoveAll(findPerson);
                            break;
                        case "Length":
                            var nameLength = int.Parse(criteriaBoundry);
                            findPerson = (person) => { return person.Length == nameLength; };
                            people.RemoveAll(findPerson);
                            break;
                    }
                }
                else if (command == "Double")
                {
                    switch (criteria)
                    {
                        case "StartsWith":
                            findPerson = (person) => { return person.StartsWith(criteriaBoundry); };
                            peopleToBeAdded = people.FindAll(findPerson);
                            DoubleGuests(peopleToBeAdded, people);
                            break;
                        case "EndsWith":
                            findPerson = (person) => { return person.EndsWith(criteriaBoundry); };
                            peopleToBeAdded = people.FindAll(findPerson);
                            DoubleGuests(peopleToBeAdded, people);
                           
                            break;
                        case "Length":
                            var nameLength = int.Parse(criteriaBoundry);
                            findPerson = (person) => { return person.Length == nameLength; };
                            peopleToBeAdded = people.FindAll(findPerson);
                            DoubleGuests(peopleToBeAdded, people);
                            break;
                    }
                }

                input = Console.ReadLine();
            }

            if (people.Count > 0)
            {
                Console.WriteLine(string.Join(", ", people) + " are going to the party!");
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }
        }

        private static void DoubleGuests(List<string> peopleToBeAdded, List<string> people)
        {
            foreach (var guy in peopleToBeAdded)
            {
                people.Insert(people.IndexOf(guy), guy);
            }
        }
    }
}
