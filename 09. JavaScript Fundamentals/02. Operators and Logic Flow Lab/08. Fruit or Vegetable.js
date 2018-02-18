function fruitOrVegetable(name){

    switch(name){
        case 'banana': console.log('fruit'); break
        case 'apple': console.log('fruit'); break
        case 'kiwi': console.log('fruit'); break
        case 'cherry': console.log('fruit'); break
        case 'lemon': console.log('fruit'); break
        case 'grapes': console.log('fruit'); break
        case 'peach': console.log('fruit'); break
        case 'tomato': console.log('vegetable'); break
        case 'cucumber': console.log('vegetable'); break
        case 'pepper': console.log('vegetable'); break
        case 'onion': console.log('vegetable'); break
        case 'garlic': console.log('vegetable'); break
        case 'parsley': console.log('vegetable'); break
        default: console.log('unknown'); break
    }
}

fruitOrVegetable('pizza')