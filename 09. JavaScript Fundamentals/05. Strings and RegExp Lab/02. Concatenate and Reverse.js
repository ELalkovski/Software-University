function printReversedConcatenatedStrings(array) {
    
    let result = ''

    for (let i = array.length - 1; i >= 0 ; i--) {
        
        let currStr = array[i].split('').reverse().join('')
        result += currStr
    }

    console.log(result)
}

printReversedConcatenatedStrings(['I', 'am', 'student'])