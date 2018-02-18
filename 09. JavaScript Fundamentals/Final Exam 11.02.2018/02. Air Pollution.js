function calculatePollution(matrix, forces) {
    
    let parsedMatrix = parseMatrix(matrix)

    for (let i = 0; i < forces.length; i++) {
        
        let forcesArgs = forces[i].split(' ')
        let currentForce = forcesArgs[0].toLowerCase()
        let indexOrValue = Number(forcesArgs[1])

        switch (currentForce) {
            case 'breeze':
                for (let row = indexOrValue; row < indexOrValue + 1; row++) {
                    for (let col = 0; col < parsedMatrix[indexOrValue].length; col++) {
                        parsedMatrix[row][col] -= Math.min(parsedMatrix[row][col], 15)                        
                    }                    
                }
                break;
            case 'gale':
                for (let row = 0; row < parsedMatrix.length; row++) {
                    parsedMatrix[row][indexOrValue] -= Math.min(parsedMatrix[row][indexOrValue], 20)                    
                }
                break;
            case 'smog':
                for (let row = 0; row < parsedMatrix.length; row++) {
                    for (let col = 0; col < parsedMatrix[row].length; col++) {
                        parsedMatrix[row][col] += indexOrValue                        
                    }                    
                }
                break;
        }
    }

    let pollutedAreas = []

    for (let row = 0; row < parsedMatrix.length; row++) {
        for (let col = 0; col < parsedMatrix[row].length; col++) {
            
            if (parsedMatrix[row][col] >= 50) {
                let coords = '[' + row + '-' + col + ']'
                pollutedAreas.push(coords) 
            }
        }        
    }

    if (pollutedAreas.length === 0) {
        console.log('No polluted areas')
    } else {
        console.log(`Polluted areas: ${pollutedAreas.join(', ')}`)
    }

    function parseMatrix(matrix) {
        let parsedMatrix = []

        for (const row of matrix) {

            let parsedRow = row.split(' ')
            parsedRow = parsedRow.map(Number)
            parsedMatrix.push(parsedRow)
        }

        return parsedMatrix
    }
}

calculatePollution([
    "5 7 2 14 4",
    "21 14 2 5 3",
    "3 16 7 42 12",
    "2 20 8 39 14",
    "7 34 1 10 24",
  ],
  ["breeze 1", "gale 2", "smog 35"]    
  )