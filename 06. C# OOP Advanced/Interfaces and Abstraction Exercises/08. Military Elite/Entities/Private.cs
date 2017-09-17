namespace _08.Military_Elite.Entities
{
    using _08.Military_Elite.Interfaces;

    public class Private : Soldier, IPrivate
    {
        private double salary;

        public Private(string id, string firstName, string lastName, double salary) 
            : base(id, firstName, lastName)
        {
            this.Salary = salary;
        }

        public double Salary
        {
            get { return this.salary; }
            private set { this.salary = value; }
        }

        public override string ToString()
        {
            return $"Name: {this.FirstName} {this.LastName} Id: {this.Id} Salary: {this.Salary:f2}";
        }
    }
}
