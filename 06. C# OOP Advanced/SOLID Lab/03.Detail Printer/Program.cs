namespace _03.Detail_Printer
{
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            var employees = new List<Employee>();
            employees.Add(new Manager("Pesho", new List<string>(){"Doc1", "Doc2"}));
            employees.Add(new Manager("Gosho", new List<string>() { "Doc1", "Doc2" }));

            DetailsPrinter printer =  new DetailsPrinter(employees);
            printer.PrintDetails();
        }
    }
}
