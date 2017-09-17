namespace _08.Military_Elite.Entities
{
    using _08.Military_Elite.Interfaces;

    public abstract class Soldier : ISoldier
    {
        private string id;
        private string firstName;
        private string lastName;

        protected Soldier(string id, string firstName, string lastName)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string Id
        {
            get { return id; }
            private set { this.id = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            private set { this.firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            private set { this.lastName = value; }
        }
    }
}
