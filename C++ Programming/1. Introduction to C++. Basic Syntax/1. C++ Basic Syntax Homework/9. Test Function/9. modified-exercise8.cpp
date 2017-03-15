#include <iostream>
using namespace std;

int reverseNum(int number)
{
    int reversedNumber(0), remainder;
    while(number != 0)
    {
        remainder = number%10;
        reversedNumber = reversedNumber*10 + remainder;
        number /= 10;
    }

    return reversedNumber;
}

bool test(int number, int expectedAnswer)
{
    int result = reverseNum(number);
    bool isRev = true;

    if(result != expectedAnswer)
    {
        isRev = false;
    }

    return isRev;
}

int main()
{
    /* This program uses a bool test function to check if other function works correctly.*/

    int number, remainder;
    bool isSucessfull = true;

    if(!test(256, 652))
    {
        isSucessfull = false;
    }
    else if(!test(1256, 6521))
    {
        isSucessfull = false;
    }
    else if(!test(3891, 1983))
    {
        isSucessfull = false;
    }
    else if(!test(23, 32))
    {
        isSucessfull = false;
    }
    else if(!test(138567, 765831))
    {
        isSucessfull = false;
    }
    else if(!test(95634, 43659))
    {
        isSucessfull = false;
    }
    else if(!test(3577, 7753))
    {
        isSucessfull = false;
    }
    else if(!test(11032, 23011))
    {
        isSucessfull = false;
    }
    else if(!test(4325, 5234))
    {
        isSucessfull = false;
    }
    else if(!test(20003, 30002))
    {
        isSucessfull = false;
    }

    if(isSucessfull)
    {
        cout << "True" << endl;
    }
    else
    {
        cout << "False" << endl;
    }

    return 0;
}
