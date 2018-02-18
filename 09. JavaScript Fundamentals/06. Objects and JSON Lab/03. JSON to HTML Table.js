function generateHtmlTable(json) {

    let objParams = JSON.parse(json)
    let result = '<table>\n'
    result += '  <tr>'

    for (let key of Object.keys(objParams[0])) {
        
        result += `<th>${escapeSymbols(key)}</th>`
    }

    result += '</tr>\n'    

    for (let obj of objParams) {
        
        result += '  <tr>'

        for (const key of Object.keys(obj)) {
            result += `<td>${escapeSymbols(obj[key] + '')}</td>`
        }
        
        result += '</tr>\n'
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

generateHtmlTable('[{"Name":"Tomatoes & Chips","Price":2.35},{"Name":"J&B Chocolate","Price":0.96}]')