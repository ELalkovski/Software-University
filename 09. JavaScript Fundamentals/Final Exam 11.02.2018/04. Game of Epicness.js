function solve(kingdomArgs, actions) {
    
    let kingdoms = new Map()
    let generalsResults = new Map()

    for (const object of kingdomArgs) {
        
        let name = object.kingdom
        let general = object.general
        let army = Number(object.army)

        if (kingdoms.has(name)) {
            
            if (kingdoms.get(name).has(general)) {
                
                kingdoms.get(name).set(general, kingdoms.get(name).get(general) + army)
            } else {

                kingdoms.get(name).set(general, army)
            }

        } else {

            kingdoms.set(name, new Map())
            kingdoms.get(name).set(general, army)
        }

        if (!generalsResults.has(general)) {
            generalsResults.set(general, {wins:0, loses:0})
        } 
    }

    

    for (const line of actions) {
        
        let attackingKingdom = line[0]
        let attackingGeneral = line[1]
        let defendingKingdom = line[2]
        let defendingGeneral = line[3]

        if (attackingKingdom === defendingKingdom) {
            continue
        }

        let attackingArmy = kingdoms.get(attackingKingdom).get(attackingGeneral)
        let defendingArmy = kingdoms.get(defendingKingdom).get(defendingGeneral)

        if (attackingArmy === defendingArmy) {
            continue
        }

        if (attackingArmy > defendingArmy) {
            generalsResults.get(attackingGeneral).wins++
            generalsResults.get(defendingGeneral).loses++           

            kingdoms.get(attackingKingdom).set(attackingGeneral, Math.floor(attackingArmy + (attackingArmy * 0.1)))
            kingdoms.get(defendingKingdom).set(defendingGeneral, Math.floor(defendingArmy - (defendingArmy * 0.1)))
        }
        else if (attackingArmy < defendingArmy) {
            generalsResults.get(defendingGeneral).wins++
            generalsResults.get(attackingGeneral).loses++            

            kingdoms.get(defendingKingdom).set(defendingGeneral, Math.floor(defendingArmy + (defendingArmy * 0.1)))
            kingdoms.get(attackingKingdom).set(attackingGeneral, Math.floor(attackingArmy - (attackingArmy * 0.1)))
        }
    }

    let kingdomsKeys = Array.from(kingdoms.keys()).sort((a, b) => {
        let firstKingdom = kingdoms.get(a)
        let secondKingdom = kingdoms.get(b)
        let firstGeneralsTotalWins = 0
        let firstGeneralsTotalLoses = 0
        let secondGeneralsTotalWins = 0
        let secondGeneralsTotalLoses = 0

        for (const [general, value] of firstKingdom) {
            firstGeneralsTotalWins += generalsResults.get(general).wins
            firstGeneralsTotalLoses += generalsResults.get(general).loses        
        }

        for (const [general, value] of secondKingdom) {
            secondGeneralsTotalWins += generalsResults.get(general).wins
            secondGeneralsTotalLoses += generalsResults.get(general).loses
        }

        let resultWins = secondGeneralsTotalWins - firstGeneralsTotalWins
        let resultLoses = firstGeneralsTotalLoses - secondGeneralsTotalLoses

        if (resultWins !== 0) {
            return resultWins
        }
        else if (resultLoses !== 0) {
            return resultLoses
        }
        
        return a.localeCompare(b)
    })

    let winningKingdomKey = kingdomsKeys[0]
    let winningKingdom = kingdoms.get(winningKingdomKey)
    let generalsKeys = Array.from(winningKingdom.keys()).sort((a, b) => {
        return winningKingdom.get(b) - winningKingdom.get(a)
    })

    console.log(`Winner: ${winningKingdomKey}`)
    for (const general of generalsKeys) {
        console.log(`/\\general: ${general}`)
        console.log(`---army: ${winningKingdom.get(general)}`)
        console.log(`---wins: ${generalsResults.get(general).wins}`)
        console.log(`---losses: ${generalsResults.get(general).loses}`)
    }
}

solve([ { kingdom: "Maiden Way", general: "Merek", army: 5000 },
{ kingdom: "Stonegate", general: "Ulric", army: 4900 },
{ kingdom: "Stonegate", general: "Doran", army: 70000 },
{ kingdom: "YorkenShire", general: "Quinn", army: 0 },
{ kingdom: "YorkenShire", general: "Quinn", army: 2000 },
{ kingdom: "Maiden Way", general: "Berinon", army: 100000 } ],
[ ["YorkenShire", "Quinn", "Stonegate", "Ulric"],
["Stonegate", "Ulric", "Stonegate", "Doran"],
["Stonegate", "Doran", "Maiden Way", "Merek"],
["Stonegate", "Ulric", "Maiden Way", "Merek"],
["Maiden Way", "Berinon", "Stonegate", "Ulric"] ]
)