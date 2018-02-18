function extractText(str) {
    
    let resultWords = []
    let firstParenthesesIndex = str.indexOf('(')
    

    while (firstParenthesesIndex >= 0) {
        
        let secondParenthesesIndex = str.indexOf(')', firstParenthesesIndex)

        if (secondParenthesesIndex === -1) {
            
            break
        }

        let strInsideParentheses = str.substring(firstParenthesesIndex + 1, secondParenthesesIndex)
        resultWords.push(strInsideParentheses)
        firstParenthesesIndex = str.indexOf('(', secondParenthesesIndex)
    }

    console.log(resultWords.join(', '))
}

extractText('Rakiya (Bulgarian brandy) is self-made liquor (alcoholic drink)')