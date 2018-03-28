function getBaloons() {
    class Balloon {
        constructor(color, gasWeight) {
            this.color = color
            this.gasWeight = gasWeight
        }
    }

    class PartyBalloon extends Balloon {
        constructor(color, gasWeight, ribbonColor, ribbonLength) {
            super(color, gasWeight)
            this.ribbon = {ribbonColor, ribbonLength}
        }

        set ribbon(ribbon) {
            this._ribbon = {
                color: ribbon.ribbonColor,
                length: ribbon.ribbonLength 
            }
        }

        get ribbon() {
            return this._ribbon
        }
    }

    class BirthdayBalloon extends PartyBalloon {
        constructor(color, gasWeight, ribbonColor, ribbonLength, text) {
            super(color, gasWeight, ribbonColor, ribbonLength)
            this.text = text
        }

        set text(text) {
            this._text = text
        }

        get text() {
            return this._text
        }
    }

    return {
        Balloon: Balloon, 
        PartyBalloon: PartyBalloon,
        BirthdayBalloon: BirthdayBalloon
    }
}

let classes = getBaloons()
let test = new classes.PartyBalloon("Tumno-bqlo", 20.5, "Svetlo-cherno", 10.25);
let ribbon = test.ribbon;
console.log(ribbon.color)