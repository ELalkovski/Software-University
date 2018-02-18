function printFigure(n) {

    let figure = ''
    let figureLines = 0
    
    if(n % 2 === 0) {

        figureLines = n - 1
    } else {

        figureLines = n
    }

    let pipesCount = figureLines - 3
    figure += `+${'-'.repeat(n - 2)}+${'-'.repeat(n - 2)}+\n`

    for (let i = 1; i < 3; i++) {
               
        for (let j = 1; j <= pipesCount / 2; j++) {
            
            figure += `|${' '.repeat(n - 2)}|${' '.repeat(n - 2)}|\n`
        }

        figure += `+${'-'.repeat(n - 2)}+${'-'.repeat(n - 2)}+\n`
    }

    if(n === 2) {
        console.log('+++')
    } else {
        console.log(figure)
    }
}

printFigure(12)