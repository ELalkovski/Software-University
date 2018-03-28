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


console.log('' + makeCard('A', 'S'));
console.log('' + makeCard('10', 'H'));
console.log('' + makeCard('1', 'C'));

