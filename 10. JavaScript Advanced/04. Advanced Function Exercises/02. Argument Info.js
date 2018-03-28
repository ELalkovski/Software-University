function result () {

    let summary = {}

    for (let i = 0; i < arguments.length; i++) {
        let currArg = arguments[i]
        let argType = typeof currArg
        console.log(argType + ': ' + currArg)

        if (!summary[argType]) {
            summary[argType] = 1
        } else {
            summary[argType]++
        }
    }

    var sortedSummary = []
    for (const type in summary) {
        sortedSummary.push([type, summary[type]])
    }

    sortedSummary.sort((a, b) => {
        let result =  b[1] - a[1]

        if (result !== 0) {
            return result
        }
    }).forEach(el => console.log(el[0] + ' = ' + el[1]))
}

result({ name: 'bob'}, 3.333, 9.999);