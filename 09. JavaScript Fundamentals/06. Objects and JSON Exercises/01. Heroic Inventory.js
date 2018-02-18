function registerHeroes(array) {
    
    let heroes = []

    for (const line of array) {
        
        let [name, level, itemsTokens] = line.split(' / ')
        let currentHero = {name: name, level: Number(level), items: []}

        if (itemsTokens !== undefined) {
            let items = itemsTokens.split(', ')
            items.forEach(item => {
                currentHero['items'].push(item)
            });
        }     
        
        heroes.push(currentHero)
    }

    console.log(JSON.stringify(heroes))
}

registerHeroes(['Isacc / 25 /',
    'Derek / 12 / BarrelVest, DestructionSword',
    'Hes / 1 / Desolator, Sentinel, Antara'])