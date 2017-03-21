#include <iostream>
#include <string>
#include <sstream>
#include <vector>
#include <limits>
using namespace std;

/* Function used to fill the main array on which will be performed some operations */
vector<int> fillArr(string arrAsString)
{
    vector<int> arr;
    getline(cin, arrAsString);
    istringstream streamArr(arrAsString);
    int currNum = 0;

    while(streamArr >> currNum)
    {
        arr.push_back(currNum);
    }
    return arr;
}
/* Function used to create a two dimensional array with the commands names, because by the given exercise, different names can do the same operation.*/
string** getCommandArr(const int& operationsCount)
{
    string ** commandArr;
    commandArr = new string*[4]; /* Creating the first dimension the commands array, and by the given exercise, the commands are 4*/

    /* Creating the second dimension of the commands array, which is given by the input */
    for(int i = 0; i < 4; i++)
    {
        commandArr[i] = new string[operationsCount];
    }

    for(int rows = 0; rows < 4; rows++)
    {
        for(int cols = 0; cols < operationsCount; cols++)
        {
            commandArr[rows][cols] = "unknownX";
        }
    }

    int zeros = 0;
    int ones = 0;
    int twos = 0;
    int threes = 0;

    /* Switching commands names with the ones given by the input*/
    for(int i = 0; i < operationsCount; i++)
    {
        string currCommandName;
        int currCommandId;
        cin >> currCommandName;
        cin >> currCommandId;
        cin.ignore();

        switch(currCommandId)
        {
        case 0:
            {
                commandArr[currCommandId][zeros] = currCommandName;
                zeros++;
            }
            break;

        case 1:
            {
                commandArr[currCommandId][ones] = currCommandName;
                ones++;
            }
            break;

        case 2:
            {
                commandArr[currCommandId][twos] = currCommandName;
                twos++;
            }
            break;

        case 3:
            {
                commandArr[currCommandId][threes] = currCommandName;
                threes++;
            }
        }
    }

    return commandArr;
}

/* Function used to find the id of the command name */
int getCommandId (const int& operationsCount, string ** commandArr, const string& nameOfCommand)
{
    string currCommand;
    for(int i = 0; i < 4; i++)
    {
        for(int j = 0; j < operationsCount; j++)
        {
            currCommand = *(*(commandArr + i) + j);
            if (currCommand == nameOfCommand)
            {
                return i;
            }
        }
    }
}

/*Function used to find the sum of the elements from the start index to the end index*/
int getSum(vector<int>& arr, const int& startIndex, const int& endIndex)
{
    int sum = 0;
    int counter = 0;
    vector<int>::iterator myArrVectorIterator;

    for(myArrVectorIterator = arr.begin() + startIndex;
        myArrVectorIterator != arr.end();
        myArrVectorIterator++)
    {
        sum += *myArrVectorIterator;
        counter++;
        if(counter == endIndex)
        {
            break;
        }
    }

    return sum;
}

/*Function used to find the average element from the start index to the end index*/
int getAverage(vector<int>& arr, const int& startIndex, const int& endIndex)
{
    int sum = 0;
    int numbersCount = 0;
    int counter = 0;
    vector<int>::iterator myArrVectorIterator;

    for(myArrVectorIterator = arr.begin() + startIndex;
        myArrVectorIterator != arr.end();
        myArrVectorIterator++)
    {
        sum += *myArrVectorIterator;
        numbersCount++;

        counter++;
        if(counter == endIndex)
        {
            break;
        }
    }


    return (int)sum / numbersCount;;
}

/*Function used to find the max element from the start index to the end index*/
int getMax(vector<int>& arr, const int& startIndex, const int& endIndex)
{
    int maxNum = numeric_limits<int>::min();
    int currNum = 0;
    int counter = 0;
    vector<int>::iterator myArrVectorIterator;

    for(myArrVectorIterator = arr.begin() + startIndex;
        myArrVectorIterator != arr.end();
        myArrVectorIterator++)
    {
        currNum = *myArrVectorIterator;

        if(currNum > maxNum)
        {
            maxNum = currNum;
        }
        counter++;
        if(counter == endIndex)
        {
            break;
        }
    }

    return maxNum;
}

/*Function used to find the min element from the start index to the end index*/
int getMin(vector<int>& arr, const int& startIndex, const int& endIndex)
{
    int minNum = numeric_limits<int>::max();
    int currNum = 0;
    int counter = 0;
    vector<int>::iterator myArrVectorIterator;

    for(myArrVectorIterator = arr.begin() + startIndex;
        myArrVectorIterator != arr.end();
        myArrVectorIterator++)
    {
        currNum = *myArrVectorIterator;

        if(currNum < minNum)
        {
            minNum = currNum;
        }
        counter++;
        if(counter == endIndex)
        {
            break;
        }
    }

    return minNum;
}

/*Function used to receive commands in the "string int int" format until the string "end" is received and execute the following by the string operation.
After that it puts then into stream and returns is as a result string*/

string executeOperations(vector<int>& arr, const int& operationsCount, string** commandArr, int& operationsExecuted)
{
    stringstream output;
    string currCommand;

    while(true)
    {
        getline(cin, currCommand);

        if(currCommand == "end")
        {
            break;
        }

        operationsExecuted++;

        stringstream currCommandElements(currCommand);
        int startIndex, endIndex, commandId;
        string nameOfCommand;
        currCommandElements >> nameOfCommand;
        currCommandElements >> startIndex >> endIndex;

        commandId = getCommandId(operationsCount, commandArr, nameOfCommand);

        int result = 0;

        switch(commandId)
        {
        case 0:
            {
                result = getSum(arr, startIndex, endIndex);
            }
            break;

        case 1:
            {
                result = getAverage(arr, startIndex, endIndex);
            }
            break;

        case 2:
            {
                result = getMin(arr, startIndex, endIndex);
            }
            break;

        case 3:
            {
                result = getMax(arr, startIndex, endIndex);
            }
        }
        output << nameOfCommand << "(" << startIndex << "," << endIndex << ")=" << result << ",";
    }

    return output.str();
}

int main()
{
    string arrAsString;
    vector<int> arr = fillArr(arrAsString); /*Fill the array with elements*/


    int operationsCount;
    cin >> operationsCount; /* Read operations count*/

    string** commandArr = getCommandArr(operationsCount); /* Get command array elements*/
    int operationsExecuted = 0;
    string printOutput =  executeOperations(arr, operationsCount, commandArr, operationsExecuted); /* Execute operations till "end" is received"*/
    printOutput = printOutput.substr(0, printOutput.size() - 1);

    cout << "[" << operationsExecuted << "]" << "{" << printOutput << "}" << endl; /*Print results*/
    return 0;
}
