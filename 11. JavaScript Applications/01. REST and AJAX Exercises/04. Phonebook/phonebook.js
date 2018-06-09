function attachEvents() {
    const url = 'https://phonebook-f6324.firebaseio.com/phonebook.json'
    const phonebook = $('#phonebook')
    $('#btnLoad').click(loadContacts)
    $('#btnCreate').click(createContact)

    function loadContacts() {
        phonebook.empty()

        $.ajax({
            url: url,
            success: displayContacts
        })
    }

    function createContact() {
        let person = $('#person').val()
        let phone = $('#phone').val()
        $('#person').val('')
        $('#phone').val('')

        $.ajax({
            url: url,
            method: 'POST',
            data: JSON.stringify({person, phone}),
            success: loadContacts
        })
    }

    function displayContacts(data) {        
        for (let key in data) {
            let currentEntry = $('<li>')
                .text(`${data[key].person}: ${data[key].phone} `)
                .append($('<button>').text('[Delete]').click(() => deleteContact(key)))

            phonebook.append(currentEntry)
        }
    }

    function deleteContact(key) {
        $.ajax({
            url: `https://phonebook-f6324.firebaseio.com/phonebook/${key}.json`,
            method: 'DELETE',
            success: loadContacts
        })
    }
} 