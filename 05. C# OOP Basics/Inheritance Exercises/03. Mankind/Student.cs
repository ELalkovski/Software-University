using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _03.Mankind
{
    public class Student : Human
    {
        private string facultyNumber;

        public Student(string firstName, string lastName, string facultyNum)
            : base(firstName, lastName)
        {
            this.FacultyNumber = facultyNum;
        }

        public string FacultyNumber
        {
            get
            {
                return this.facultyNumber;
            }
            set
            {
                var regex = new Regex(@"[^a-zA-Z0-9]");
                if (value.Length < 5 || value.Length > 10 || regex.IsMatch(value))
                {
                    throw new ArgumentException("Invalid faculty number!");
                }
                this.facultyNumber = value;
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"First Name: {base.FirstName}");
            sb.AppendLine($"Last Name: {base.LastName}");
            sb.Append($"Faculty number: {this.FacultyNumber}");

            return sb.ToString();
        }
    }
}
