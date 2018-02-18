function buildWall(sections) {
    
    sections = sections.map(x => Number(x))
    let concreteByDays = []
    let totalCost = 0

    while (true) {
        
        let constructionSites = sections.filter(el => el < 30)

        if (constructionSites.length === 0) {
            break
        }

        let concreteForDayRequired = 195 * constructionSites.length
        concreteByDays.push(concreteForDayRequired)
        sections = raiseHeight(constructionSites)
    }

    console.log(concreteByDays.join(', '))
    console.log(`${1900 * (concreteByDays.reduce((a, b) => {return a + b}))} pesos`)

    function raiseHeight(array) {
        
        for (let i = 0; i < array.length; i++) {

            if (array[i] < 30) {
                array[i]++
            }            
        }

        return array
    }
}

buildWall([17, 22, 17, 19, 17])