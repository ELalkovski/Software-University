namespace _04.Work_Force.Models.Employees
{
    using _04.Work_Force.Contracts;

    public abstract class Employee : IEmployee
    {
        private string name;
        private int workHours;

        protected Employee(string name)
        {
            this.name = name;
        }

        public string Name
        {
            get { return this.name; }
        }

        public int WorkHours
        {
            get { return this.workHours; }

            protected set { this.workHours = value; }
        }
    }
}
