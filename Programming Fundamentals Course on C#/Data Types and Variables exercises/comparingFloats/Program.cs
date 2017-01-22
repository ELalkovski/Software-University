using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comparingFloats
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNum = double.Parse(Console.ReadLine());
            double secondNum = double.Parse(Console.ReadLine());

            double eps = 0.000001;
            double difference = Math.Abs(firstNum - secondNum);
            bool equalityCheck = false;

            if (difference < eps)
            {
                equalityCheck = true;
            }

            Console.WriteLine(equalityCheck);

            

            
        }
    }
}
