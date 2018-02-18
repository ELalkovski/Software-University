function getDiagonalSums(matrix) {

    let leftDiagonalColIndex = 0
    let rightDiagonalColIndex = matrix[0].length - 1
    let leftSum = 0
    let rightSum = 0

    for (let row = 0; row < matrix.length; row++) {

        leftSum += matrix[row][leftDiagonalColIndex]
        rightSum += matrix[row][rightDiagonalColIndex]
        leftDiagonalColIndex++
        rightDiagonalColIndex--  
    }

    console.log(`${leftSum} ${rightSum}`)
}

getDiagonalSums([[3, 5, 17],
    [-1, 7, 14],
    [1, -8, 89]]  
   )