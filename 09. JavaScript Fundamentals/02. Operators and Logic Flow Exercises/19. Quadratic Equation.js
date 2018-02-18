function calculateQuadraticEquation(a, b, c){

    let d = Math.pow(b, 2) - 4 * a * c
    let x1 = 0
    let x2 = 0

    if(d < 0) {

        console.log('No')

    } else if(d === 0) {

        x1 = -b / (2 * a)
        console.log(x1)
    } else {

        x1 = (-b + Math.sqrt(d)) / (2 * a)
        x2 = (-b - Math.sqrt(d)) / (2 * a)

        console.log(Math.min(x1, x2))
        console.log(Math.max(x1, x2))
    }
}

calculateQuadraticEquation(5, 2, 1)