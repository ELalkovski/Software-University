function createObject(array){

    let object = {}

    for (var i = 0; i < array.length; i+= 2) {
        
        object[array[i]] = array[i + 1]
    }
    return object
}

console.log(createObject(['name', 'Pesho', 'age', '23', 'gender', 'male']))