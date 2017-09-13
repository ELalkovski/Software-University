using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingLab_TEST1
{
    class Program
    {
        static void Main(string[] args)
        {
            var width = double.Parse(Console.ReadLine()) * 100;
            var height = double.Parse(Console.ReadLine()) * 100;

            var cols = Math.Truncate((height - 100) / 70);
            var rows = Math.Truncate(width / 120);
            var seats = rows * cols - 3;
            Console.WriteLine(seats);



        }
    }
}
