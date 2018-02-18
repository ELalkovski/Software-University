function printChessboard(dimension){

    let result = '<div class="chessboard">\n'

    for (var row = 0; row < dimension; row++){

        result += '  <div>\n'                

         for (var col = 0; col < dimension; col++) {
            let color = ((row + col) % 2 == 0) ? 'black' : 'white';
            result += `    <span class="${color}"></span>\n`
         }

         result += '  </div>\n'   
    }
    
    result += '</div>'
    return result
}

console.log(printChessboard(3))