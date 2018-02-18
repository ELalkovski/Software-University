function countWords(array) {

    let result = {}
    let pattern = /[^a-zA-Z0-9_]+/g
    let words = array[0].split(pattern).filter(w => w !== '')

    for (const word of words) {
        
        if (result.hasOwnProperty(word)) {
            
            result[word] += 1
        } else {

            result[word] = 1
        }
    }

    console.log(JSON.stringify(result))
}

countWords(['Far too slow, you\'re far too slow.'])