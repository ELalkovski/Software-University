namespace EmployeesSystem.Dtos
{
    using EmployeesSystem.Models;

    public class EmployeeByBirthdayDto
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public Employee Manager { get; set; }

        public decimal Salary { get; set; }
    }
}
