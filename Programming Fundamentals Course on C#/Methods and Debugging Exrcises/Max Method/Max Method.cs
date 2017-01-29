using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_Method
{
    class MaxMethod
    {
        public static int GetMax (int firstNum, int secondNum)
        {
            if (firstNum > secondNum) return firstNum;
            else return secondNum;
        }

        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());

            if (GetMax(firstNum, secondNum) > thirdNum) Console.WriteLine(GetMax(firstNum,secondNum));
            else Console.WriteLine(thirdNum);
        }
    }
}
