function printTable(n) {

    let table = '<table border="1">\n'
    table += '  <tr><th>x</th>'

    for (let row = 1; row <= n; row++) {
        
        table += `<th>${row}</th>`
    }

    table += '</tr>\n'

    for (let row = 1; row <= n; row++) {
        
        table += `  <tr><th>${row}</th>`

        for (let col = 1; col <= n; col++){
            
            table += `<td>${col * row}</td>`
        }

        table += '</tr>\n'
    }

    table += '</table>'

    console.log(table)
}

printTable(5)