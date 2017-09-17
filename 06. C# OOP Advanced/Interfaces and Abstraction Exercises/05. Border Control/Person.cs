namespace _05.Border_Control
{
    public class Person : IIdentificationable
    {
        private string name;
        private int age;

        public Person(string name, int age, string id)
        {
            this.name = name;
            this.age = age;
            this.Id = id;
        }

        public string Id { get; }

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
