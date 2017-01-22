using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringsAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstString = "Hello";
            string secondString = "World";
            var objectVar = (firstString + " " + secondString);
            string thirdStr = objectVar;

            Console.WriteLine(thirdStr);
        }
    }
}
