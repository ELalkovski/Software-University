function printFigure(number) {

    let letters = 'ATCGTTAGGG'
    let dashes = 0
    let stars = 2
    let starsReach = 0
    let result = ''
    let lettersIndex = 0
    let rowsCounter = 0


    for (let i = 1; i <= number; i++) {
        
        if (rowsCounter === number) {
            break;
        }

        if (stars >= starsReach) {
            
            result += '*'.repeat(stars) + letters[lettersIndex] + '-'.repeat(dashes) + letters[lettersIndex + 1] + '*'.repeat(stars) + '\n'
            stars--
            dashes += 2
            lettersIndex += 2
            rowsCounter++
            
            if (lettersIndex >= letters.length) {
                lettersIndex = 0
            }            

        } else {

            if (rowsCounter === number) {
                break;
            }

            stars = 1
            dashes = 2 
            i += 1

            for (let j = 0; j < 2; j++) {
                
                result += '*'.repeat(stars) + letters[lettersIndex] + '-'.repeat(dashes) + letters[lettersIndex + 1] + '*'.repeat(stars) + '\n'
                stars++
                dashes -= 2
                lettersIndex += 2
                rowsCounter++
                
                if (lettersIndex >= letters.length) {

                    lettersIndex = 0
                }

                if (rowsCounter === number) {
                    break;
                }
            }

            stars = 1
            dashes = 2
        }
    }

    console.log(result)
}

printFigure(10)
