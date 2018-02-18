function orderComponents(array) {
    
    let systems = new Map()

    for (const line of array) {
        
        let [systemName, component, subComponent] = line.split(' | ')

        if (systems.has(systemName)) {
            
            if (systems.get(systemName).has(component)) {
                
                systems.get(systemName).get(component).push(subComponent)
            } else {

                systems.get(systemName).set(component, [])
                systems.get(systemName).get(component).push(subComponent)
            }

        } else {

            systems.set(systemName, new Map())
            systems.get(systemName).set(component, [])
            systems.get(systemName).get(component).push(subComponent)
        }
    }

    let orderedKeys = Array.from(systems.keys()).sort((a, b) => {

        let result = systems.get(b).size - systems.get(a).size

        if (result === 0) {

            return a.localeCompare(b)
        }

        return result
    })

    for (const system of orderedKeys) {
        console.log(system)
        let componentKeys = Array.from(systems.get(system).keys()).sort((a, b) => {

            let result = systems.get(system).get(b).length - systems.get(system).get(a).length
                        
            return result
        })

        for (const component of componentKeys) {
            console.log(`|||${component}`)

            for (const subComponent of systems.get(system).get(component)) {
                console.log(`||||||${subComponent}`)
            }
        }
    }
}

orderComponents(['SULS | Main Site | Home Page',
    'SULS | Main Site | Login Page',
    'SULS | Main Site | Register Page',
    'SULS | Judge Site | Login Page',
    'SULS | Judge Site | Submittion Page',
    'Lambda | CoreA | A23',
    'SULS | Digital Site | Login Page',
    'Lambda | CoreB | B24',
    'Lambda | CoreA | A24',
    'Lambda | CoreA | A25',
    'Lambda | CoreC | C4',
    'Indice | Session | Default Storage',
    'Indice | Session | Default Security'
    ])