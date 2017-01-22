using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace booleanVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();


            bool answer = bool.Parse(input);
            answer = true;
            
            if (input == "true" || input =="True")
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
