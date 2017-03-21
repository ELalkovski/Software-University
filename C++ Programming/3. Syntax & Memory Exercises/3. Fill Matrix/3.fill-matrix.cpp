#include <iostream>
using namespace std;

void changeMatrix(char** matrix,const int& rows,const int& cols, int startRow, int startCol, const char& fillChar, const char& startLet)
{
    if(matrix[startRow][startCol] == startLet)
    {
        matrix[startRow][startCol] = fillChar;

        if(startRow + 1 < rows)
        {
            changeMatrix(matrix, rows, cols, startRow + 1, startCol, fillChar, startLet);
        }
        if(startRow - 1 >= 0)
        {
            changeMatrix(matrix, rows, cols, startRow - 1, startCol, fillChar, startLet);
        }
        if(startCol + 1 < cols)
        {
            changeMatrix(matrix, rows, cols, startRow, startCol + 1, fillChar, startLet);
        }
        if(startCol - 1 >= 0)
        {
            changeMatrix(matrix, rows, cols, startRow, startCol - 1, fillChar, startLet);
        }
    }
}

int main()
{
    int rows, cols, startRow, startCol;
    cin >> rows >> cols;

    char** matrix;

    matrix = new char*[rows];

    for(int i = 0; i < rows; i++)
    {
        matrix[i] = new char[cols];
    }

    for(int row = 0; row < rows; row++){
        for(int col = 0; col < cols; col++){

            cin >> matrix[row][col];
        }
    }
    char fillChar;
    cin >> fillChar;

    cin >> startRow >> startCol;

    char startLet = matrix[startRow][startCol];

    changeMatrix(matrix, rows, cols, startRow, startCol, fillChar, startLet);

    cout << endl;
    for(int row = 0; row < rows; row++){
        for(int col = 0; col < cols; col++){

            cout << matrix[row][col];
        }
        cout << endl;
    }

}
