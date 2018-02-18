function turnWordsIntoUpperCase(str) {

    let upperStr = str.toUpperCase()
    let words = upperStr.split(/[\W]+/)
    words = words.filter(w => w != '')

    console.log(words.join(', '))
}

turnWordsIntoUpperCase('Hi, how are you?')