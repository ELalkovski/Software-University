function calculateSumByTown(array) {

    let towns = {}
    
    for (let i = 0; i < array.length; i+= 2) {

        let townName = array[i]
        let income = Number(array[i + 1])

          if (towns.hasOwnProperty(townName)) {
                
             towns[townName] += income
          } else {

             towns[townName] = income
          }   
    }

    console.log(JSON.stringify(towns))
}

calculateSumByTown(['Sofia',
    '20',
    'Varna',
    '3',
    'Sofia',
    '5',
    'Varna',
    '4'
    ])