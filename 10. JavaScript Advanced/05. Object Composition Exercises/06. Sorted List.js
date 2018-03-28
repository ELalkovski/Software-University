function getSortedList() {

    let obj = (() => {

        let collection = []
        let size = 0
        let sorting = (a,b) => a-b;

        function sort() {
            collection.sort((a, b) => a - b)
        }

        function add(element) {
            collection.push(element)
            sort()
            this.size++
            return collection
        }

        function remove(index) {
            if (index >=0 && index< collection.length) {
                collection.splice(index, 1)
                sort()
                this.size--
                return collection
            }          
        }

        function get(index) {
            if (index >=0 && index< collection.length) {
                return collection[index]
            }            
        }

        return { add, remove, get, size }
    })()

    return obj
}

let result = getSortedList()
// Instantiate and test functionality
var myList = result;

myList.add(5);
console.log(myList.toString())

myList.add(3);
console.log(myList.toString())

myList.remove(0);
console.log(myList.toString())
console.log(myList.size())
