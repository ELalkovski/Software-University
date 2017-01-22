using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reverseCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstLet = char.Parse(Console.ReadLine());
            char secondLet = char.Parse(Console.ReadLine());
            char thirdLet = char.Parse(Console.ReadLine());

            Console.WriteLine("{0}{1}{2}",thirdLet,secondLet,firstLet);  
        }
    }
}
