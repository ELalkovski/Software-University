function printElements(array) {

    let n = array.pop(array[array.length - 1])

    array = array.filter((el, i) => {return i % n === 0})

    array.forEach((el) => {console.log(el)})
}

printElements([5,
    20,
    31,
    4,
    20,
    2
    ])