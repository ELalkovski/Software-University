function solution() {

    let ingridients = {
        protein: 0,
        carbohydrate: 0,
        fat: 0,
        flavour: 0
    }
    
    let meals = {
        apple: {protein: 0, carbohydrate: 1, fat: 0, flavour: 2},
        coke: {protein: 0, carbohydrate: 10, fat: 0, flavour: 20},
        burger: {protein: 0, carbohydrate: 5, fat: 7, flavour: 3},
        omelet: {protein: 5, carbohydrate: 0, fat: 1, flavour: 1},
        cheverme: {protein: 10, carbohydrate: 10, fat: 10, flavour: 10},
    }

    let operations = {
        restock: (product, quantity) => {
            ingridients[product] += Number(quantity)
            return 'Success'
        }, 

        prepare: (meal, quantity) => {

            try {
                validatePreparation()
            } catch (error) {
                return error.message
            }
            cook()
            return 'Success'
            function cook() {
                ingridients.protein -= meals[meal].protein * Number(quantity)
                ingridients.carbohydrate -= meals[meal].carbohydrate * Number(quantity)
                ingridients.fat -= meals[meal].fat * Number(quantity)
                ingridients.flavour -= meals[meal].flavour * Number(quantity)
            }
            function validatePreparation() {
                if (meals[meal].protein * Number(quantity) > ingridients.protein) {
                    throw new Error(`Error: not enough protein in stock`)
                } else if (meals[meal].carbohydrate * Number(quantity) > ingridients.carbohydrate) {
                    throw new Error(`Error: not enough carbohydrate in stock`)
                } else if (meals[meal].fat * Number(quantity) > ingridients.fat) {
                    throw new Error(`Error: not enough fat in stock`)
                } else if (meals[meal].flavour * Number(quantity) > ingridients.flavour) {
                    throw new Error(`Error: not enough flavour in stock`)
                }
            }
        },

        report: () => {
            return `protein=${ingridients.protein} carbohydrate=${ingridients.carbohydrate} fat=${ingridients.fat} flavour=${ingridients.flavour}`
        }        
    }    

    return (input) => {
        input = input.split(' ')
        return operations[input.shift()](...input)
    }
}

let manager = solution()
console.log(manager("restock protein 100"))
console.log(manager("restock carbohydrate 100"))
console.log(manager("restock fat 100"))
console.log(manager("restock flavour 100"))
console.log(manager("report"))
console.log(manager("prepare omelet 2"))
console.log(manager("report"))
console.log(manager("prepare omelet 1"))
console.log(manager("report"))


