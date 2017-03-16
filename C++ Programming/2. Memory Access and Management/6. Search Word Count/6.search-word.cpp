#include <iostream>
#include <string>
#include <sstream>
#include<limits>
using namespace std;

int findSearchWordCount (istringstream& inputStream, string& searchWord)
{
    int searchCount = 0;
    string currWord = "";
    while (inputStream >> currWord)
    {
        if(currWord.find(searchWord) != string::npos)
        {
            searchCount++;
        }
    }

    return searchCount;
}

int main()
{
    /* This program reads some text, then reads a search word. After that is uses a function to
    count how many times the search word is contained in the text. The result count is printed on the console.*/

    string input;
    getline(cin, input);
    istringstream inputStream(input);
    string currWord = "";
    string searchWord;
    cin >> searchWord;

    cout << findSearchWordCount(inputStream, searchWord) << endl;

    return 0;

}
