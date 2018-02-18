function addOrRemoveNumbers(array) {

    let loopsCount = array.length
    let newArr = []
    let number = 1

    for (let i = 0; i < loopsCount; i++) {

        let currCommand = array[i]

        if(currCommand === 'add') {

            newArr.push(number)
        } else {

            newArr.pop(number)
        }

        number++
    }

    if(newArr.length === 0) {
        console.log('Empty')
    } else {
        newArr.forEach((el) => {console.log(el)})
    }
}

addOrRemoveNumbers(['add',
    'add',
    'add',
    'add']
    )