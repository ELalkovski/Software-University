function sortArraByTwoCriteria(array) {

    array = array.sort((a, b) => compare(a, b))

    function compare(a, b) {

        let resultByFirstCriteria;

        if (a.length < b.length) {

            resultByFirstCriteria = -1
        } else if(a.length > b.length) {

            resultByFirstCriteria = 1
        } else {

            resultByFirstCriteria = 0
        }

        if (resultByFirstCriteria !== 0) {
            
            return resultByFirstCriteria
        } else {

            if (a < b) {
                
                resultByFirstCriteria = -1
            } else if(a > b) {

                resultByFirstCriteria = 1
            } else {

                resultByFirstCriteria = 0
            }

            return resultByFirstCriteria
        }
    }

    return array.forEach((el) => {console.log(el)})
}

sortArraByTwoCriteria(['Isacc',
    'Theodor',
    'Jack',
    'Harrison',
    'George'    
    ])