#include <iostream>
#include <string>
#include <vector>
#include <sstream>
using namespace std;

/* This program receives as input string and formatter  prefix string and uses StringFormatter class to change every founded prefix
 with the correct word.*/

class StringFormatter
{
    string& input;
    string formatPrefix;
    public:
    StringFormatter(string& input, const string& formatPrefix):
        input(input),
        formatPrefix(formatPrefix){
        }

    void format(vector<string> insertVector)
    {
        if(insertVector.size() == 0)
        {
            throw 0;
        }
        else
        {
            istringstream stream(this->input);
            vector<string> inputVector;
            string currToken;

            while(stream >> currToken)
            {
                inputVector.push_back(currToken);
            }

            int prefixCounter = 0;

            for(int i = 0; i < inputVector.size(); i++)
            {
                if(inputVector[i] == this->formatPrefix)
                {
                    prefixCounter++;
                }
            }

            for(int i = 0; i <= prefixCounter; i++)
            {
                if(this->input.find(formatPrefix))
                {
                    this->input.replace(input.find(formatPrefix),formatPrefix.size(),insertVector[i]);
                }
            }

        }

    }
};

int main()
{
    string input = "Dear *:, Our company *: wants to make you a Donation Of *: Million *: in good faith. Please send us a picture of your credit card.";
    StringFormatter formatter(input, "*:");
    formatter.format(vector<string>{"Ben Dover", "Totally Legit NonSpam Ltd", "13", "Leva"});
    cout << input;

    return 0;
}
