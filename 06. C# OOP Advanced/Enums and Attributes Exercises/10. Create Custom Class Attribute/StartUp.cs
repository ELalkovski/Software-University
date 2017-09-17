namespace _10.Create_Custom_Class_Attribute
{
    using System;
    using System.Text;

    public class StartUp
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            while (input != "END")
            {
                input = Console.ReadLine();
            }
            var sb = new StringBuilder();
            sb.AppendLine("Author: Pesho");
            sb.AppendLine("Revision: 3");
            sb.AppendLine("Class description: Used for C# OOP Advanced Course - Enumerations and Attributes.");
            sb.Append("Reviewers: Pesho, Svetlio");

            Console.WriteLine(sb.ToString());
        }
    }
}
