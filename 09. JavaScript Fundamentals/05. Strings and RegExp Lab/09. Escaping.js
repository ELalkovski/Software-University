function escapeChars(array) {

    let result = '<ul>\n'    

    for (let line of array) {
        
        line = line.replace(/&/g, '&amp;')
        .replace(/</g, '&lt;')
        .replace(/>/g, '&gt;')        
        .replace(/"/g, '&quot;')
        result += ' '.repeat(2) + `<li>${line}</li>\n`
    }

    result += '</ul>'
    return result
}

console.log(escapeChars(['<div style=\"color: red;\">Hello, Red!</div>', '<table><tr><td>Cell 1</td><td>Cell 2</td><tr>']))