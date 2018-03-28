class SortedList {
    
        constructor () {
            this.collection = []
            this.size = 0
        }

        sort() {
            this.collection.sort((a, b) => a - b)
        }

        add(element) {
            this.collection.push(element)
            this.sort()
            this.size++
            return this.collection
        }

        remove(index) {
            if (index >=0 && index< this.collection.length) {
                this.collection.splice(index, 1)
                this.sort()
                this.size--
                return this.collection
            }          
        }

        get (index) {
            if (index >=0 && index< this.collection.length) {
                return this.collection[index]
            }            
        }

}