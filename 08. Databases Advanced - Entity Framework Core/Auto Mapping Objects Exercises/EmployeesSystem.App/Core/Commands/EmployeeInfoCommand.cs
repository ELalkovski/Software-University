namespace EmployeesSystem.App.Core.Commands
{
    using EmployeesSystem.App.Core.Contracts;
    using EmployeesSystem.Services.Contracts;
    using Microsoft.Extensions.DependencyInjection;
    using System;
    using System.Collections.Generic;
    using EmployeesSystem.Dtos;

    public class EmployeeInfoCommand : ICommand
    {
        public string Execute(List<string> data, IServiceProvider serviceProvider)
        {
            int id = int.Parse(data[0]);
            IEmployeeService employeeService = serviceProvider.GetService<IEmployeeService>();
            EmployeeDto employeeDto = employeeService.GetEmployeeById(id);

           return $"ID: {employeeDto.Id} - {employeeDto.FirstName + " " + employeeDto.FirstName} - ${employeeDto.Salary:f2}";
        }
    }
}