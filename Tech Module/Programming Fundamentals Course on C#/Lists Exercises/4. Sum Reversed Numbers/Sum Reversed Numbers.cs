using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Sum_Reversed_Numbers
{
    class Program
    {
        public static int GetReversedSum (List<string> inputNums)
        {
            var sum = 0;
            string reversedNum = "";


            for (int i = 0; i < inputNums.Count; i++)
            {
                var currNum = inputNums[i].Reverse();
                reversedNum = string.Join("", currNum);
                int currentNum = int.Parse(reversedNum);
                sum += currentNum;
                reversedNum = "";

            }

            return sum;
        }

        static void Main(string[] args)
        {
            var inputNums = Console.ReadLine()
                .Split(' ')
                .ToList();
   
            Console.WriteLine(GetReversedSum(inputNums));

            //for (int i = 0; i < inputNums.Count; i++)
            //{
            //    string str = inputNums[i];
            //    string tempString = "";

            //    for (int j = str.Length - 1; j >= 0  ; j--)
            //    {
            //        tempString += str[j];
            //    }
            //    var temp = int.Parse(tempString);
            //    sum += temp;

            //}




        }
    }
}
