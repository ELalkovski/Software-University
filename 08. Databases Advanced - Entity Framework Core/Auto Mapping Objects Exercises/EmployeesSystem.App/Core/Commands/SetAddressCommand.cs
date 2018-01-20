namespace EmployeesSystem.App.Core.Commands
{
    using EmployeesSystem.App.Core.Contracts;
    using EmployeesSystem.Services.Contracts;
    using Microsoft.Extensions.DependencyInjection;
    using System;
    using System.Collections.Generic;

    public class SetAddressCommand : ICommand
    {
        public string Execute(List<string> data, IServiceProvider serviceProvider)
        {
            IEmployeeService employeeService = serviceProvider.GetService<IEmployeeService>();
            string result = employeeService.SetAddress(int.Parse(data[0]), data[1]);

            return result;
        }
    }
}