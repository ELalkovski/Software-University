# include <iostream>
using namespace std;

int main()
{
    /* This program reads a number N and prints all the numbers from 1 to N*/

    int n;
    cout << "Please enter n: ";
    cin >> n;

    for(int i = 1; i <= n; i++)
    {
        cout << i << endl;
    }
    return 0;
}
