function extractSpices(productionForDay) {
    

    let totalSpicesGathered = 0
    let daysWorked = 0

    while (productionForDay >= 100) {
        
        totalSpicesGathered += productionForDay
        productionForDay -= 10
        totalSpicesGathered -= Math.min(26, totalSpicesGathered)
        daysWorked++
    }

    totalSpicesGathered -= Math.min(26, totalSpicesGathered)
    console.log(daysWorked)
    console.log(totalSpicesGathered)
}

extractSpices(200)