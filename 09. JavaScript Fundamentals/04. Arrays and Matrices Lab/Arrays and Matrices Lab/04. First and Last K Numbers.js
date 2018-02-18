function printElements(array) {

    let elementsToPrintCount = array[0]
    let lastElementsStartPosition = array.length - elementsToPrintCount
    let firstLine = ''
    let secondLine = ''

    for (let i = 1; i <= elementsToPrintCount; i++) {
        
        firstLine += array[i] + ' '
    }

    for (let i = lastElementsStartPosition; i < array.length; i++) {
        
        secondLine += array[i] + ' '
    }

    console.log(firstLine)
    console.log(secondLine)
}

printElements([2,7, 8, 9])