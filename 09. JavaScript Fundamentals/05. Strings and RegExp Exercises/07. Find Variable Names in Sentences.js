function findVariables(str) {
    
    let pattern = /\b_([a-zA-Z0-9]+)\b/g
    let matches = str.match(pattern)
    let result = []
    matches.forEach(element => {
        result.push(element.substr(1))
    });

    console.log(result.join(','))
}

findVariables('The _id and _age variables are both integers.')