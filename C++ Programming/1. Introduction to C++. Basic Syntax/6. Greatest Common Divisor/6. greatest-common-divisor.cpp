#include <iostream>
#include <cmath>
using namespace std;

int main()
{
    /* This program calculates the greatest common divisor (GCD) of given two numbers. It Uses the Euclidean algorithm*/

    int firstNum, secondNum;
    cout<<"Enter First Number : ";
    cin >> firstNum;

    cout<<"Enter Second Number : ";
    cin >> secondNum;

    int greatestCommonDivisor;

    for(int i = 1; i <=firstNum && i<= secondNum; i++)
    {
        if((firstNum % i == 0) && (secondNum % i == 0))
        {
            greatestCommonDivisor = i;
        }
    }

    cout << "Greatest common divisor is: " << greatestCommonDivisor << endl;

    return 0;
}
