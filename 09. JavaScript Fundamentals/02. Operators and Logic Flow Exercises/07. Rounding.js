function roundNumber(array){

    let numberToRound = array[0]
    let precision = array[1]

    if(precision > 15){
        precision = 15
    }

    let precisionArr = (numberToRound + '').split('.')
    let precisionPlaces = precisionArr[1].length

    if(precisionPlaces <= precision){
        console.log(numberToRound)
    } else {
        console.log(numberToRound.toFixed(precision))
    }    
}

roundNumber([10.5, 3])