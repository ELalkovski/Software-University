namespace _06.Birthday_Celebrations
{
    public class Person : IIdentificationable, IBirthable
    {
        private int age;

        public Person(string name, int age, string id, string birthDate)
        {
            this.Name = name;
            this.age = age;
            this.Id = id;
            this.BirthDate = birthDate;
        }
        public string Name { get; }

        public string Id { get; }

        public string BirthDate { get; }

        public bool IsIdFake(string lastDigits)
        {
            if (this.Id.EndsWith(lastDigits))
            {
                return true;
            }

            return false;
        }            
    }
}
