function findPyramidMaterials(base, increment) {

    let stones = 0
    let marble = 0
    let lapisLazuli = 0
    let gold = 0
    let height = 0
    let stepsCount = 1

    if (base % 2 === 0) {

        while (base > 1) {
        
            let currentTotalMaterialsCount = base * base * increment
            let currentStones = 0
            let currentMarble = 0
            let currentLapis = 0

            if (base === 2) {
                gold += currentTotalMaterialsCount
                
            } else if (stepsCount === 5){

                currentLapis = ((base * 4) - 4) * increment
                currentStones = currentTotalMaterialsCount - currentLapis

                stones += currentStones
                lapisLazuli += currentLapis
                stepsCount = 0
            } else {

                currentStones = ((base - 2) * (base - 2) * increment)
                currentMarble = currentTotalMaterialsCount - currentStones

                stones += currentStones
                marble += currentMarble
            }

            base -= 2
            height += increment
            stepsCount++
        }
    } else {
        
        while (base > 0) {
        
            let currentTotalMaterialsCount = base * base * increment
            let currentStones = 0
            let currentMarble = 0
            let currentLapis = 0

            if (base === 1) {
                gold += currentTotalMaterialsCount
                
            } else if (stepsCount === 5){

                currentLapis = ((base * 4) - 4) * increment
                currentStones = currentTotalMaterialsCount - currentLapis

                stones += currentStones
                lapisLazuli += currentLapis
                stepsCount = 0
            } else {

                currentStones = ((base - 2) * (base - 2) * increment)
                currentMarble = currentTotalMaterialsCount - currentStones

                stones += currentStones
                marble += currentMarble
            }

            base -= 2
            height += increment
            stepsCount++
        }
    }

    console.log(`Stone required: ${Math.ceil(stones)}`)
    console.log(`Marble required: ${Math.ceil(marble)}`)
    console.log(`Lapis Lazuli required: ${Math.ceil(lapisLazuli)}`)
    console.log(`Gold required: ${Math.ceil(gold)}`)
    console.log(`Final pyramid height: ${Math.floor(height)}`)
}

findPyramidMaterials(55, 0.66)