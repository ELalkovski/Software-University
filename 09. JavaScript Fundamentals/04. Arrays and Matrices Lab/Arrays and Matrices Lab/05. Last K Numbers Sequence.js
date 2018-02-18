function printElements(n, k) {

    let result = []
    result.push(1)

    for (let i = 1; i < n; i++) {
        
        let sum = 0

        if (i < k) {
            
            for (let index = 0; index < i; index++) {
                
                sum += result[index]
            }

        } else {
            
            for (let j = (i - k); j < i; j++) {
            
                sum += result[j]
            }
        }

        result.push(sum)
    }

    console.log(result.join(' '))
}

printElements(9, 5)