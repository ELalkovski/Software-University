let add = (function () {    
    let sum = 0
    return function closure(value) {
        sum += value
        closure.toString = () => sum
        return closure
    }
})()

console.log(add(1)(6));