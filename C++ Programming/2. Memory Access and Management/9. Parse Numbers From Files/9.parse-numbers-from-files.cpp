#include <iostream>
#include <string>
#include <fstream>
using namespace std;

int* parseNumbers (const string& inputFileName, int& resultLength)
{
    ifstream fileInput(inputFileName.c_str());
    int currNum = 0;
    while (fileInput >> currNum){

        resultLength++;
    }
    int* parsedArr = new int[resultLength];
    ifstream readAgainInput(inputFileName.c_str());
    int i = 0;
    while(readAgainInput >> currNum){

        parsedArr[i] = currNum;
        i++;
    }
    return parsedArr;

}

int main()
{
    /*This program reads strings from a given input file, parses them to integers and sums them after that.
     At the end, result is written in a given output file. */

    cout << "Please enter name of input file: ";
    string inputFileName, outputFileName;
    cin >> inputFileName;
    cout << "Please enter name of output file: ";
    cin >> outputFileName;
    int resultLength = 0;
    int sum = 0;

    int* parsed = parseNumbers(inputFileName, resultLength); /* Uses the created function to parse every number from string to integer */

        for(int i = 0; i < resultLength; i++){

            sum += parsed[i]; /* Sums every number, from every line */
        }
        resultLength = 0;


    ofstream outputStream(outputFileName.c_str()); /* Writes results in the given output file*/
    outputStream << sum << endl;

    return 0;
}
