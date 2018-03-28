function proccess(array) {
    
    let closure = (function() {
        let str = ''

        return {
            append: (text) => str = str + text,
            removeStart: (countChars) => str = str.slice(countChars),
            removeEnd: (countChars) => str = str.slice(0, str.length - countChars),
            print: () => console.log(str)
        }
    })()

    for (const line of array) {
        let [name, value] = line.split(' ')
        closure[name](value)
    }
}
proccess(['append hello',
'append again',
'removeStart 3',
'removeEnd 4',
'print'])