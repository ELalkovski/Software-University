function rotateArr(array) {

    let rotationsCount = array.pop(array[array.length - 1])
    let length = array.length
    let rotationsCountNormalized = rotationsCount = ((rotationsCount % length) + length) % length;
    
    for (let i = 0; i < rotationsCountNormalized; i++) {
        
        let elementToUnshift = array.pop(array[array.length - 1])
        array.unshift(elementToUnshift)
    }

    console.log(array.join(' '))
}

rotateArr([1,
    2,
    3,
    4,
    2]
    )