function checkEndOfStr(str, strToCheck) {
    
    let startIndex = str.length - strToCheck.length
    let endSubstr = str.substr(startIndex, strToCheck.length)

    if (strToCheck === endSubstr) {
        return true
    }

    return false
}

console.log(checkEndOfStr('The new iPhone has no headphones jack.',
'o headphones jack.'))