namespace _06.Company_Roster
{
    public class Employee
    {
        private string name;
        private double salary;
        private string position;
        private string department;
        private string email = "n/a";
        private int age = -1;

        public Employee(string name, double salary, string position, string department)
        {
            this.name = name;
            this.salary = salary;
            this.position = position;
            this.department = department;
        }

        public string Email
        {
            get { return this.email; }
            set { this.email = value; }
        }

        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }

        public string Department
        {
            get { return this.department; }
            set { this.department = value; }
        }

        public double Salary
        {
            get { return this.salary; }
            set { this.salary = value; }
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public string Position
        {
            get { return this.position; }
            set { this.position = value; }
        }
    }
}
