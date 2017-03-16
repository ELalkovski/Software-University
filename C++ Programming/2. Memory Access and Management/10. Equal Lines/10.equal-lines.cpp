#include <iostream>
#include <fstream>
#include <string>
using namespace std;

int eachFileLinesCount(const string& fileName)
{
    ifstream fileInput(fileName.c_str());
    int linesCount = 0;
    string line;

    for(line; getline(fileInput, line);){

        linesCount++;
    }
    return linesCount;
}

string* lineStrings(const string& fileName)
{
    ifstream fileInput(fileName.c_str());
    int arrLength = 0;

    string line;
    for(line; getline(fileInput, line);){

        arrLength++;
    }
    string* arr = new string[arrLength];
    int i = 0;
    ifstream readAgainFile(fileName.c_str());
    while(getline(readAgainFile, line)){
        arr[i] = line;
        i++;
    }

    return arr;
}

int main()
{
    /* This program reads two file names and after that checks if their lines count are equal.
    If they are, program checks if the elements of those lines are also equal. Results are printed on the console. */

    /* -------- Reads file names --------------*/
    cout << "Please enter name of first file: ";
    string firstFileName, secondFileName;
    cin >> firstFileName;
    cout << "Please enter name of second file: ";
    cin >> secondFileName;
    /*-----------------------------------------*/

    /*-------------Checks if the count of the lines are equal and prints result if the answer is negative---------------------*/
    if(eachFileLinesCount(firstFileName) == eachFileLinesCount(secondFileName)){

    /*--------------Checks if elements of those lines are equal and prints results--------------------------------------------*/
            string* firstFileArr = lineStrings(firstFileName);
            string* secondFileArr = lineStrings(secondFileName);
            bool isEqual = true;
        for(int i = 0; i < eachFileLinesCount(firstFileName); i++){

            if(firstFileArr[i] != secondFileArr[i]){
                isEqual = false;
                break;
            }
        }

        if(isEqual){
            cout << "All lines are equal!" << endl;
        } else {
            cout << "Lines are not equal" << endl;
        }
    /*------------------------------------------------------------------------------------------------------------------------*/

    } else {

        cout << "Lines count of each file is different." << endl;
    }

    return 0;
    /*------------------------------------------------------------------------------------------------------------------------*/
}
