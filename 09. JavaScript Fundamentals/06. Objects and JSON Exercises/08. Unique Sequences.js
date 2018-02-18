function getUniqueArrays(array) {
    
    let uniqueArrays = new Set()

    for (const json of array) {
        
        let sortedArr = JSON.parse(json).sort((a, b) => {return b - a})

        let sortedArrAsStr = JSON.stringify(sortedArr)
        uniqueArrays.add(sortedArrAsStr)
    }

    uniqueArrays = [...uniqueArrays].sort((a, b) => {
        let firstArr = JSON.parse(a)
        let secondArr = JSON.parse(b)

        return firstArr.length - secondArr.length
    })
    
    for (const arr of uniqueArrays) {       

        let parsedArr = JSON.parse(arr)
        console.log(`[${parsedArr.join(', ')}]`)
    }
}

getUniqueArrays(['[-3, -2, -1, 0, 1, 2, 3, 4]',
    '[10, 1, -17, 0, 2, 13]',
    '[4, -3, 3, -2, 2, -1, 1, 0]'
    ])