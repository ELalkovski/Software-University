(() => {
    return {
        add: (firstVector, secondVector) => {
            let x = firstVector[0] + secondVector[0]
            let y = firstVector[1] + secondVector[1]
            return [x, y]
        },

        multiply: (firstVector, scalar) => {
            let x = firstVector[0] * scalar
            let y = firstVector[1] * scalar
            return [x, y]
        },

        length: (firstVector) => {
            return Math.sqrt((firstVector[0] * firstVector[0]) + (firstVector[1] * firstVector[1]))
        },

        dot: (firstVector, secondVector) => {
            return ((firstVector[0] * secondVector[0]) + (firstVector[1] * secondVector[1]))
        },

        cross: (firstVector, secondVector) => {
            return ((firstVector[0] * secondVector[1]) - (secondVector[0] * firstVector[1]))
        }
    }
})()