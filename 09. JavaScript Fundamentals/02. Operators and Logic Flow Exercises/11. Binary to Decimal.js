function convertBinaryToDecimal(binaryNumber){

    let decimalNumber = 0
    let power = 0

    for (let i = binaryNumber.length - 1; i >= 0; i--) {
        
        let currentDigit = binaryNumber[i]
        currentDigit *= Math.pow(2, power)
        decimalNumber += currentDigit
        power++
    }

    console.log(decimalNumber)
}

convertBinaryToDecimal('11110000')