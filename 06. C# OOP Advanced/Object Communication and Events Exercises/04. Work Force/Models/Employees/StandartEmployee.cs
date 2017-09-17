namespace _04.Work_Force.Models.Employees
{
    public class StandartEmployee : Employee
    {
        private const int workHoursPerkWeek = 40;

        public StandartEmployee(string name) 
            : base(name)
        {
            this.WorkHours = workHoursPerkWeek;
        }
    }
}
