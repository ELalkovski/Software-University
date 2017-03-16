#include <iostream>
#include <string>
using namespace std;

int main ()
{
    /* This program reads a line from the console containing a mathematical expression. It then
      uses a bool function that checks whether the brackets in the expression () are placed correctly.
      It finally prints the result on the console. */

    /* Enter the mathematic expression in string format  */
    cout << "Please enter a mathematical expression:" << endl;
    string input;
    cin >> input;
    char currLet;
    int counter = 0;
    int expectedNumOfBrackets = 0;

    /* Check the number of the brackets */
    for(int i = 0; i < input.length(); i++){

        currLet = input[i];
        if (currLet == '(' || currLet == ')'){

                counter++;
            }
        if (currLet == '('){

                expectedNumOfBrackets += 2;
            }
    }

    /* Checks if the expression brackets were placed correctly*/
    if (counter == expectedNumOfBrackets){

        cout << "The expression is right. The brackets were placed correctly" << endl;
    }
    else {

        cout << "The expression is not right. There is missing brackets!" << endl;
    }

    return 0;
}
