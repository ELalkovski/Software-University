function formatText(array) {
    
    let text = array[0]
    let spacesPattern = /\s*([.,!?:;])\s*/gm
    let digitsAndDatesPattern = /\.\s*(?=[\d])/gm
    let symbolsPattern = /([.,!?:;])\s*(?=[.,!?:;])/gm
    let quotesPattern = /"(.+?)"/gm

    text = text
    .replace(spacesPattern, (match, group1) => `${group1} `)
    .replace(digitsAndDatesPattern, (match) => '.')
    .replace(symbolsPattern, (match, group1) => `${group1}`)
    .replace(quotesPattern, (match, group1) => `"${group1.trim()}"`).trim()

    console.log(text)
}

formatText('Make,sure to give:proper spacing where is needed... !')