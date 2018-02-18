function sumFirstAndLastElement(array) {

    let firstNum = parseInt(array[0])
    let lastNum = parseInt(array[array.length - 1])

    return firstNum + lastNum
}

console.log(sumFirstAndLastElement(['20', '30', '40']))