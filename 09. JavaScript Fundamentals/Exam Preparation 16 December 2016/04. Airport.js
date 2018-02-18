function getAirportData(data) {

    let towns = new Map()
    let arrivedPlanes = []
    
    for (const line of data) {
        
        let args = line.split(' ')
        let id = args[0]
        let town = args[1]
        let passengersCount = Number(args[2])
        let action = args[3]

        if (action === 'land') {
            
            let planeIndex = arrivedPlanes.indexOf(id)

            if (planeIndex === - 1) {
                if (towns.has(town)) {

                    towns.get(town).planes.add(id)
                    towns.get(town).arrivals += passengersCount
                } else {

                    towns.set(town, {arrivals: passengersCount, departures: 0, planes:new Set()})
                    towns.get(town).planes.add(id)
                }

                arrivedPlanes.push(id)
            }

        } else if (action === 'depart') {

            let planeIndex = arrivedPlanes.indexOf(id)

            if (planeIndex > -1) {

                if (towns.has(town)) {

                    towns.get(town).planes.add(id)
                    towns.get(town).departures += passengersCount
                } else {

                    towns.set(town, {arrivals: 0, departures: passengersCount, planes:new Set()})
                    towns.get(town).planes.add(id)
                }
                
                arrivedPlanes.splice(planeIndex, 1)
            }            
        }
    }

    console.log('Planes left:')
    arrivedPlanes.sort((a, b) => {return a.localeCompare(b)})
                 .forEach(p => console.log(`- ${p}`))

    let townsKeys = Array.from(towns.keys())
    .sort((a, b) => {
        let result = towns.get(b).arrivals - towns.get(a).arrivals

        if (result !== 0) {
            return result
        }

        return a.localeCompare(b)
    })

    for (const key of townsKeys) {
        
        let currentTown = towns.get(key)        
        console.log(key)
        console.log(`Arrivals: ${currentTown.arrivals}`)
        console.log(`Departures: ${currentTown.departures}`)
        console.log('Planes:')
        let airplanes = Array.from(currentTown.planes)
        .sort((a, b) => a.localeCompare(b))
        .forEach(a => console.log(`-- ${a}`))
    }
}

getAirportData([
    "Airbus Paris 356 land",
    "Airbus London 321 land",
    "Airbus Paris 213 depart",
    "Airbus Ljubljana 250 land"
    ]
    )