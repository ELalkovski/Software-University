#include <iostream>
#include <string>
#include <sstream>
using namespace std;

void makeTitleCase(string& input)
{
    for (int i = 0; i < input.size(); i++) {

        char currSymbol = input[i];
            if(currSymbol == ' ' || currSymbol == ','){

                input[i + 1] = toupper(input[i + 1]);
            }
            else if (i == 0){

                input[i] = toupper(input[i]);
            }
        }
}

int main ()
{
    /* This program reads an array of strings and then uses a function to change the first letter of every word
    to start with a capital letter. The result is printed on the console. */

    /* Reads the input string line */
    string input;
    getline(cin, input);

    /* Uses created function to turn every first letter of a word capital*/
    makeTitleCase(input);

    /* Prints the capitalized string line*/
    cout << input << endl;

    return 0;
}
