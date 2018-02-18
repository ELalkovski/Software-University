function printWords(str) {

    let delimiter = /[^_a-zA-Z0-9]/g
    str = str.split(delimiter)
    console.log(str.filter(s => s !== '').join('|'))
}

printWords('_(Underscores) are also word characters')