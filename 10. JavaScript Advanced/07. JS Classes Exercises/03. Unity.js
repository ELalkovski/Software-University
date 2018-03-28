class Rat {
    constructor (name) {
        this.name = name
        this.unitedRats = []
    }

    unite (rat) {
        if (rat instanceof Rat) {
            this.unitedRats.push(rat)
        }
    }

    getRats() {
        return this.unitedRats
    }

    toString() {
        let result =  `${this.name}\n`

        if (this.unitedRats.length > 0) {
            for (const rat of this.unitedRats) {
                result += `##${rat.name}\n`
            }
        }

        return result
    }
}

let rat2 = new Rat("Viktor");
let rat3 = new Rat("Vichi");
let rat4 = "fake rat";

rat2.unite(rat4);
console.log(rat2)
