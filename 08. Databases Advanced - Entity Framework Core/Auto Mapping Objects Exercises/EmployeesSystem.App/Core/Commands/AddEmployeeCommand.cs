namespace EmployeesSystem.App.Core.Commands
{
    using EmployeesSystem.App.Core.Contracts;
    using EmployeesSystem.Services.Contracts;
    using Microsoft.Extensions.DependencyInjection;
    using System;
    using System.Collections.Generic;
    using EmployeesSystem.Dtos;

    public class AddEmployeeCommand : ICommand
    {
        public string Execute(List<string> data, IServiceProvider serviceProvider)
        {            
            IEmployeeService employeeService = serviceProvider.GetService<IEmployeeService>();
            EmployeeDto employeeDto = new EmployeeDto(data[0], data[1], decimal.Parse(data[2]));
            string result = employeeService.AddEmployee(employeeDto);

            return result;
        }
    }
}
