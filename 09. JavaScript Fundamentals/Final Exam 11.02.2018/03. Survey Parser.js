function parseData(text) {
    let surveyPattern = /.*<svg>.*<\/svg>.*/gm
    let formatPattern = /\s*<cat><text>.*\[(.*)\]<\/text><\/cat>\s*<cat>(<g><val>(\d+)<\/val>(\d+)<\/g>.+?)<\/cat>/gm
    let valuesPattern = /<g><val>(\d+)<\/val>(\d+)<\/g>/gm
    let totalCount = 0
    let totalValueSum = 0

    let surveyMatch = surveyPattern.exec(text)

    if (surveyMatch) {
        
        let formatMatch = formatPattern.exec(text)

        if (formatMatch) {
            
            let label = formatMatch[1]
            let valuesMatch = valuesPattern.exec(text)

            while (valuesMatch) {
                
                let value = Number(valuesMatch[1])
                let count = Number(valuesMatch[2])

                if (value > 0 && value <= 10) {
                    totalValueSum +=  value * count
                    totalCount += count
                }

                valuesMatch = valuesPattern.exec(text)
            }

            let result = totalValueSum / totalCount
            console.log(`${label}: ${Math.round(result * 100) / 100}`)

        } else {

            console.log('Invalid format')
        }

    } else {

        console.log('No survey found')
    }
}

parseData('<p>Some random text</p><svg><cat><text>How do you rate our food? [Food - General]</text></cat><cat><g><val>1</val>0</g><g><val>2</val>1</g><g><val>3</val>3</g><g><val>4</val>10</g><g><val>5</val>7</g></cat></svg><p>Some more random text</p>')