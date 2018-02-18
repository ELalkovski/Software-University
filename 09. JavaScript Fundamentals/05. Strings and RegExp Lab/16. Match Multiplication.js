function matchNumbersAndMultiply(str) {
    
    let pattern = /(-?[0-9]+)[\s]*\*[\s]*(-?[0-9]+[.]*[0-9]*)/g
    str = str.replace(pattern, (match, firstNum, secondNum) => Number(firstNum) * Number(secondNum))

    console.log(str)
}

matchNumbersAndMultiply('My bill: 2*2.50 (beer); 2* 1.20 (kepab); -2  * 0.5 (deposit).')