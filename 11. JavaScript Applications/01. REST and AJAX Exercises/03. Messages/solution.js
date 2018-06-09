function attachEvents() {
    $('#submit').click(submit)
    $('#refresh').click(refresh)

    function submit() {
        let author = $('#author').val()
        let content = $('#content').val()
        let timestamp = Date.now()
        $('#author').val('')
        $('#content').val('')
        let objToAdd = JSON.stringify({author, content, timestamp})

        $.ajax({
            url: 'https://messagesproject-5e138.firebaseio.com/messenger/.json',
            method: 'POST',
            data: objToAdd
        })
        refresh()
    }

    function refresh() {
        $.get('https://messagesproject-5e138.firebaseio.com/messenger/.json')
            .then(displayMessages)
    }

    function displayMessages(data) {
        let result = ''
        $('#messages').empty()

        for (const key in data) {
            $('#messages').append(`${data[key].author}: ${data[key].content}\n`)
        }
    }
}