namespace EmployeesSystem.Dtos
{
    using EmployeesSystem.Models;
    using System.Collections.Generic;

    public class ManagerDto
    {
        public ManagerDto()
        {
            this.Employees = new List<Employee>();
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public ICollection<Employee> Employees { get; set; }
    }
}
