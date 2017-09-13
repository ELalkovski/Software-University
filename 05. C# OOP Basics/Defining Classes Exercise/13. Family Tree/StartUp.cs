using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Family_Tree
{
    public class StartUp
    {
        public static string parentName;
        public static string parentBirthday;
        public static string childName;
        public static string childBirthday;

        public static void Main()
        {
            var personNeeded = Console.ReadLine();
            var input = Console.ReadLine();
            var people = new List<Person>();
            var peopleInfo = new List<string>();

            while (input != "End")
            {
                var currPerson = new Person();

                if (input.Contains('-'))  // Adding Parent Child info
                {
                    peopleInfo.Add(input); 
                }
                else
                {
                    var personData = input.Split(' ');                    
                    var name = $"{personData[0]} {personData[1]}";
                    var birthday = personData[2];
                    currPerson.Name = name;
                    currPerson.Birthday = birthday;
                    people.Add(currPerson);              // Adding Person with name and birthdate
                }

                input = Console.ReadLine();
            }

            foreach (var line in peopleInfo)
            {
                var tokens = line.Split(new []{" - "}, StringSplitOptions.RemoveEmptyEntries);
                var parent = new Person();
                var child = new Person();

                if (tokens[0].Contains('/') && tokens[1].Contains('/')) // Two Tokens are dates
                {
                    parentBirthday = tokens[0];
                    childBirthday = tokens[1];

                    parent = people.First(p => p.Birthday.Equals(parentBirthday));
                    child = people.First(p => p.Birthday.Equals(childBirthday));
                }
                else if (tokens[0].Contains('/') || tokens[1].Contains('/'))  // One Token is date
                {
                    if (tokens[0].Contains('/'))
                    {
                        parentBirthday = tokens[0];
                        childName = tokens[1];
                        parent = people.First(p => p.Birthday.Equals(parentBirthday));
                        child = people.First(p => p.Name.Equals(childName));
                    }
                    else
                    {
                        parentName = tokens[0];
                        childBirthday = tokens[1];
                        parent = people.First(p => p.Name.Equals(parentName));
                        child = people.First(p => p.Birthday.Equals(childBirthday));
                    }
                }
                else // Both Tokens are Names
                {
                    parentName = tokens[0];
                    childName = tokens[1];
                    parent = people.First(p => p.Name.Equals(parentName));
                    child = people.First(p => p.Name.Equals(childName));
                }

                if (!parent.Children.Contains(child))
                {
                    parent.AddChild(child);
                }
                if (!child.Parents.Contains(parent))
                {
                    child.AddParent(parent);
                }
            }

            var personToPrint = new Person();
            if (personNeeded.Contains('/'))
            {
                personToPrint = people.First(p => p.Birthday.Equals(personNeeded));
            }
            else
            {
                personToPrint = people.First(p => p.Name.Equals(personNeeded));
            }

            PrintsResult(personToPrint);
        }

        private static void PrintsResult(Person personToPrint)
        {
            Console.WriteLine($"{personToPrint.Name} {personToPrint.Birthday}");
            Console.WriteLine("Parents:");
            foreach (var parent in personToPrint.Parents)
            {
                Console.WriteLine($"{parent.Name} {parent.Birthday}");
            }
            Console.WriteLine("Children:");
            foreach (var child in personToPrint.Children)
            {
                Console.WriteLine($"{child.Name} {child.Birthday}");
            }
        }
    }
}
