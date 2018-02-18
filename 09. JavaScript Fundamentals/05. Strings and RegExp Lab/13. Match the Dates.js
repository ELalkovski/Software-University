function getMatchedDates(array) {
    
    let validDates = [], match
    let pattern = /\b([0-9]{1,2})-([A-Z][a-z]{2})-([0-9]{4})\b/g

    for (let line of array) {
        
         while (match = pattern.exec(line)) {
             
            validDates.push(`${match[0]} (Day: ${match[1]}, Month: ${match[2]}, Year: ${match[3]})`)
         }
    }

    console.log(validDates.join('\n'))
}

getMatchedDates(['I am born on 30-Dec-1994.',
    'This is not date: 512-Jan-1996.',
    'My father is born on the 29-Jul-1955.'
    ])