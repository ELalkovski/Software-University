function detectSpeed(array){

    let speed = array[0]
    let area = array[1]

    switch (area) {
        case 'city': 
            if (!isWithinSpeedLimit(speed, 50)) {
                printMessage(speed, 50)
            }
        break;
        case 'motorway': 
            if (!isWithinSpeedLimit(speed, 130)) {
                printMessage(speed, 130)
            }
        break;
        case 'interstate': 
            if (!isWithinSpeedLimit(speed, 90)) {
                printMessage(speed, 90)
            }
        break;
        case 'residential': 
            if (!isWithinSpeedLimit(speed, 20)) {
                printMessage(speed, 20)
            }
        break;
        default:
            break;
    }

    function isWithinSpeedLimit(speed, speedLimit) {

        if (speed <= speedLimit) {
            return true
        }

        return false
    }

    function printMessage(speed, speedLimit) {

        let difference = speed - speedLimit

        if (difference <= 20) {
            
            console.log('speeding')
        } else if(difference <= 40) {
            console.log('excessive speeding')
        } else {
            console.log('reckless driving')
        }
    }
}

detectSpeed([21, 'residential'])