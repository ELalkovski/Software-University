using System;
using System.Globalization;

namespace _12.Google
{
    public class Child
    {
        private string name;
        private string birthday;

        public Child(string name, string date)
        {
            this.name = name;
            this.birthday = date;
        }

        public string Name
        {
            get { return this.name; }
        }

        public string Birthday
        {
            get { return this.birthday; }
        }
    }
}
