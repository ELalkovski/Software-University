using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greater_of_Two_Values
{
    class Program
    {
        public static int GetMax (int firstInput, int secondInput)
        {
            if (firstInput >= secondInput) return firstInput;
            else return secondInput;
        }

        public static string GetMax (string firstInput, string secondInput)
        {
            if (firstInput.CompareTo(secondInput) >= 0) return firstInput;
            else return secondInput;
        }

        public static char GetMax (char firstInput, char secondInput)
        {
            if (firstInput >= secondInput) return firstInput;
            else return secondInput;
        }

        static void Main(string[] args)
        {
            var type = Console.ReadLine();

            if (type == "int")
            {
                int firstInput = int.Parse(Console.ReadLine());
                int secondInput = int.Parse(Console.ReadLine());
                Console.WriteLine(GetMax(firstInput,secondInput));
            }
            else if (type == "string")
            {
                string firstInput = Console.ReadLine();
                string secondInput = Console.ReadLine();
                Console.WriteLine(GetMax(firstInput,secondInput));
            }
            else if (type == "char")
            {
                char firstInput = char.Parse(Console.ReadLine());
                char secondInput = char.Parse(Console.ReadLine());
                Console.WriteLine(GetMax(firstInput,secondInput));
            }
        }
    }
}
