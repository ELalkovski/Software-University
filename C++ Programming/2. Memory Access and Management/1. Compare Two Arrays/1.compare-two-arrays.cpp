#include <iostream>
using namespace std;

const int maxArrLength = 20;

bool compareArrays (int firstArray[], int secondArray[])
{
    bool isEqual = true;

    for (int i = 0; i < maxArrLength; i++){

        if(firstArray[i] != secondArray[i]){

            isEqual = false;
            break;
        }
   }
   return isEqual;
}

int main(){
        /* This program reads two integer arrays from the console and compares them element by element.
        The comparing is done in a function . The result is printed on the console.*/

   int firstArray[maxArrLength] = {};
   int secondArray[maxArrLength] = {};
   int currLength;
   cin >> currLength;

   for (int i = 0; i < currLength; i++){
    cin >> firstArray[i];
   }
   for (int i = 0; i < currLength; i++){
    cin >> secondArray[i];
   }
   if(compareArrays(firstArray, secondArray)){

        cout << "true" << endl;
   }
   else{
        cout << "false" << endl;
   }

   return 0;

}


