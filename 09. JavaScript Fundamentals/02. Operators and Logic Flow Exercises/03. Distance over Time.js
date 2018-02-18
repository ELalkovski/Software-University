function calculateDistance(array){
    let firstSpeed = array[0]
    let secondSpeed = array[1]
    let timeInSeconds = array[2]

    let firstDistance = (firstSpeed / 3.6) * timeInSeconds
    let secondDistance = (secondSpeed / 3.6) * timeInSeconds

    console.log(Math.abs(firstDistance - secondDistance))
}

calculateDistance([5, -5, 40])