function getIncomeByTowns(array) {
    
    let towns = new Map()

    for (const line of array) {
        
        let townTokens = line.split(/\s*->\s*/g)
        let townName = townTokens[0]
        let productName = townTokens[1]
        let productTokens = townTokens[2].split(':')
        let productQuantity = Number(productTokens[0])
        let productPrice = Number(productTokens[1])

        if (towns.has(townName)) {
            
            if (towns.get(townName).has(productName)) {
                
                towns.get(townName)
                .set(productName, (towns.get(townName).get(productName) + (productQuantity * productPrice)))
            } else {

                towns.get(townName).set(productName, (productQuantity * productPrice))
            }
        } else {

            towns.set(townName, new Map())
            towns.get(townName).set(productName, (productQuantity * productPrice))
        }
    }

    for (const town of towns.keys()) {
        
        console.log(`Town - ${town}`)

        for (const product of towns.get(town).keys()) {
            
            console.log(`$$$${product} : ${towns.get(town).get(product)}`)
        }
    }
}

getIncomeByTowns(['Sofia -> Laptops HP -> 200 : 2000',
    'Sofia -> Raspberry -> 200000 : 1500',
    'Sofia -> Audi Q7 -> 200 : 100000',
    'Montana -> Portokals -> 200000 : 1',
    'Montana -> Qgodas -> 20000 : 0.2',
    'Montana -> Chereshas -> 1000 : 0.3'
    ])