function checkDiagonals(matrix) {

    matrix = parseMatrixToNumber(matrix)
    let leftDiagonalSum = getLeftDiagonalSum(matrix)
    let rightDiagonalSum = getRightDiagonalSum(matrix)

    if (leftDiagonalSum === rightDiagonalSum) {
        
        let notChangebleRow = 0
        let leftNotChangeableCol = 0
        let rightNotChangeableCol = matrix.length - 1

        for (let row = 0; row < matrix.length; row++) {
            for (let col = 0; col < matrix[row].length; col++) {
                
                if (col !== leftNotChangeableCol &&
                    col !== rightNotChangeableCol) {

                    matrix[row][col] = leftDiagonalSum
                }                
            }
            
            leftNotChangeableCol++
            rightNotChangeableCol--
        }

        matrix.forEach(element => {
            console.log(element.join(' '))
        })

    } else {

        matrix.forEach(element => {
            console.log(element.join(' '))
        })
    }

    function parseMatrixToNumber(matrix) {

        for (let row = 0; row < matrix.length; row++) {
            
            matrix[row] = matrix[row].split(' ').map(Number)
        }

        return matrix
    }

    function getLeftDiagonalSum(matrix) {

        let sum = 0
        let col = 0

        for (let row = 0; row < matrix.length; row++) {
            
            sum += matrix[row][col++]
        }

        return sum
    }

    function getRightDiagonalSum(matrix) {

        let sum = 0
        let col = matrix.length - 1

        for (let row = 0; row < matrix.length; row++) {
            
            sum += matrix[row][col--]
        }

        return sum
    }
}

checkDiagonals(['5 3 12 3 1',
'11 4 23 2 5',
'101 12 3 21 10',
'1 4 5 2 2',
'5 22 33 11 1']
)