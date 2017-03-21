#include <iostream>
#include <string>
#include <sstream>
#include <vector>
#include <stdlib.h>
#include <cctype>
using namespace std;

int main()
{
    /*This program reads two lines of input. On the first line it reads string of words that can be separated by
    those signs : ',', '.', ';', '!', '?' 'space'. On the second line it reads a string that contains word and a integer number.
    After that the program checks how many of the words on the first line are similar with the word on the second line
    (words are considered similar if they have the same length, start with the same letter, and a minimum percentage 'P' of their letters match)
    Result is printed on the console.*/

    string firstLine, secondLine, currWord, clearedString;
    int index = 0;
    vector<string> words;
    vector<string> checkers;

    getline(cin, firstLine);

    char currLett;
    for(int i = 0; i < firstLine.size(); i++){

        currLett = tolower(firstLine[i]);
        if(currLett == ',' || currLett == '.' || currLett == '!' || currLett == '?' || currLett == ';'){
            currLett = ' ';
        }
        clearedString += currLett;
    }
    istringstream streamFirstInput(clearedString);
    while(streamFirstInput >> currWord){

        words.push_back(currWord);
    }

    getline(cin, secondLine);
    istringstream streamSecondInput(secondLine);
    while(streamSecondInput >> currWord){

        checkers.push_back(currWord);
    }
    string a = checkers[1];
    int minimumForMatch = atoi(a.c_str());
    int matchesLettCounter = 0;
    float matchesPercentage = 0;
    int matchcingWords = 0;
    float wordSize = 0;

    for( int i = 0; i < words.size(); i++){
        string currWord = words[i];
        string checkWord = checkers[0];

        if(currWord.length() == checkWord.length() && currWord[0] == checkWord[0]){

                istringstream firstLettStream(currWord);
                istringstream secondLettStream(checkWord);
                char lettWord;
                char lettCheck;

                while(firstLettStream >> lettWord && secondLettStream >> lettCheck){
                        wordSize++;

                    if(lettWord == lettCheck){
                        matchesLettCounter++;
                    }
                }
                matchesPercentage = (matchesLettCounter / wordSize) * 100;
                if(matchesPercentage >= minimumForMatch){
                    matchcingWords++;
                }
        }
        wordSize = 0;
        matchesLettCounter = 0;
    }


    cout << matchcingWords;
}
