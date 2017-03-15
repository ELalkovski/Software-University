#include <iostream>
using namespace std;

int fib(int number)
{
   if (number <= 1)
   {
      return number;
   }

   return fib(number-1) + fib(number-2);
}

int main()
{
    /* This program reads an integer and without using loops it prints its Fibonacci number.*/

    int number;
    cout << "Please enter a number: ";
    cin >> number;
    cout << "The " << number << "th Fibonacci number is: " << fib(number) << endl;
}
