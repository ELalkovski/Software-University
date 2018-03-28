class Player {
    constructor(nickName) {
        this.nickName = nickName
        this.scoresList = []
    }

    addScore(score) {
        if (!isNaN(score) && score !== null) {
            this.scoresList.push(+score)
            this.scoresList.sort((a,b) => b-a);
        }
        return this        
    }

    get scoreCount() {
        return this.scoresList.length
    }

    get highestScore() {
        return this.scoresList[0]    
    }

    get topFiveScore() {
        return this.scoresList.slice(0, 5)
    }

    toString() {
        return `${this.nickName}: [${this.scoresList}]`
    }
}

let p = new Player("Trotro");

p.addScore('Pesho');
console.log(p.toString()) // Trotro: []
console.log(p.highestScore) // undefined
console.log(p.topFiveScore.length) // 0
console.log(p.scoreCount) // 0

p.addScore('123');
console.log(p.toString()) // Trotro: [123]
console.log(p.highestScore) // 123
console.log(p.topFiveScore[0]) // 123
console.log(p.scoreCount) // 1

