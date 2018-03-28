function printDeckOfCards(cards) {

    function makeCard(face, suit) {
        let faces = ['2', '3', '4', '5', '6', '7', '8', '9', '10', 'J', 'Q', 'K', 'A']
        let suits = ['S', 'H', 'D', 'C']
        let suitToChar = {
            'S': '\u2660', 
            'H': '\u2665',
            'D': '\u2666',
            'C': '\u2663'
    }
        if (!faces.includes(face)) {
            throw new Error('Invalid card face: ', + face)
        }
    
        if (!suits.includes(suit)) {
            throw new Error('Invalid card suit: ', + suit)
        }
    
        let card = {
            face: face,
            suit: suit,
            toString: () => {
                return card.face + suitToChar[card.suit]
            }
        }
    
        return card
    }

    let createdCards = []
    for (let i = 0; i < cards.length; i++) {
        let suit = cards[i].substr(cards[i].length - 1, 1)
        let face = cards[i].substring(0, cards[i].indexOf(suit))

        try {
           let currCard = makeCard(face, suit)
           createdCards.push(currCard) 
        } catch (error) {
            console.log(`Invalid card: ${cards[i]}`)
            return
        }
    }

    console.log(createdCards.join(' '))
}

printDeckOfCards(['AS', '10D', 'KH', '2C']);
printDeckOfCards(['5S', '3D', 'QD', '1C']);
