namespace _06.Company_Roster
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            int linesCount = int.Parse(Console.ReadLine());

           List<Employee> employees = new List<Employee>();

            for (int i = 0; i < linesCount; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(' ');

                string name = input[0];
                double salary = double.Parse(input[1]);
                string position = input[2];
                string department = input[3];
                Employee currEmployee = new Employee(name, salary, position, department);

                if (input.Length == 5)
                {
                    int age = -1;

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
