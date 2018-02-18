function printElementsOnOddPositions(array) {

    let oddArray = []

    for (let i = 0; i < array.length; i++) {
        
        if (i % 2 !== 0) {
            oddArray.push(array[i])
        }
    }

    for (let i = oddArray.length - 1; i >= 0; i--) {
        
        oddArray[i] *= 2
    }

    console.log(oddArray.reverse().join(' '))
}

printElementsOnOddPositions([10, 15, 20, 25])