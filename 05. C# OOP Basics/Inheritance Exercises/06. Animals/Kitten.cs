using System;
using System.Text;

namespace _06.Animals
{
    public class Kitten : Cat
    {
        public Kitten(string name, int age, string gender)
            : base(name, age, gender)
        {
            base.Gender = this.Gender;
        }

        public override string Gender
        {
            get { return base.Gender; }

            set
            {
                base.Gender = "Female";
            }
        }

        public override string ProduceSound()
        {
            return "Miau";
        }
    }
}
