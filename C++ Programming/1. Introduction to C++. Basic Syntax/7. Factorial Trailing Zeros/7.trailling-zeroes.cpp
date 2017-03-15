#include <iostream>
using namespace std;

int main()
{
    /*This program reads a number n and calculates the trailing zeros of its factorial.*/

    cout << "Please enter n: ";
    int n;
    cin >> n;
    int zeroesCount(0);

    for (int i=5; n/i>=1; i *= 5)
    {
        zeroesCount += n/i;
    }

    cout <<"Trailing zeroes count is: " << zeroesCount << endl;

}
