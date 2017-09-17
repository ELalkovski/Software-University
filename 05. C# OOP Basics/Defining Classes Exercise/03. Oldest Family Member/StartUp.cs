namespace _03.Oldest_Family_Member
{
    using System;
    using System.Reflection;

    public class StartUp
    {
        public static void Main()
        {
            MethodInfo oldestMemberMethod = typeof(Family).GetMethod("GetOldestMember");
            MethodInfo addMemberMethod = typeof(Family).GetMethod("AddMember");

            if (oldestMemberMethod == null || addMemberMethod == null)
            {
                throw new Exception();
            }

            int n = int.Parse(Console.ReadLine());
            Family family = new Family();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                string name = input[0];
                int age = int.Parse(input[1]);
                Person currPerson = new Person(name, age);

                family.AddMember(currPerson);
            }

            Person oldestPerson = family.GetOldestMember();

            Console.WriteLine($"{oldestPerson.Name} {oldestPerson.Age}");
        }
    }
}
