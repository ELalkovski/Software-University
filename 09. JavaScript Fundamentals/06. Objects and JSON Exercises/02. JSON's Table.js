function printTable(array) {
    
    let result = '<table>\n'    

    for (const line of array) {
        
        let obj = JSON.parse(line)
        let keys = Object.keys(obj)
        result += '    <tr>\n'

        for (const key of keys) {
            
            result += `        <td>${obj[key]}</td>\n`
        }

        result += '    <tr>\n'
    }

    result += '</table>'
    console.log(result)
}

printTable(['{"name":"Pesho","position":"Promenliva","salary":100000}',
'{"name":"Teo","position":"Lecturer","salary":1000}',
'{"name":"Georgi","position":"Lecturer","salary":1000}'
])