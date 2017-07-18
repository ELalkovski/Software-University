using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.Company_Roster
{
    public class StartUp
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var employees = new List<Employee>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine()
                    .Split(' ');

                var name = input[0];
                var salary = double.Parse(input[1]);
                var position = input[2];
                var department = input[3];
                var currEmployee = new Employee(name, salary, position, department);

                if (input.Length == 5)
                {
                    var age = -1;
                    try
                    {
                        age = int.Parse(input[4]);
                    }
                    catch (Exception)
                    {
                        
                    }
                    if (age != -1)
                    {
                        currEmployee.Age = age;
                    }
                    else
                    {
                        currEmployee.Email = input[4];
                    }    
                }
                else if (input.Length == 6)
                {
                    currEmployee.Email = input[4];
                    currEmployee.Age = int.Parse(input[5]);
                }

                employees.Add(currEmployee);
            }

            var result = employees
                .GroupBy(e => e.Department)
                .Select(e => new
                {
                    Department = e.Key,
                    AverageSalary = e.Average(emp => emp.Salary),
                    Employees = e.OrderByDescending(emp => emp.Salary)
                })
                .OrderByDescending(d => d.AverageSalary)
                .FirstOrDefault();

            Console.WriteLine($"Highest Average Salary: {result.Department}");

            foreach (var employee in result.Employees)
            {
                Console.WriteLine($"{employee.Name} {employee.Salary:f2} {employee.Email} {employee.Age}");
            }
        }
    }
}
