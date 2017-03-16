#include <iostream>
using namespace std;

const int maxArrLength = 50;

void selectionSort (int arr[], int start, int endOfLength)
{
    int temp;
    int minPosition;

    for (int i = start; i < endOfLength - 1; i++){

        minPosition = i;

        for(int j = i + 1; j < endOfLength; j++){

                if(arr[j] < arr[minPosition])
                {
                    minPosition = j;
                }
        }
            if(minPosition != i)
            {
            temp = arr[i];
            arr[i] = arr[minPosition];
            arr[minPosition] = temp;
            }
    }
}

int main()
{
    /* This program implements the selection sort algorithm*/

  int arr[maxArrLength] = {};

  /* Enter array size, and then start index and end index for the selection sort function */
  int currLength;
  cin >> currLength;
  int start;
  cin >> start;
  int endOfLength;
  cin >> endOfLength;

  /* Enter array values */
  for (int i = 0; i < currLength; i++){

    cin >> arr[i];
  }

  /* Use the selection sort algorithm*/
  selectionSort(arr, start, endOfLength);
  for (int i = 0; i < currLength; i++){
    cout << arr[i] << " ";
  }

  return 0;
}
