function matchNumbers(arrayStr) {

    let pattern = /[0-9]+/g
    let numbers = []

    for (let str of arrayStr) {
        
        let match = str.match(pattern)

        if (match !== null) {
            match.forEach(el => numbers.push(el))            
        }        
    }

    console.log(numbers.join(' '))
}

matchNumbers(['Let’s go11!!!11!',
    'Okey!1!'    
    ])