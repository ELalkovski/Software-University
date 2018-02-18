function getProductsOrdered(array) {

    let products = {}

    for (const line of array) {
        
        let [name, price] = line.split(' : ')
        products[name] = Number(price)
    }

    let keys = Array.from(Object.keys(products)).sort((a, b) => a.localeCompare(b))
    let distinctedFirstLetters = new Set()

    for (const key of keys) {
        distinctedFirstLetters.add(key.substr(0, 1))
    }

    for (const letter of distinctedFirstLetters) {
        
        let productsByFirstLetter = keys.filter(p => p.startsWith(letter))
        console.log(letter)
        productsByFirstLetter.forEach(p => console.log(`  ${p}: ${products[p]}`))        
    }
}

getProductsOrdered(['Banana : 2',
    'Rubic\'s Cube : 5',
    'Raspberry P : 4999',
    'Rolex : 100000',
    'Rollon : 10',
    'Rali Car : 2000000',
    'Pesho : 0.000001',
    'Barrel : 10'    
    ])