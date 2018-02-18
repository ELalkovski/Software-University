function calculate(array) {

    let sum = 0
    let inversedSum = 0
    let concatenatedNumbers = ''

    for (let i = 0; i < array.length; i++) {
        
        sum += array[i]
        inversedSum += 1 / array[i]
        concatenatedNumbers += array[i]
    }

    console.log(sum)
    console.log(inversedSum)
    console.log(concatenatedNumbers)
}

calculate([1, 2, 3])