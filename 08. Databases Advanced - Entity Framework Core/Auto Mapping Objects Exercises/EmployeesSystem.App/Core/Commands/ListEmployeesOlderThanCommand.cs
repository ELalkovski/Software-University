namespace EmployeesSystem.App.Core.Commands
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using EmployeesSystem.App.Core.Contracts;
    using EmployeesSystem.Dtos;
    using EmployeesSystem.Services.Contracts;
    using Microsoft.Extensions.DependencyInjection;

    public class ListEmployeesOlderThanCommand : ICommand
    {
        public string Execute(List<string> data, IServiceProvider serviceProvider)
        {
            int age = int.Parse(data[0]);
            IEmployeeService employeeService = serviceProvider.GetService<IEmployeeService>();
            ICollection<EmployeeByBirthdayDto> employeesDtos = employeeService.GetEmployeesOlderThan(age);

            StringBuilder sb = new StringBuilder();

            foreach (var employeeDto in employeesDtos)
            {
                sb.Append($"{employeeDto.FirstName} {employeeDto.LastName} - ${employeeDto.Salary:f2} - Manager: ");

                if (employeeDto.Manager == null)
                {
                    sb.Append("[no manager]");
                }
                else
                {
                    sb.Append($"{employeeDto.Manager.LastName}");
                }

                sb.Append(Environment.NewLine);
            }

            return sb.ToString().Trim();
        }
    }
}
