namespace EmployeesSystem.Services.Contracts
{
    using System.Collections.Generic;
    using EmployeesSystem.Dtos;

    public interface IEmployeeService
    {
        string AddEmployee(EmployeeDto dto);

        string SetBirthday(int employeeId, string dateAsString);

        string SetAddress(int employeeId, string address);

        EmployeeDto GetEmployeeById(int employeeId);

        EmployeePersonalInfoDto GetEmployeePersonalInfoDto(int employeeId);

        string SetManager(int employeeId, int managerId);

        ManagerDto GetManagerById(int employeeId);

        ICollection<EmployeeByBirthdayDto> GetEmployeesOlderThan(int age);
    }
}
