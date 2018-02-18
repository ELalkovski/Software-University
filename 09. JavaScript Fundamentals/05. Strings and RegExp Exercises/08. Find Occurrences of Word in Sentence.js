function countOccurences(str, word) {

    let regex = new RegExp('\\b' + word + '\\b', 'gi')
    let match
    let result = []

    while ( match = regex.exec(str) ){
        result.push(match);
    }

    console.log(result.length)
}

countOccurences('How do you plan on achieving that? How? How can you even think of that?',
'how')