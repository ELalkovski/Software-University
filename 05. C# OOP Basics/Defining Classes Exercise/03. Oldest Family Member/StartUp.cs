using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _03.Oldest_Family_Member
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            MethodInfo oldestMemberMethod = typeof(Family).GetMethod("GetOldestMember");
            MethodInfo addMemberMethod = typeof(Family).GetMethod("AddMember");
            if (oldestMemberMethod == null || addMemberMethod == null)
            {
                throw new Exception();
            }

            var n = int.Parse(Console.ReadLine());
            var family = new Family();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(' ');
                var name = input[0];
                var age = int.Parse(input[1]);

                var currPerson = new Person(name, age);
                family.AddMember(currPerson);
            }
            var oldestPerson = family.GetOldestMember();
            Console.WriteLine($"{oldestPerson.Name} {oldestPerson.Age}");
        }
    }
}
