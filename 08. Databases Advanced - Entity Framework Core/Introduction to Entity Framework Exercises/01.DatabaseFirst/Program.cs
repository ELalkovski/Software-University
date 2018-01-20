namespace P02_DatabaseFirst
{
    using System;
    using System.Linq;
    using Microsoft.EntityFrameworkCore;
    using P02_DatabaseFirst.Data;

    public class Program
    {
        public static void Main()
        {
           GetDepartmentsWithMoreThan5Employees();
        }

        private static void GetDeleteProjectById() // 14.
        {
            using (var db = new SoftUniContext())
            {
                var project = db.Projects.FirstOrDefault(p => p.ProjectId == 2);

                var projectsToRemove = db.EmployeesProjects
                    .Where(ep => ep.Project == project)
                    .ToList();

                db.EmployeesProjects
                    .RemoveRange(projectsToRemove);

                db.Projects.Remove(project);
                db.SaveChanges();

                db.Projects
                    .Take(10)
                    .Select(p => p.Name)
                    .ToList()
                    .ForEach(Console.WriteLine);
            }
        }

        private static void GetEmployeesWithFirstNameStartingWithSa() // 13.
        {
            using (var db = new SoftUniContext())
            {
                var employees = db.Employees
                    .Where(e => e.FirstName.StartsWith("Sa"))
                    .ToList();

                foreach (var employee in employees.OrderBy(e => e.FirstName).ThenBy(e => e.LastName))
                {
                    Console.WriteLine($"{employee.FirstName} {employee.LastName} - {employee.JobTitle} - (${employee.Salary:f2})");
                }
            }
        }

        private static void GetIncreaseSalary() // 12.
        {
            using (var db = new SoftUniContext())
            {
                var employees = db.Employees
                    .Where(e => e.Department.Name.Equals("Engineering") ||
                                e.Department.Name.Equals("Tool Design") ||
                                e.Department.Name.Equals("Marketing") ||
                                e.Department.Name.Equals("Information Services"))
                    .ToList();

                foreach (var employee in employees)
                {
                    employee.Salary += employee.Salary * 0.12m;
                }

                foreach (var employee in employees.OrderBy(e => e.FirstName).ThenBy(e => e.LastName))
                {
                    Console.WriteLine($"{employee.FirstName} {employee.LastName} (${employee.Salary:f2})");
                }
            }
        }

        private static void GetDepartmentsWithMoreThan5Employees() // 10.
        {
            using (var db = new SoftUniContext())
            {
                var departments = db.Departments
                    .Include(d => d.Employees)
                    .Where(d => d.Employees.Count > 5)
                    .ToList();

                foreach (var department in departments.OrderBy(d => d.Employees.Count).ThenBy(d => d.Name))
                {
                    Console.WriteLine($"{department.Name} - {department.Manager.FirstName} {department.Manager.LastName}");

                    foreach (var employee in department.Employees.OrderBy(e => e.FirstName).ThenBy(e => e.LastName))
                    {
                        Console.WriteLine($"{employee.FirstName} {employee.LastName} - {employee.JobTitle}");
                    }

                    Console.WriteLine("----------");
                }
            }
        }
    }
}
