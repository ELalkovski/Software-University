function isPointsValid(array) {

    let x1 = array[0]
    let y1 = array[1]
    let x2 = array[2]
    let y2 = array[3]

    if (Number.isInteger(getDistance(x1, y1, 0, 0))) {
        
        console.log(`{${x1}, ${y1}} to {0, 0} is valid`)
    } else {
        
        console.log(`{${x1}, ${y1}} to {0, 0} is invalid`)
    }

    if (Number.isInteger(getDistance(x2, y2, 0, 0))) {
        
        console.log(`{${x2}, ${y2}} to {0, 0} is valid`)
    } else {
        
        console.log(`{${x2}, ${y2}} to {0, 0} is invalid`)
    }

    if (Number.isInteger(getDistance(x1, y1, x2, y2))) {
        
        console.log(`{${x1}, ${y1}} to {${x2}, ${y2}} is valid`)
    } else {
        
        console.log(`{${x1}, ${y1}} to {${x2}, ${y2}} is invalid`)
    }

    function getDistance(x1, y1, x2, y2){

        let distH = x1 - x2
        let distY = y1 - y2

        return Math.sqrt((distH ** 2) + (distY ** 2))
    }
}

isPointsValid([2, 1, 1, 1])