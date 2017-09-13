using System.Collections.Generic;

namespace _13.Family_Tree
{
    public class Person
    {
        private string name;
        private string birthday;
        private List<Person> parents = new List<Person>();
        private List<Person> children = new List<Person>();

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public string Birthday
        {
            get { return this.birthday; }
            set { this.birthday = value; }
        }
        public List<Person> Parents
        {
            get { return this.parents; }
        }

        public List<Person> Children
        {
            get { return this.children; }
        }

        public void AddParent(Person parent)
        {
            this.parents.Add(parent);
        }

        public void AddChild(Person child)
        {
            this.children.Add(child);
        }
    }
}
