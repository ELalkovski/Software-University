#include <iostream>
#include <string>
#include <sstream>
#include <vector>
using namespace std;

class LineParser
{
public:
    string line;

    LineParser(const string& line):line(line){}

    vector<string> parseToString() const /* Gets the string line and parses it into an array of strings */
    {
        vector<string> lineVector;
        istringstream stream(this->line);
        string currToken;

        while(stream >> currToken)
        {
            lineVector.push_back(currToken);
        }

        return lineVector;
    }

    vector<int> parseToInt() const /* Gets the string line and parses it into an array of integers */
    {
        vector<int> lineVector;
        istringstream stream(this->line);
        int currNum = 0;

        while(stream >> currNum)
        {
            lineVector.push_back(currNum);
        }

        return lineVector;
    }

    vector<char> parseToChar() const/* Gets the string line and parses it into an array of chars */
    {
        vector<char> lineVector;
        istringstream stream(this->line);
        char currLett;

        while(stream >> currLett)
        {
            lineVector.push_back(currLett);
        }

        return lineVector;
    }
};


int main()
{
    string input;
    getline(cin, input);
    LineParser parsed(input);
    vector<string> stringArr = parsed.parseToString();
    cout << "Array of strings:" << endl;

    for(int i = 0; i < stringArr.size(); i++)
    {
        cout << stringArr[i] << endl;
    }
    cout << endl;

    getline(cin, input);
    LineParser parsedIntegers(input);
    vector<int> intArr = parsedIntegers.parseToInt();
    cout << "Array of integers:" << endl;

    for(int i = 0; i < intArr.size(); i++)
    {
        cout << intArr[i] << endl;
    }
    cout << endl;

    getline(cin, input);
    LineParser parsedChars(input);
    vector<char> charArr = parsedChars.parseToChar();
    cout << "Array of chars:" << endl;

    for(int i = 0; i < charArr.size(); i++)
    {
        cout << charArr[i] << endl;
    }



    return 0;
}



