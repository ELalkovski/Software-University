function timer() {
    let time = 0
    let intervalId

    $('#start-timer').click(function () {
        clearInterval(intervalId)
        intervalId = setInterval(incrementTime, 1000)
    })

    $('#stop-timer').click(function () {
        clearInterval(intervalId)
    })

    function incrementTime() {
        time++
        $('#seconds').text(('0' + Math.trunc(time % 60)).slice(-2))
        $('#minutes').text(('0' + Math.trunc((time / 60) % 60)).slice(-2))
        $('#hours').text(('0' + Math.trunc(time / 3600)).slice(-2))
    }
}