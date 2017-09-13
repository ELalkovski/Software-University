using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VowelsSum
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int sum = 0;

            for (int userLetter = 0; userLetter < s.Length; userLetter++)
            {
                if (s [userLetter] == 'a')
                {
                    sum += 1;
                }
                else if (s [userLetter] == 'e')
                {
                    sum += 2;
                }
                else if (s[userLetter] == 'i')
                {
                    sum += 3;
                }
                else if (s[userLetter] == 'o')
                {
                    sum += 4;
                }
                else if (s[userLetter] == 'u')
                {
                    sum += 5;
                }
                
            }
            Console.WriteLine("Vowels sum = " + sum);
        }
    }
}
