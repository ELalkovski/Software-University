function appendNumbers(array) {

    let newArr = []

    for (let i = 0; i < array.length; i++) {
        
        if (array[i] < 0) {
            
            newArr.unshift(array[i])
        } else {

            newArr.push(array[i])
        }
    }

    for (let i = 0; i < newArr.length; i++) {
        
        console.log(newArr[i])
    }
}

appendNumbers([7, -2, 8, 9])