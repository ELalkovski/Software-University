function capitalizedWord(str) {
    
    str = str.split(' ')
    let result = []

    for (let word of str) {
        
        word = word.split('')

        for (let i = 0; i < word.length; i++) {
            
            if (i === 0) {

                word[i] = word[i].toUpperCase()
            } else {
                
                word[i] = word[i].toLowerCase()
            }
        }
        
        word = word.join('')
        result.push(word)
    }

    console.log(result.join(' '))
}

capitalizedWord('Was that Easy? tRY thIs onE for SiZe!')