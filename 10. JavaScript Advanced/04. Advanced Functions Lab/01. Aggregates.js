function reducer(array) {
    console.log(`Sum = ${array.reduce((a, b) => a + b)}`)
    console.log(`Min = ${array.reduce((a, b) => Math.min(a, b))}`)
    console.log(`Max = ${array.reduce((a, b) => Math.max(a, b))}`)
    console.log(`Product = ${array.reduce((a, b) => a * b)}`)
    console.log(`Join = ${array.reduce((a, b) => a + '' + b)}`)
}
reducer([2,3,10,5])