function generateHtml(str) {

    let objParams = JSON.parse(str)
    let result = '<table>\n  <tr><th>name</th><th>score</th></tr>\n'

    for (const obj of objParams) {
        
        let escapedName = escapeSymbols(obj['name'])
        result += `  <tr><td>${escapedName}</td><td>${obj['score']}</td></tr>\n`
    }

    result += '</table>'

    console.log(result)

    function escapeSymbols(line) {

        line = line.replace(/&/g, '&amp;')
        .replace(/</g, '&lt;')
        .replace(/>/g, '&gt;')        
        .replace(/"/g, '&quot;')
        .replace(/'/g, '&#39;')

        return line
    }
}

generateHtml('[{"name":"Pesho & Kiro","score":479},{"name":"Gosho, Maria & Viki","score":205}]')