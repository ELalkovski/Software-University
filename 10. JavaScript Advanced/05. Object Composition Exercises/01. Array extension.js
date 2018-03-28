(function () {
    Array.prototype.last = function () {
        return this[this.length - 1]
    }

    Array.prototype.skip = function (n) {
        return this.slice(0 + Number(n), this.length)
    }

    Array.prototype.take = function (n) {
        return this.slice(0, n)
    }

    Array.prototype.sum = function () {
        return this.reduce((a, b) => a + b)
    }

    Array.prototype.average = function () {
        let elementsCount = this.length
        let sum = this.reduce((a, b) => a + b)
        return sum / elementsCount
    }
})()

solve()

let myArr = [1, 2, 3, 4]
let skipped = myArr.skip(3)
let taken = myArr.last()
console.log(taken)