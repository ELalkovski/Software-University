function calculatePopulation(array) {

    let towns = new Map()

    for (const line of array) {
        
        let townTokens = line.split(/\s*<->\s*/g)
        let townName = townTokens[0]
        let population = Number(townTokens[1])

        if (towns.has(townName)) {
            
            towns.set(townName, towns.get(townName) + population)
        } else {

            towns.set(townName, population)
        }

    }
    
    for (const town of towns.keys()) {
            
        console.log(`${town} : ${towns.get(town)}`)
    }
}
calculatePopulation(['Sofia <-> 1200000',
    'Montana <-> 20000',
    'New York <-> 10000000',
    'Washington <-> 2345000',
    'Las Vegas <-> 1000000'
    ])