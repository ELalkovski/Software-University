namespace EmployeesSystem.App.Core.Commands
{
    using EmployeesSystem.App.Core.Contracts;
    using EmployeesSystem.Services.Contracts;
    using Microsoft.Extensions.DependencyInjection;
    using System;
    using System.Collections.Generic;

    public class SetManagerCommand : ICommand
    {
        public string Execute(List<string> data, IServiceProvider serviceProvider)
        {
            IEmployeeService employeeService = serviceProvider.GetService<IEmployeeService>();
            string result = employeeService.SetManager(int.Parse(data[0]), int.Parse(data[1]));

            return result;
        }
    }
}
