(() => {
    
    let id = -1

    return class Extensible {
        constructor () {
            this.id = ++id
        }

        extend(template) {
            for (let key in template) {
                if (typeof(template[key]) === 'function') {
                    Extensible.prototype[key] = template[key]
                } else {
                    this[key] = template[key]
                }
            }
        }
    }
})()

function getExt()  {
    
    let id = -1

    class Extensible {
        constructor (id) {
            this.id = ++id
        }

        extend(template) {
            for (let key in template) {
                if (typeof(template[key]) === 'function') {
                    Extensible.prototype(this)[key] = template[key]
                } else {
                    this[key] = template[key]
                }
            }
        }
    }
    
    return {Extensible}
}

let result = getExt()
let obj1 = new Extensible()
let obj2 = new Extensible()
let obj3 = new Extensible()
console.log(obj1.id)
console.log(obj2.id)
console.log(obj3.id)
