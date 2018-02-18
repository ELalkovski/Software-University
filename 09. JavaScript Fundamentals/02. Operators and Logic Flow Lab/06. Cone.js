function calculateConeVolumeAndSurface(radius, height) {

    let volume = (1/3)* Math.PI * Math.pow(radius, 2) * height
    let s = Math.sqrt(radius * radius + height * height)
    let totalSurface = Math.PI * radius * (radius + s)

    console.log('volume = ' + volume)
    console.log('surface = ' + totalSurface)
}

calculateConeVolumeAndSurface(3, 5)