function shapeCrystals(array) {

    let desiredShape = array[0]
    var movesCounter = 0
    var isXrayUsed = false

    for (let i = 1; i < array.length; i++) {

        let currentOre = array[i]
        console.log(`Processing chunk ${currentOre} microns`)

        if (currentOre + 1 === desiredShape) {
            console.log('X-ray x1')
            console.log(`Finished crystal ${desiredShape} microns`)
            isXrayUsed = true
            continue
        }

        // cut the crystal
        currentOre = cutCrystal(currentOre, desiredShape)
        movesCounter = 0

        // transport and wash
        currentOre = transportAndWash(currentOre)

        // lap the crystal
        currentOre = lapCrystal(currentOre, desiredShape)
        movesCounter = 0

        // transport and wash
        currentOre = transportAndWash(currentOre)

        // grind the crystal
        currentOre = grindCrystal(currentOre, desiredShape)
        movesCounter = 0

        // transport and wash
        currentOre = transportAndWash(currentOre)

        // etch the crystal
        currentOre = etchCrystal(currentOre, desiredShape)
        movesCounter = 0

        // transport and wash
        currentOre = transportAndWash(currentOre)


        if (currentOre === desiredShape) {
            console.log(`Finished crystal ${desiredShape} microns`)
        }

    }

    function etchCrystal(ore, shape) {

        while (ore > shape) {

            ore -= 2

            if (ore + 1 === shape) {
                ore += 1
                isXrayUsed = true
            }

            if (ore < shape) {

                ore += 2
                break
            }

            movesCounter++

            if (ore === shape) {
                break;
            }
        }

        if (movesCounter > 0) {
            console.log(`Etch x${movesCounter}`)
            console.log('Transporting and washing')
            if (isXrayUsed === true) {
                console.log('X-ray x1')
            }
        }

        return ore
    }


    function grindCrystal(ore, shape) {

        while (ore > shape) {

            ore -= 20

            if (ore + 1 === shape) {

                ore += 1
                isXrayUsed = true
            }

            if (ore < shape) {

                ore += 20
                break
            }

            movesCounter++

            if (ore === shape) {
                break;
            }
        }

        if (movesCounter > 0) {
            console.log(`Grind x${movesCounter}`)
            console.log('Transporting and washing')
            if (isXrayUsed === true) {

                console.log('X-ray x1')
            }
        }

        return ore
    }

    function lapCrystal(ore, shape) {

        while (ore > shape) {

            let removedThickness = (0.2 * ore)
            ore -= removedThickness

            if (ore + 1 === shape) {

                ore += 1
                isXrayUsed = true
            }

            if (ore < shape) {

                ore += removedThickness
                break
            }

            movesCounter++

            if (ore === shape) {
                break
            }
        }

        if (movesCounter > 0) {
            console.log(`Lap x${movesCounter}`)
            console.log('Transporting and washing')
            if (isXrayUsed === true) {

                console.log('X-ray x1')
            }
        }

        return ore
    }

    function cutCrystal(ore, shape) {

        while (ore > shape) {

            ore /= 4

            if (ore + 1 === shape) {

                ore += 1
                isXrayUsed = true
            }

            if (ore < shape) {

                ore *= 4
                break
            }

            movesCounter++

            if (ore === shape) {
                break
            }
        }

        if (movesCounter > 0) {
            console.log(`Cut x${movesCounter}`)
            console.log('Transporting and washing')
            if (isXrayUsed === true) {

                console.log('X-ray x1')
            }
        }
        return ore
    }

    function transportAndWash(ore) {

        if (ore % 1 !== 0) {
            ore = Math.floor(ore)
        }

        return ore
    }


}

shapeCrystals([100, 99])