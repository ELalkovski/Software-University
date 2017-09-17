namespace _03.Oldest_Family_Member
{
    using System.Collections.Generic;
    using System.Linq;

    public class Family
    {
        private List<Person> members = new List<Person>();

        public void AddMember(Person currMember)
        {
            this.members.Add(currMember);
        }

        public Person GetOldestMember()
        {
            this.members = members.OrderByDescending(p => p.Age).ToList();

            return this.members[0];
        }
    }
}
