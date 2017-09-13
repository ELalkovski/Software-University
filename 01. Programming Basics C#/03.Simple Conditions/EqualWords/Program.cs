using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string word1 = Console.ReadLine();
            word1 = word1.ToLower();
            string word2 = Console.ReadLine();
            word2 = word2.ToLower();
            if (word1 == word2)
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
