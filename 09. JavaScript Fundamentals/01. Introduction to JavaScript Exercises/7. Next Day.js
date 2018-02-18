function getNextDay(year, month, day){

    let givenDate = new Date(year, month-1, day)
    let oneDay = 24 * 60 * 60 * 1000
    let nextDay = new Date(givenDate.getTime() + oneDay)
    console.log(nextDay.getFullYear() + '-' + (nextDay.getMonth() + 1) + '-' + nextDay.getDate())
}

getNextDay(2016, 9, 30)