namespace _10.Explicit_Interfaces
{
    public class Citizen : IPerson, IResident
    {
        private string name;
        private string age;
        private string country;

        public Citizen(string name, string country, string age)
        {
            this.name = name;
            this.country = country;
            this.age = age;
        }

        public string Name
        {
            get { return name; }
        }

        public string Age
        {
            get { return age; }
        }

        public string Country
        {
            get { return country; }
        }

        string IResident.GetName()
        {
            return $"Mr/Ms/Mrs {this.Name}";
        }

        string IPerson.GetName()
        {
            return $"{this.Name}";
        }
    }
}
