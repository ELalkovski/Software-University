function getAverage(number){

    let numAsStr = ''
    numAsStr += number

    while (!isHigherThanFive(numAsStr)) {
        
        numAsStr += 9
    }

    console.log(numAsStr)


    function isHigherThanFive(number) {

        let sum = 0

        for (var i = 0; i < number.length; i++) {
            
            let numberAsInt = parseInt(number[i])
            sum += numberAsInt
        }

        let isHigher = sum / number.length > 5

        return isHigher
    }
}

getAverage(5835)