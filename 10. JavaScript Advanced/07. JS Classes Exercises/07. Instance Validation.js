class CheckingAccount {
    constructor (clientId, email, firstName, lastName) {
        this.clientId = clientId
        this.email = email
        this.firstName = firstName
        this.lastName = lastName
    }

    set clientId (value) {
        let idPattern = /^\d{6}$/g

        if (!idPattern.test(value)) {
            throw new TypeError('Client ID must be a 6-digit number')
        }

        this._clientId = Number(value)
    }

    get clientId() {
        return this._clientId
    }

    set email (value) {
        let emailPattern = /^[a-zA-Z0-9]+@[a-zA-Z.]+$/g

        if (!emailPattern.test(value)) {
            throw new TypeError('Invalid e-mail')
        }

        this._email = value
    }

    get email() {
        return this._email
    }

    set firstName (value) {
        let namePattern = /^[a-zA-Z]{3,20}$/g
        if (value.length < 3 || value.length > 20) {
            throw new TypeError('First name must be between 3 and 20 characters long')
        }
        if (!namePattern.test(value)) {
            throw new TypeError('First name must contain only Latin characters')
        }

        this._firstName = value
    }

    get firstName () {
        return this._firstName
    }

    set lastName (value) {
        let namePattern = /^[a-zA-Z]{3,20}$/g

        if (value.length < 3 || value.length > 20) {
            throw new TypeError('Last name must be between 3 and 20 characters long')
        }
        if (!namePattern.test(value)) {
            throw new TypeError('Last name must contain only Latin characters')
        }

        this._lastName = value
    }

    get lastName () {
        return this._lastName
    }
}

let acc = new CheckingAccount('131455', 'ivan@some.com', 'Ivan', 'P3trov')