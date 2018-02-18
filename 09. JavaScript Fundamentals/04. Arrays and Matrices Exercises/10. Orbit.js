function createMatrixOrbit(array) {

    let rows = array[0]
    let cols = array[1]
    let startRow = array[2]
    let startCol = array[3]

    let matrix = initializedMatrix(rows, cols)    
    let elementValue = 2
    let waves = 1

    matrix[startRow][startCol] = 1

    while (!isMatrixFilled(matrix)) {
        
        let topX = Math.max(0, startRow - waves)
        let topY = Math.max(0, startCol - waves)
        let bottomX = Math.min(rows - 1, startRow + waves)
        let bottomY = Math.min(cols - 1, startCol + waves)

        for (let row = topX; row <= bottomX; row++) {
            for (let col = topY; col <= bottomY; col++) {
                
                if (matrix[row][col] === 0) {

                    matrix[row][col] = elementValue
                }
            }            
        }

        elementValue++
        waves++
    }

    matrix.forEach(row => console.log(row.join(' ')))

    function isMatrixFilled(matrix) {

        for (let row = 0; row < matrix.length; row++) {
            for (let col = 0; col < matrix[0].length; col++) {
                
                if (matrix[row][col] === 0) {
                    return false
                }
            }
        }

        return true
    }

    function initializedMatrix(rows, cols) {

        let matrix = []

        for (let i = 0; i < rows; i++) {
            
            matrix.push('0'.repeat(cols).split('').map(Number))
        }

        return matrix
    }
}

createMatrixOrbit([5, 5, 2, 2])