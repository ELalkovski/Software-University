using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Oldest_Family_Member
{
    public class Family
    {
        private List<Person> members = new List<Person>();

        //public List<Person> Members
        //{
        //    get { return this.members; }
        //    set { this.members = value; }
        //}

        public void AddMember(Person currMember)
        {
            this.members.Add(currMember);
        }

        public Person GetOldestMember()
        {
            members = members.OrderByDescending(p => p.Age).ToList();
            return members[0];
        }
    }
}
