using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterEvenNumber
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = 1;


            while (!(n % 2 == 0))
            {
                try
                {
                    Console.Write("Enter even number: ");
                    n = int.Parse(Console.ReadLine());

                }
                catch
                {

                    Console.WriteLine("Invalid number!"); ;
                }

                
            }
            Console.WriteLine("Even number entered: {0}", n);
            
            

        }
    }
}
