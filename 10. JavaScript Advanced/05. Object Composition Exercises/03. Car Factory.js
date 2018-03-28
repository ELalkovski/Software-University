function getCar(orderedCar) {
    
    let engines = {
        smallEngine: {power: 90, volume: 1800},
        normalEngine: {power: 120, volume: 2400},
        monsterEngine: {power: 200, volume: 3500}
    }

    let carriages = {
        hatchback: {type: 'hatchback', color: ''},
        coupe: {type: 'coupe', color: ''}        
    }

    let car = {}
    car.model = orderedCar.model
    
    if (orderedCar.power <= 90) {
        car.engine = engines.smallEngine
    } else if (orderedCar.power > 90 && orderedCar.power <= 120) {
        car.engine = engines.normalEngine
    } else if (orderedCar.power > 120) {
        car.engine = engines.monsterEngine
    }

    car.carriage = carriages[orderedCar.carriage]
    car.carriage.color = orderedCar.color
    car.wheels = []

    for (let i = 0; i < 4; i++) {
        car.wheels.push(orderedCar.wheelsize % 2 === 0 ? orderedCar.wheelsize - 1 : orderedCar.wheelsize)
        
    }

    return car
}

console.log(getCar({
    model: 'Opel Vectra',
    power: 110,
    color: 'grey',
    carriage: 'coupe',
    wheelsize: 17
}
))