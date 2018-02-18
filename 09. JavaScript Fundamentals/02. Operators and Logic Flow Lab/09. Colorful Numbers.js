function printColorfulNumbers(number){

    let result = '<ul>\n'

    for (let i = 1; i <= number; i++) {
        
        if(i % 2 === 0){
            result += '<li><span style=\'color:blue\'>'
            result += i
            result += '</span></li>\n'
        } else {
            result += '<li><span style=\'color:green\'>'
            result += i
            result += '</span></li>\n'
        }
    }

    result += '</ul>'
    return result
}

console.log(printColorfulNumbers(10))