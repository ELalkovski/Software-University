function getEvenPositionedElements(array) {

    let result = ''

    for (let i = 0; i < array.length; i++) {
        
        if (i % 2 === 0) {
            
            result += `${array[i]} `
        }
    }

    return result
}

console.log(getEvenPositionedElements(['20', '30', '40']))