function calendar([day, month, year])
        {
            let currentDate = new Date(year, month - 1, day)
            let firstDay = new Date(year, month - 1, 1).getDay()
            let result = '<table>\n'
                result += '  <tr><th>Sun</th><th>Mon</th><th>Tue</th><th>Wed</th><th>Thu</th><th>Fri</th><th>Sat</th></tr>\n'

            if(firstDay > 0 && firstDay < 7) {
                
                let lastMonth = new Date(year, month - 1, 0)
                let dayOfWeekPreviousMonth = lastMonth.getDay()
                let oneDayInMiliSeconds = 24 * 60 * 60 * 1000

                while (dayOfWeekPreviousMonth > 0) {

                    lastMonth = new Date(lastMonth.getTime() - oneDayInMiliSeconds)
                    dayOfWeekPreviousMonth = lastMonth.getDay()
                }

                let dayCounter = 1
                result += '  <tr>'
                result += `<td class="prev-month">${new Date(lastMonth.getTime()).getDate()}</td>`
                let lastDatePreviousMonth = new Date(year, month - 1, 0).getDay()

                for (let i = 1; i <= lastDatePreviousMonth; i++) {
                    
                    result += `<td class="prev-month">${new Date(lastMonth.getTime() + oneDayInMiliSeconds).getDate()}</td>`
                    lastMonth = new Date(lastMonth.getTime() + oneDayInMiliSeconds)
                    dayCounter++                    
                }

                let nextMonth = new Date(year, month, 1)
                let currentMonthLastDay = new Date(nextMonth.getTime() - oneDayInMiliSeconds).getDate()
                let currentMonth = new Date(year, month - 1, 1)                

                for (let i = 1; i <= currentMonthLastDay; i++) {
                    
                    if(currentMonth.getDate() === day) {

                        result += `<td class="today">${currentMonth.getDate()}</td>`
                    } else {

                        if(currentMonth.getMonth() + 1 === month) {

                            result += `<td>${currentMonth.getDate()}</td>`
                        } else {

                            result += `<td class="next-month">${currentMonth.getDate()}</td>`
                        }
                    }
                    
                    currentMonth = new Date(currentMonth.getTime() + oneDayInMiliSeconds)

                    if(++dayCounter === 7) {
                        result += '</tr>\n  <tr>'
                        dayCounter = 0
                    }
                }

                if(dayCounter < 7 && dayCounter > 0) {

                    let index = dayCounter

                    for (let i = index; i < 7; i++) {

                        if(currentMonth.getMonth() + 1 === month) {

                            result += `<td>${currentMonth.getDate()}</td>`
                        } else {

                            result += `<td class="next-month">${currentMonth.getDate()}</td>`
                        }
                        
                        currentMonth = new Date(currentMonth.getTime() + oneDayInMiliSeconds)
                    }
                } 

                result += '</tr>\n</table>'

                
            } else {

                let lastMonth = new Date(year, month - 1, 0)
                let dayOfWeekPreviousMonth = lastMonth.getDay()
                let oneDayInMiliSeconds = 24 * 60 * 60 * 1000

                let dayCounter = 0
                let lastDatePreviousMonth = new Date(year, month - 1, 0).getDay()

                let nextMonth = new Date(year, month, 1)
                let currentMonthLastDay = new Date(nextMonth.getTime() - oneDayInMiliSeconds).getDate()
                let currentMonth = new Date(year, month - 1, 1)
                result += '<tr>'                

                for (let i = 1; i <= currentMonthLastDay; i++) {
                    
                    if(currentMonth.getDate() === day) {

                        result += `<td class="today">${currentMonth.getDate()}</td>`
                    } else {

                        if(currentMonth.getMonth() + 1 === month) {

                            result += `<td>${currentMonth.getDate()}</td>`
                        } else {

                            result += `<td class="next-month">${currentMonth.getDate()}</td>`
                        }
                    }
                    
                    currentMonth = new Date(currentMonth.getTime() + oneDayInMiliSeconds)

                    if(++dayCounter === 7) {
                        result += '</tr>\n  <tr>'
                        dayCounter = 0
                    }
                }

                if(dayCounter < 7 && dayCounter > 0) {

                    let index = dayCounter

                    for (let i = index; i < 7; i++) {

                        if(currentMonth.getMonth() + 1 === month) {

                            result += `<td>${currentMonth.getDate()}</td>`
                        } else {

                            result += `<td class="next-month">${currentMonth.getDate()}</td>`
                        }
                        
                        currentMonth = new Date(currentMonth.getTime() + oneDayInMiliSeconds)
                    }
                } 

                result += '</tr>\n</table>'
            }

            console.log()
            return result
        }
