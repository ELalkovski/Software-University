#include <iostream>
using namespace std;

int main()
{
    /* This program finds the longest sequence of equal elements in an integer array and then prints that sequence on the console */

    int currLength;
    cin >> currLength;
    int arr[currLength] = {};

    for (int i = 0; i < currLength; i++){
    cin >> arr[i];
   }

   int starSeq = 0;
   int length = 0;
   int bestLength = 0;
   int currNum;
   int nextNum;

   for (int i = 0; i < currLength - 1; i++){

        currNum = arr[i];
        nextNum = arr[i + 1];

        if(currNum == nextNum){

            length++;

            if (length > bestLength){

                starSeq = i - length;
                bestLength = length;
            }
        }
        else{
            length = 0;
        }
   }
   for (int i = starSeq + 1; i <= starSeq + bestLength + 1; i++){

        cout << arr[i] << " ";
   }

   return 0;
}
