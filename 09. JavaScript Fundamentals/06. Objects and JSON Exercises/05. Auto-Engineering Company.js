function getCarsQuantity(array) {
    
    let cars = new Map()

    for (const line of array) {
        
        let [brand, model, quantity] = line.split(' | ')

        if (cars.has(brand)) {
            
            if (cars.get(brand).has(model)) {
                
                cars.get(brand).set(model, cars.get(brand).get(model) + Number(quantity))
            } else {

                cars.get(brand).set(model, Number(quantity))
            }
        } else {

            cars.set(brand, new Map())
            cars.get(brand).set(model, Number(quantity))
        }
    }

    for (const brand of cars.keys()) {
        
        console.log(brand)
        for (const model of cars.get(brand).keys()) {
            
            console.log(`###${model} -> ${cars.get(brand).get(model)}`)
        }
    }
}

getCarsQuantity(['Audi | Q7 | 1000',
    'Audi | Q6 | 100',
    'BMW | X5 | 1000',
    'BMW | X6 | 100',
    'Citroen | C4 | 123',
    'Volga | GAZ-24 | 1000000',
    'Lada | Niva | 1000000',
    'Lada | Jigula | 1000000',
    'Citroen | C4 | 22',
    'Citroen | C5 | 10'
    ])