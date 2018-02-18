function isPalindrome(word) {

    let reversedWord = word.split('').reverse().join('')

    if (word === reversedWord) {
        
        return true
    } else {

        return false
    }
}

console.log(isPalindrome('unitinu'))