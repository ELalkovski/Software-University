#include<iostream>
using namespace std;

int main()
{
    /* This program shows the sign (+ or -) of the product of three real numbers without calculating it.*/

    double firstNum, secondNum, thirdNum;
    cout << "Enter first number: ";
    cin >> firstNum;
    cout << "Enter second number: ";
    cin >> secondNum;
    cout << "Enter third number: ";
    cin >> thirdNum;

    bool firstSing = firstNum > 0;
    bool secondSing = secondNum > 0;
    bool thirdSing = thirdNum > 0;

    if(firstSing && secondSing && thirdSing)
    {
        cout << "sign: " << "+" << endl;
    }
    else
    {
        cout << "sign: " << "-" << endl;
    }

    return 0;
}
