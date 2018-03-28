class Contact {
    constructor(firstName, lastName, phoneNumber, email) {
        this.firstName = firstName
        this.lastName = lastName
        this.phoneNumber = phoneNumber
        this.email = email
        this.domElement = this.createElement()
        this.online = false
        
    }

    set online(value) {
        this._online = value

        if (this.online) {
            this.domElement.titleDiv.addClass('online')
        } else {
            this.domElement.titleDiv.removeClass('online')
        }
    }

    get online() {
        return this._online
    }

    createElement() {
        let infoDiv = $('<div id="info">')
        .addClass('info')
        .css('display', 'none')
        .append($('<span>').text('&phone; ' + this.phoneNumber))
        .append($('<span>').text('✉ ' + this.email))

        let titleDiv = $('<div>')
        .addClass('title')
        .text(this.firstName + ' ' + this.lastName)
        .append($('<button>').text('ℹ').click(function () {
            let thisInfoTag = $(this).parent().parent().find('div#info')[0]

            if ($(thisInfoTag).css('display') == 'none') {
                $(thisInfoTag).css('display', 'block')
            } else {
                $(thisInfoTag).css('display', 'none')
            }
        }))
        
        return {infoDiv, titleDiv}
    }

    render(id) {     
        let article = $('<article>')       

        $(article).append(this.domElement.titleDiv).append(this.domElement.infoDiv)
        $('#' + id).append(article)    
    }
}