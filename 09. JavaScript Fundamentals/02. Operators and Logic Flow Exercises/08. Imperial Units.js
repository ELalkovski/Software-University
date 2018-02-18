function converFeetToInches(number){

    let inches = Math.floor(number / 12)
    let precision = number % 12
    
    console.log(`${inches}\'-${precision}\"`)
}

converFeetToInches(11)