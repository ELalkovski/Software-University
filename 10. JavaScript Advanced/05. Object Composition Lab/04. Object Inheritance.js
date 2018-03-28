function proccessCommands(arr) {

    let objects = new Map()
    let cmdExecutor = {

        create: function ([objName, inherits, parent]) {
            parent = parent ? objects.get(parent) : null
            objects.set(objName, Object.create(parent))
        },

        set: function ([objName, key, value]) {
            objects.get(objName)[key] = value
        },

        print: function ([name]) {
            let obj = objects.get(name), printObjects = []
            for (const key in obj) {
                printObjects.push(`${key}:${obj[key]}`)
            }

            console.log(printObjects.join(', '))
        }
    }

    for (const line of arr) {
        let cmdParams = line.split(' ')
        let action = cmdParams.shift()
        cmdExecutor[action](cmdParams)
    }
}

proccessCommands(['create c1',
'create c2 inherit c1',
'set c1 color red',
'set c2 model new',
'print c1',
'print c2']
)