using System;
using System.Text;

namespace _06.Animals
{
    public class Tomcat : Cat
    {
        public Tomcat(string name, int age, string gender)
            : base(name, age, gender)
        {
            base.Gender = this.Gender;
        }

        public override string Gender
        {
            get { return base.Gender; }

            set
            {
                base.Gender = "Male";
            }
        }

        public override string ProduceSound()
        {
            return "Give me one million b***h";
        }
    }
}
