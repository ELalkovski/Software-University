function getFibonator() {
    let firstNum = 0
    let secondNum = 1

    function getNextNum() {
        let thirdNum = firstNum + secondNum
        firstNum = secondNum
        secondNum = thirdNum
        return firstNum
    }

    return getNextNum
}

let fib = getFibonator()
console.log(fib())
console.log(fib())
console.log(fib())
console.log(fib())
console.log(fib())
console.log(fib())

