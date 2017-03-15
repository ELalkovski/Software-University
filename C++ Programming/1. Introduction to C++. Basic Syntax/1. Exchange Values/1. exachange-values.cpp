#include <iostream>
using namespace std;

int main()
{
    /* This program examines two integer variables and exchanges their values
     if the first one is greater than the second one.*/

    int a, b;
    cout << "Please enter a: " << endl;
    cin >> a;
    cout << "Please enter b: " << endl;
    cin >> b;

    if(a > b)
    {
        b = a;
    }
    cout << "b = " << b << endl;

    return 0;
}
