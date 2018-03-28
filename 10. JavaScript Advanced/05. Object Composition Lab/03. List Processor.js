function proccessStrings(array) {    
    
    let proccessor = (function () {

        let elements = []

        function add(str) {
            elements.push(str)
        }
        
        function remove(str) {
            elements = elements.filter(el => el !== str)
        }

        function print() {
            console.log(elements.toString())
        }

        return {add, remove, print}
    })()

    for (let pair of array) {
        let [command, str] = pair.split(' ')
        proccessor[command](str)
    }
}

proccessStrings(['add pesho', 'add gosho', 'add pesho', 'remove pesho','print'])