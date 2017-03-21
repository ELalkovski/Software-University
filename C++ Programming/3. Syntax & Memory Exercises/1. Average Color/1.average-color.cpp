#include <iostream>
#include <string>
#include <sstream>
using namespace std;

int* parseToDecimal(const string color)
{
    string channel;
    const int step = 2;
    int startIndex = 1;

    int* arr = new int [3];
    int currNum = 0;
    for(int i = 0; i < 3; i++){
        channel = color.substr(startIndex, step);
        stringstream stream;
        stream << channel;
        stream >> hex >> currNum;
        arr[i] = currNum;
        startIndex += 2;
    }

    return arr;
}

string parseToHex(int arr[])
{
    stringstream stream;
    for(int i = 0; i < 3; i++){

        stream << hex << arr[i];
    }
    return stream.str();
}

int main()
{
    /* This program reads two strings that represents two rgb colors in hexadecimal format.
    After that it uses one function to convert those rgb colors into decimal format and finds the average color between them in decimal format.
    Then it uses another function to return this average color into hexadecimal. The result color is printed on the console*/

    /* Receives two colors as integers in hexadecimal format with "#" as first letter*/
    string firstColor, secondColor;
    cin >> firstColor >> secondColor;
    /*-------------------------------------------------------------------------------*/

    /*------------------- Parses two colors in decimal format -----------------------*/
    int* parsedFirstColor = parseToDecimal(firstColor);
    int* parsedSecondColor = parseToDecimal(secondColor);
    /*-------------------------------------------------------------------------------*/

    /*------------------- Finds the average color between the other two ------------ */
    int averageColorDecimal[3] = {};
    int currNum = 0;
    for(int i = 0; i < 3; i++){

        currNum = (parsedFirstColor[i] + parsedSecondColor[i]) / 2;
        averageColorDecimal[i] = currNum;
    }
    /*--------------------------------------------------------------------------------*/


    /*------------------ Prints resulted color ---------------------------------------*/
    string result = parseToHex(averageColorDecimal);
    if(result.size() == 5){

        cout << "#" << result << "0" << endl;

    } else if(result.size() == 4){

        cout << "#" << result << "0"<< "0" << endl;
    }

     else if(result.size() == 3){

        cout << "#" << result << "0"<< "0"<< "0" << endl;
    }
     else {
        cout << "#" << result << endl;
    }
    /*---------------------------------------------------------------------------------*/
    return 0;
}
