function getBottles(array) {
    
    let juices = {}
    let bottledJuices = {}

    for (const line of array) {
        
        let [juiceName, quantity] = line.split(/\s=>\s/g)

        if (juices.hasOwnProperty(juiceName)) {
            
            juices[juiceName] += Number(quantity)
            if (juices[juiceName] >= 1000) {
                
                if (bottledJuices.hasOwnProperty(juiceName)) {
                    
                    bottledJuices[juiceName] += (juices[juiceName] - juices[juiceName] % 1000) / 1000
                } else {

                    bottledJuices[juiceName] = (juices[juiceName] - juices[juiceName] % 1000) / 1000
                }

                juices[juiceName] = juices[juiceName] % 1000
            }

        } else {

            juices[juiceName] = Number(quantity)

            if (juices[juiceName] >= 1000) {
                
                if (bottledJuices.hasOwnProperty(juiceName)) {
                    
                    bottledJuices[juiceName] += (juices[juiceName] - juices[juiceName] % 1000) / 1000
                } else {

                    bottledJuices[juiceName] = (juices[juiceName] - juices[juiceName] % 1000) / 1000
                }

                juices[juiceName] = juices[juiceName] % 1000
            }
        }
    }

    for (const key of Object.keys(bottledJuices)) {
        
        console.log(`${key} => ${bottledJuices[key]}`) 
    }
}

getBottles(['Kiwi => 234',
    'Pear => 2345',
    'Watermelon => 3456',
    'Kiwi => 4567',
    'Pear => 5678',
    'Watermelon => 6789'
    ])