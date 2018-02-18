function countWords(array) {

    let result = new Map()
    let pattern = /[^a-zA-Z0-9_]+/g
    let words = array[0].split(pattern).filter(w => w !== '')

    for (const word of words) {

        if (result.has(word.toLowerCase())) {
            
            result.set(word.toLowerCase(), result.get(word.toLowerCase()) + 1)
        } else {

            result.set(word.toLowerCase(), 1)
        }
    }

    let sortedKeys = Array.from(result.keys()).sort((a, b) => a.localeCompare(b))

    for (const key of sortedKeys) {
        
        console.log(`\'${key}\' -> ${result.get(key)} times`)
    }
}

countWords(['JS devs use Node.js for server-side JS. JS devs use JS. -- JS for devs --'])