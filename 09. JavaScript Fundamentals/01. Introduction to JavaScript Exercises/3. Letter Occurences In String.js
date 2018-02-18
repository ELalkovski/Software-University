function countOccurences(str, letter){

    let occurrenceCount = 0;

    for (let index = 0; index < str.length; index++) {
        
        let currentLetter = str[index]

        if(currentLetter === letter){
            occurrenceCount++
        }
    }

    console.log(occurrenceCount)
}

countOccurences('panther', 'n')