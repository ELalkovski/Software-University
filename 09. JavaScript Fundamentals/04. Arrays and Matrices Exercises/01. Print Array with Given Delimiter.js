function printArr(array) {

    let delimiter = array.pop(array[array.length - 1])

    console.log(array.join(delimiter))
}

printArr(['One','Two', 'Three', 'Four', 'Five', '-'])