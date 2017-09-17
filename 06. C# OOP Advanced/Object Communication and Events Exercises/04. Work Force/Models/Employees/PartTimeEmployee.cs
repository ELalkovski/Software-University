namespace _04.Work_Force.Models.Employees
{
    public class PartTimeEmployee : Employee
    {
        private const int workHoursPerkWeek = 20;

        public PartTimeEmployee(string name) 
            : base(name)
        {
            this.WorkHours = workHoursPerkWeek;
        }
    }
}
