function printSquare(n = 5) {

    let result = ''

    for (let row = 1; row <= n; row++) {
        
        for (let col = 1; col <= n; col++) {
            
            result += '* '
            
        }
        result += '\n'
    }

    console.log(result)
}

printSquare(5)