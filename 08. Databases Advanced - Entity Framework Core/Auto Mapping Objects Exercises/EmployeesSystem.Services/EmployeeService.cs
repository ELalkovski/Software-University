namespace EmployeesSystem.Services
{
    using EmployeesSystem.Data;
    using EmployeesSystem.Models;
    using EmployeesSystem.Services.Contracts;
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using AutoMapper;
    using EmployeesSystem.Dtos;

    public class EmployeeService : IEmployeeService
    {
        private readonly EmployeesDbContext db;

        public EmployeeService()
        {
        }

        public EmployeeService(EmployeesDbContext db)
        {
            this.db = db;
            //InitializeAutomapper();
        }

        public string AddEmployee(EmployeeDto dto)
        {
            Employee employeeToAdd = Mapper.Map<Employee>(dto);
            this.db.Employees.Add(employeeToAdd);
            this.db.SaveChanges();

            return $"Employee {employeeToAdd.FirstName + " " + employeeToAdd.LastName} was added successfully.";
        }

        public string SetBirthday(int employeeId, string dateAsString)
        {
            Employee employee = this.db
                .Employees
                .FirstOrDefault(e => e.Id == employeeId);

            if (employee == null)
            {
                throw new ArgumentException("Employee not found!");
            }

            employee.BirthDate = DateTime.ParseExact(dateAsString, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            this.db.SaveChanges();

            return $"Birth date of employee with id {employeeId} was set successfully!";
        }

        public string SetAddress(int employeeId, string address)
        {
            Employee employee = this.db
                .Employees
                .FirstOrDefault(e => e.Id == employeeId);

            if (employee == null)
            {
                throw new ArgumentException("Employee not found!");
            }

            employee.Address = address;
            this.db.SaveChanges();

            return $"Address of employee with id {employeeId} was set successfully!";
        }

        public EmployeeDto GetEmployeeById(int employeeId)
        {
            Employee employee = this.db
                .Employees
                .FirstOrDefault(e => e.Id == employeeId);

            if (employee == null)
            {
                throw new ArgumentException("Employee not found!");
            }

            EmployeeDto employeeDto = Mapper.Map<EmployeeDto>(employee);

            return employeeDto;
        }

        public EmployeePersonalInfoDto GetEmployeePersonalInfoDto(int employeeId)
        {
            Employee employee = this.db
                .Employees
                .FirstOrDefault(e => e.Id == employeeId);

            if (employee == null)
            {
                throw new ArgumentException("Employee not found!");
            }

            EmployeePersonalInfoDto employeeDto = Mapper.Map<EmployeePersonalInfoDto>(employee);

            return employeeDto;
        }

        public string SetManager(int employeeId, int managerId)
        {
            Employee employee = this.db
                .Employees
                .FirstOrDefault(e => e.Id == employeeId);

            Employee manager = this.db
                .Employees
                .Include(e => e.ManagedEmployees)
                .FirstOrDefault(e => e.Id == managerId);

            if (employee == null)
            {
                throw new ArgumentException("Employee not found!");
            }

            if (manager == null)
            {
                throw new ArgumentException("Manager not found!");
            }

            employee.Manager = manager;
            employee.ManagerId = manager.Id;
            manager.ManagedEmployees.Add(employee);
            this.db.SaveChanges();

            return $"Employee with id {manager.Id} is now manager of {employee.Id}";
        }

        public ManagerDto GetManagerById(int employeeId)
        {
            Employee employee = this.db
                .Employees
                .Include(m => m.ManagedEmployees)
                .FirstOrDefault(e => e.Id == employeeId);

            if (employee == null)
            {
                throw new ArgumentException("Manager not found!");
            }

            ManagerDto manager = Mapper.Map<ManagerDto>(employee);

            return manager;
        }

        public ICollection<EmployeeByBirthdayDto> GetEmployeesOlderThan(int age)
        {
            List<Employee> employees = this.db
                .Employees
                .Include(e => e.Manager)
                .Where(e => this.GetDatesDifference(e.BirthDate.Value) > age)
                .ToList();

            ICollection<EmployeeByBirthdayDto> olderEmployees = new List<EmployeeByBirthdayDto>();

            foreach (var employee in employees)
            {
                olderEmployees.Add(Mapper.Map<EmployeeByBirthdayDto>(employee));
            }

            return olderEmployees;
        }

        private int GetDatesDifference(DateTime birthDate)
        {
            DateTime zeroTime = new DateTime(1, 1, 1);
            DateTime currentYear = DateTime.Now;
            TimeSpan difference = currentYear - birthDate;

            int years = (zeroTime + difference).Year - 1;

            return years;
        }

    }
}
