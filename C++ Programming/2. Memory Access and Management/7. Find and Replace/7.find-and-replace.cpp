#include <iostream>
#include <string>
#include <sstream>
using namespace std;

int main()
{
    /* This program reads a line of text, another line with a find string and another line with a replace string.
    Any part of text which matches the find string is replaced with the replace string.
    Finally the resulting text is printed on the console.*/

    string input;
    getline(cin, input);
    istringstream inputStream(input);
    string findWord;
    cin >> findWord;
    string replaceWord;
    cin >> replaceWord;
    ostringstream outputStream;

    string currWord = "";
    while (inputStream >> currWord)
    {

        if(currWord.find(findWord) != string::npos)
        {
            int start = currWord.find(findWord);
            currWord.replace(start, findWord.length(),replaceWord);

        }
            outputStream << currWord << " ";
    }
    cout << outputStream.str() << endl;

    return 0;
}
