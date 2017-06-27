using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Largest_Common_End
{
    class Largest_Common_End
    {
        static void Main(string[] args)
        {
            string[] array1 = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string[] array2 = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int lengthL = 0;
            int lengthR = 0;
            for (int i = 0; i < Math.Min(array1.Length, array2.Length); i++)
            {
                if (array1[i] == array2[i])
                    lengthL++;
                if (array1[array1.Length - 1 - i] == array2[array2.Length - 1 - i])
                    lengthR++;
            }
            if (lengthL >= lengthR)
                Console.WriteLine(lengthL);
            else
                Console.WriteLine(lengthR);
        }
    }
}
