namespace EmployeesSystem.App.Core.Commands
{
    using EmployeesSystem.App.Core.Contracts;
    using EmployeesSystem.Services.Contracts;
    using Microsoft.Extensions.DependencyInjection;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using EmployeesSystem.Dtos;

    public class ManagerInfoCommand : ICommand
    {
        public string Execute(List<string> data, IServiceProvider serviceProvider)
        {
            int id = int.Parse(data[0]);
            IEmployeeService employeeService = serviceProvider.GetService<IEmployeeService>();
            ManagerDto managerDto = employeeService.GetManagerById(id);
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{managerDto.FirstName + " " + managerDto.LastName} | Employees: {managerDto.Employees.Count}");

            foreach (var employee in managerDto.Employees)
            {
                sb.AppendLine($"    - {employee.FirstName + " " + employee.LastName} - ${employee.Salary:f2}");
            }            

            return sb.ToString().Trim();
        }
    }
}