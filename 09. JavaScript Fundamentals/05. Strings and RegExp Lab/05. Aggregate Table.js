function getTownsIncome(array) {

    let currentTownTokens = []
    let towns = []
    let sum = 0

    for (let i = 0; i < array.length; i++) {
        
        currentTownTokens = array[i].split('|')        
        towns.push(currentTownTokens[1].trim())
        let number = Number(currentTownTokens[2].trim())
        sum += number
    }

    console.log(towns.join(', '))
    console.log(sum)
}

getTownsIncome(['| Sofia           | 300',
'| Veliko Tarnovo  | 500',
'| Yambol          | 275']
)