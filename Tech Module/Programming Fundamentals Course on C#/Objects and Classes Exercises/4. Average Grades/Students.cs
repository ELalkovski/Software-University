using System;
using System.Collections.Generic;
using System.Linq;

namespace _4.Average_Grades
{
    public class Student
    {
        public string Name { get; set; }

        public List<double> Grades { get; set; }

        public double AverageGrade()
        {
            return Grades.Average();
        }

    }

    
}
