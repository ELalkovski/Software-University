﻿namespace English_Name_of_Last_Digit
{
    using System;

    public class EnglishNameOfLastDigit
    {
        public static void Main()
        {
            long number = long.Parse(Console.ReadLine());
            double lastDigit = Math.Abs(number % 10);
            
            PrintNameOfDigit(lastDigit);
        }

        private static void PrintNameOfDigit(double lastDigit)
        {
            string nameOfDigit = "";

            if (lastDigit == 0)
            {
                nameOfDigit = "zero";
                Console.WriteLine(nameOfDigit);
            }
            else if (lastDigit == 1)
            {
                nameOfDigit = "one";
                Console.WriteLine(nameOfDigit);
            }
            else if (lastDigit == 2)
            {
                nameOfDigit = "two";
                Console.WriteLine(nameOfDigit);
            }
            else if (lastDigit == 3)
            {
                nameOfDigit = "three";
                Console.WriteLine(nameOfDigit);
            }
            else if (lastDigit == 4)
            {
                nameOfDigit = "four";
                Console.WriteLine(nameOfDigit);
            }
            else if (lastDigit == 5)
            {
                nameOfDigit = "five";
                Console.WriteLine(nameOfDigit);
            }
            else if (lastDigit == 6)
            {
                nameOfDigit = "six";
                Console.WriteLine(nameOfDigit);
            }
            else if (lastDigit == 7)
            {
                nameOfDigit = "seven";
                Console.WriteLine(nameOfDigit);
            }
            else if (lastDigit == 8)
            {
                nameOfDigit = "eight";
                Console.WriteLine(nameOfDigit);
            }
            else
            {
                nameOfDigit = "nine";
                Console.WriteLine(nameOfDigit);
            }
        }
    }
}
