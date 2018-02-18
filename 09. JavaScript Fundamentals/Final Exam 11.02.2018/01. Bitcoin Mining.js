function solve(workingShift) {

    const bitcoinValueToBgn = 11949.16
    const goldToBgnValuePerGram = 67.51

    let dayOfFirstPurchase = 0
    let totalMoneyGathered = 0
    let totalBictoinsBought = 0
    let daysCounter = 1
    
    for (let i = 0; i < workingShift.length; i++) {
        let parsedGold = Number(workingShift[i])

        if (daysCounter === 3) {
            
            parsedGold = parsedGold - (parsedGold * 0.3)
            daysCounter = 0
        }

        let moneyForCurrentDay = parsedGold * goldToBgnValuePerGram
        totalMoneyGathered += moneyForCurrentDay

        if (totalMoneyGathered >= bitcoinValueToBgn) {
            if (dayOfFirstPurchase === 0) {
                dayOfFirstPurchase = i + 1
            }
            while (totalMoneyGathered >= bitcoinValueToBgn) {
                totalMoneyGathered -= bitcoinValueToBgn
                totalBictoinsBought++
            }
        }

        daysCounter++        
    }

    console.log(`Bought bitcoins: ${totalBictoinsBought}`)
    if (dayOfFirstPurchase !== 0) {
        console.log(`Day of the first purchased bitcoin: ${dayOfFirstPurchase}`)
    }
    console.log(`Left money: ${totalMoneyGathered.toFixed(2)} lv.`)
}

solve([3124.15, 504.212, 2511.124])