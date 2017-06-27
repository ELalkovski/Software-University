using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.Party_Reservation_Filter_Module
{
    public class PartyFilterModule
    {
        public static void Main()
        {
            var people = Console.ReadLine()
                .Split(' ')
                .ToList();

            var mainState = new List<string>();
            mainState.AddRange(people);

            var input = Console.ReadLine();

            while (input != "Print")
            {
                var tokens = input.Split(';');
                var command = tokens[0];
                var criteria = tokens[1];
                var boundry = tokens[2];
                if (command == "Add filter")
                {
                    FilterPeople(people, criteria, boundry);
                }
                else if(command == "Remove filter")
                {
                    UnFilterPeople(people, mainState, criteria, boundry);
                }

                input = Console.ReadLine();
            }

            Predicate<string> empty = (person) => { return person == string.Empty; };
            people.RemoveAll(empty);
            Console.WriteLine(string.Join(" ", people));
        }

        private static void UnFilterPeople(List<string> people, List<string> mainState, string criteria, string boundry)
        {
            Predicate<string> start = (person) => { return person.StartsWith(boundry); };
            Predicate<string> end = (person) => { return person.EndsWith(boundry); };
            Predicate<string> contains = (person) => { return person.Contains(boundry); };
            Predicate<string> length = (person) => { return person.Length == int.Parse(boundry); };

            switch (criteria)
            {
                case "Starts with":
                    for (int i = 0; i < mainState.Count; i++)
                    {
                        if (start(mainState[i]))
                        {
                            people[i] = mainState[i];
                        }
                    }
                    break;
                case "Ends with":
                    for (int i = 0; i < mainState.Count; i++)
                    {
                        if (end(mainState[i]))
                        {
                            people[i] = mainState[i];
                        }
                    }
                    break;
                case "Contains with":
                    for (int i = 0; i < mainState.Count; i++)
                    {
                        if (contains(mainState[i]))
                        {
                            people[i] = mainState[i];
                        }
                    }
                    break;
                case "Length":
                    for (int i = 0; i < mainState.Count; i++)
                    {
                        if (length(mainState[i]))
                        {
                            people[i] = mainState[i];
                        }
                    }
                    break;
            }
        }

        private static void FilterPeople(List<string> people, string criteria, string boundry)
        {
            Predicate<string> start = (person) => { return person.StartsWith(boundry); };
            Predicate<string> end = (person) => { return person.EndsWith(boundry); };
            Predicate<string> contains = (person) => { return person.Contains(boundry); };
            Predicate<string> length = (person) => { return person.Length == int.Parse(boundry); };

            switch (criteria)
            {
                case "Starts with":
                    for (int i = 0; i < people.Count; i++)
                    {
                        if (start(people[i]))
                        {
                            people[i] = string.Empty;
                        }
                    }
                    break;
                case "Ends with":
                    for (int i = 0; i < people.Count; i++)
                    {
                        if (end(people[i]))
                        {
                            people[i] = string.Empty;
                        }
                    }
                    break;
                case "Contains":
                    for (int i = 0; i < people.Count; i++)
                    {
                        if (contains(people[i]))
                        {
                            people[i] = string.Empty;
                        }
                    }
                    break;
                case "Length":
                    for (int i = 0; i < people.Count; i++)
                    {
                        if (length(people[i]))
                        {
                            people[i] = string.Empty;
                        }
                    }
                    break;
            }
        }
    }
}
