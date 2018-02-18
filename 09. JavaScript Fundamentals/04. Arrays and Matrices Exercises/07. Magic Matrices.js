function checkIfMatrixIsMagical(array) {

    const reducer = (accumulator, currentValue) => accumulator + currentValue;

    function checkRows(array) {

        let currentSum = 0
        let prevSum = currentSum

        for (let i = 0; i < array.length; i++) {
            
            currentSum = array[i].reduce(reducer) 

            if (i === 0) {

                prevSum = currentSum
            } else {

                if (prevSum !== currentSum) {
                    return false
                }
            }
        }

        return true
    }

    function checkCols(array) {

        let currentSum = 0
        let prevSum = currentSum

        for (let col = 0; col < array.length; col++) {

            currentSum = 0

            for (let row = 0; row < array.length; row++) {
                
                currentSum += array[row][col]
            }
            
            if (col === 0) {

                prevSum = currentSum
            } else {

                if (prevSum !== currentSum) {
                    return false
                }
            }
        }

        return true
    }

    if (checkCols(array) && checkRows(array)) {

        return true
    } else {

        return false
    }
}

console.log(checkIfMatrixIsMagical([[1, 0, 0],
    [0, 0, 1],
    [0, 1, 0]]     
   ))