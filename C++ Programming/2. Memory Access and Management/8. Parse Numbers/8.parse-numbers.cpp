#include <iostream>
#include <string>
#include <sstream>
using namespace std;

int* parseNumbers (const string& input, int& resultLength)
{
    istringstream inputStream(input);
    int currNum = 0;
    while (inputStream >> currNum){

        resultLength++;
    }
    int* parsedArr = new int[resultLength];
    istringstream readAgainInput(input);
    int i = 0;
    while(readAgainInput >> currNum){

        parsedArr[i] = currNum;
        i++;
    }
    return parsedArr;

}

int main()
{
    /* This program reads a number of lines and then for every line, receives a string of numbers, separated by whitespace.
     After that, it uses a function to parse every line (array) into integers. Every integer is summed and the result is
      printed on the console. */

    cout << "Please enter lines of input count: ";
    string input;
    int inputCount;
    cin >> inputCount;/* Reads how many lines of input the program will receive*/
    int resultLength = 0;
    int sum = 0;
    cout << "Please enter " << inputCount << " input lines:" << endl;

    while (inputCount >= 0){


        getline(cin, input); /*Reads a line(array) of numbers as a string */
        int* parsed = parseNumbers(input, resultLength); /* Uses the created function to parses every number from string to integer */

        for(int i = 0; i < resultLength; i++){

            sum += parsed[i]; /* Sums every number, from every line */
        }
        inputCount--;
        resultLength = 0;

    }
    cout <<"Total sum of all array lines is: " << sum << endl;

    return 0;
}
