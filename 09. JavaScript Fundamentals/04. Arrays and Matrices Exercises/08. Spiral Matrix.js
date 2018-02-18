function createSpiralMatrix(rows, cols) {

    let elementValue = 1
    let elementsCount = rows * cols
    let matrix = initializedMatrix(rows, cols)
    let currentRow = 0
    let currentCol = 0
    let rotation = 0
     
    while (elementValue <= elementsCount) {
        
        // left to right
        for (let col = rotation; col < cols - rotation; col++) {
                
            matrix[currentRow][currentCol++] = elementValue++
        }

        currentCol--

        // top to down
        for (let row = ++currentRow; row <= rows - 1 - rotation; row++) {
            
            matrix[currentRow++][currentCol] = elementValue++
        }

        currentRow--

        // right to left
        for (let col = --currentCol; col >= rotation; col--) {
            
            matrix[currentRow][currentCol--] = elementValue++
        }

        currentCol++
        
        //down to up
        for (let row = --currentRow; row > rotation; row--) {
            
            matrix[currentRow--][currentCol] = elementValue++
        }

        rotation++
        currentRow++
        currentCol++
    }

    for (let row = 0; row < matrix.length; row++) {
        
        console.log(matrix[row].join(' '))
    }

    function initializedMatrix(rows, cols) {

        let matrix = []

        for (let i = 0; i < rows; i++) {
            
            matrix.push('0'.repeat(cols).split('').map(Number))
        }

        return matrix
    }
}

createSpiralMatrix(3, 3)