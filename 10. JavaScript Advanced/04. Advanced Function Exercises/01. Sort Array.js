function solve(array, direction) {

    if (direction === 'asc') {
        return array.sort((a, b) => a - b)
    } else {
        return array.sort((a, b) => b - a)
    }
}

console.log(solve([14, 7, 17, 6, 8], 'desc'))