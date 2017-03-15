# include <iostream>
using namespace std;

int main()
{
    /* This program reads from the console a sequence of N integer numbers and returns the minimal and maximal of them*/

    int n;
    int maxNum(0), minNum;
    int currNum;
    cout << "Please enter n: "
    cin >> n;


    for(int i = 0; i < n; i++)
    {
        cin >> currNum;

        if(currNum > maxNum)
        {
            maxNum = currNum;
        }
        else if(currNum < minNum)
        {
            minNum = currNum;
        }
    }

    cout << "Minimal number is: " << minNum << endl;
    cout << "Maximal number is: " << maxNum << endl;
}
