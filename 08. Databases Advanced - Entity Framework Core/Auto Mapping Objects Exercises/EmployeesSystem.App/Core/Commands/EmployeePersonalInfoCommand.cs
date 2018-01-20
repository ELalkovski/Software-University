namespace EmployeesSystem.App.Core.Commands
{
    using AutoMapper;
    using EmployeesSystem.App.Core.Contracts;
    using EmployeesSystem.Models;
    using EmployeesSystem.Services.Contracts;
    using Microsoft.Extensions.DependencyInjection;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using EmployeesSystem.Dtos;

    public class EmployeePersonalInfoCommand : ICommand
    {
        public string Execute(List<string> data, IServiceProvider serviceProvider)
        {
            int id = int.Parse(data[0]);
            IEmployeeService employeeService = serviceProvider.GetService<IEmployeeService>();

            EmployeePersonalInfoDto employeeDto = employeeService.GetEmployeePersonalInfoDto(id);
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"ID: {employeeDto.Id} - {employeeDto.FirstName + " " + employeeDto.LastName} - {employeeDto.Salary:f2}");
            sb.AppendLine($"Birthday: {employeeDto.BirthDate.Value.ToString("dd-MM-yyyy")}");
            sb.AppendLine($"Address: {employeeDto.Address}");

            return sb.ToString().Trim();
        }
    }
}