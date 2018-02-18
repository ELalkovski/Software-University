function getLastDayOfPreviousMonth(array){

    let day = array[0]
    let month = array[1]
    let year = array[2]

    let date = new Date(year, month - 1, 0)
    console.log(date.getDate())
}

getLastDayOfPreviousMonth([17, 3, 2002])