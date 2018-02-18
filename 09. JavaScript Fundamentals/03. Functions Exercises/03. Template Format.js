function printXml(array) {

    let xml = '<?xml version="1.0" encoding="UTF-8"?>\n'
    xml += '<quiz>\n'

    for (let i = 0; i < array.length; i+=2) {
        
        let question = array[i]
        let answer = array[i + 1]
        xml += `  <question>\n    ${question}\n  </question>\n`
        xml += `  <answer>\n    ${answer}\n  </answer>\n`
    }

    xml += '</quiz>'

    console.log(xml)
}

printXml(["Who was the forty-second president of the U.S.A.?",
"William Jefferson Clinton"]
)