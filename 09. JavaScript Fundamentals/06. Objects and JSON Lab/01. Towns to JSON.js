function printTowns(array) {
    
    let towns = []

    for (let line of array.slice(1)) {
        
        let currentTown = {}
        let [townName, lat, lng] = line.split(/\s*\|\s*/g).filter(s => s !== '')

        currentTown['Town'] = townName
        currentTown['Latitude'] = Number(lat)
        currentTown['Longitude'] = Number(lng)

        towns.push(currentTown)
    }

    return JSON.stringify(towns)
}

console.log(printTowns(['| Town | Latitude | Longitude |',
'| Sofia | 42.696552 | 23.32601 |',
'| Beijing | 39.913818 | 116.363625 |']
))