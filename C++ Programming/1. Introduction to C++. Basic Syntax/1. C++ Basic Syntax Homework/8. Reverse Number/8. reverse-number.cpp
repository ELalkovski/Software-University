#include <iostream>
using namespace std;

int reverseNum(int number)
{
    int reversedNumber = 0, remainder;
    while(number != 0)
    {
        remainder = number%10;
        reversedNumber = reversedNumber*10 + remainder;
        number /= 10;
    }

    return reversedNumber;
}

int main()
{
    /*This program uses a function that reverses the digits of given positive decimal number. */

    int number;
    cout << "Please enter an integer: ";
    cin >> number;

    cout << "Reversed Number = " << reverseNum(number);

    return 0;
}
