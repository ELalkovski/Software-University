function getMaxNumber(matrix)
{
    let biggestNum = Number.MIN_SAFE_INTEGER

    for (let row = 0; row < matrix.length; row++) {
        for (let col = 0; col < matrix[row].length; col++) {

            if (matrix[row][col] > biggestNum) {

                biggestNum = matrix[row][col]
            }            
        }        
    }

    return biggestNum
}

console.log(getMaxNumber([[20, 50, 10], [8, 33, 145]]))