function checkStrStart(str, startsWithStr) {
    
    let checkSubstr = str.substr(0, startsWithStr.length)

    if (checkSubstr === startsWithStr) {
        return true
    } 

    return false
}

console.log(checkStrStart('The quick brown fox…',
'The quick brown fox…'))