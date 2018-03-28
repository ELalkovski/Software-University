class Stringer {
    constructor (str, length) {
        this.initialString = str
        this.innerString = str
        this.initialLength = str
        this.innerLength = length
    }

    increase (length) {
        this.innerLength += length
    }

    decrease (length) {
        if (this.innerLength - length < 0) {
            this.innerLength = 0
        } else {
            this.innerLength -= length
        }
    }

    toString() {
        if (this.innerLength === 0) {
            return '...'
        } else {
            let result = ''
                if (this.initialString.length <= this.innerLength) {
                    for (let i = 0; i < this.initialString.length; i++) {
                        result += this.initialString[i]                        
                    }                    
                }
                else {
                    for (let i = 0; i < this.innerLength; i++) {
                        result += this.initialString[i]                        
                    } 
                    result += '...'
                }
                return result
        }
    }
}

let test = new Stringer('Test', 5)
console.log(test.toString())
test.decrease(3)
console.log(test.toString())
test.decrease(5);
console.log(test.toString()); 
test.increase(4);
console.log(test.toString()); 