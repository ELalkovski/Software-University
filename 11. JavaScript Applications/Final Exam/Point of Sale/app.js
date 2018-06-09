$(() => {
    const app = Sammy('#container', function () {
        this.use('Handlebars', 'hbs')

        this.get('/index.html', (ctx) => {
            checkForLoggedUser(ctx)
            ctx.loadPartials({
                header: './templates/global/header.hbs',
                loginForm: './templates/authentication/loginForm.hbs',
                registrationForm: './templates/authentication/registrationForm.hbs',
                footer: './templates/global/footer.hbs'
            }).then(function () {
                this.partial('./templates/home.hbs')
            })
        })

        this.post('#/register', (ctx) => {
            let username = ctx.params['username-register']
            let password = ctx.params['password-register']
            let repeatPassword = ctx.params['password-register-check']
            let usernameValidation = username.length >= 5
            let passwordsLengthValidation = password.length > 0 || repeatPassword.length > 0
            let equalPasswordsValidation = password === repeatPassword

            if (!usernameValidation) {
                authenticationService.showError('Username should be at least 5 characters long.')
            } else if (!passwordsLengthValidation) {
                authenticationService.showError('Password and repeat password fields are required.')
            } else if (!equalPasswordsValidation) {
                authenticationService.showError('Passwords doesn\'t match.')
            }

            if (usernameValidation && passwordsLengthValidation && equalPasswordsValidation) {
                authenticationService.register(username, password, repeatPassword)
                    .then((userData) => {
                        
                        authenticationService.saveSession(userData)
                        authenticationService.showInfo('User registration successful.')
                        ctx.redirect('#/createReceipt')
                    })
                    .catch((error) => {
                        authenticationService.handleError(error)
                    })
            }
        })

        this.post('#/login', (ctx) => {
            let username = ctx.params['username-login']
            let password = ctx.params['password-login']
            let usernameValidation = username.length >= 5
            let passwordsLengthValidation = password.length > 0

            if (!usernameValidation) {
                authenticationService.showError('Username should be at least 5 characters long.')
            } else if (!passwordsLengthValidation) {
                authenticationService.showError('Password field is required.')
            }

            if (usernameValidation && passwordsLengthValidation) {
                authenticationService.login(username, password)
                    .then((userData) => {
                        authenticationService.saveSession(userData)
                        ctx.redirect('#/editor')
                        authenticationService.showInfo('Login successful.')
                    })
                    .catch((error) => {
                        authenticationService.handleError(error)
                    })
            }
        })

        this.get('#/logout', (ctx) => {
            authenticationService.logout()
                .then((data) => {
                    sessionStorage.clear()
                    ctx.redirect('/index.html')
                    authenticationService.showInfo('Logout successful.')
                    checkForLoggedUser(ctx)
                })
                .catch((error) => {
                    handleError(error)
                })
        })

        this.get('#/editor', (ctx) => {
            checkForLoggedUser(ctx)
            salesService.getActiveReceipt(sessionStorage.getItem('userId'))
                .then(async function (receipt) {
                    let receiptId = receipt[0]._id
                    let entries = await salesService.getReceiptEntries(receiptId)
                    sessionStorage.setItem('receiptId', receiptId)

                    ctx.entries = entries
                    ctx.total = 0
                    ctx.entries.forEach((el) => {
                        el.subTotal = (el.qty * el.price).toFixed(2)
                        el.price = Number(el.price).toFixed(2)
                        el.isCreateMode = true
                        ctx.total += Number(el.subTotal)
                    })


                    ctx.loadPartials({
                        header: './templates/global/header.hbs',
                        entry: './templates/entries/entry.hbs',
                        entryForm: './templates/entries/entryForm.hbs',
                        createReceiptForm: './templates/receipts/createReceiptForm.hbs',
                        footer: './templates/global/footer.hbs'
                    }).then(function () {
                        this.partial('./templates/receipts/createReceipt.hbs')
                    })
                })
                .catch((error) => {
                    authenticationService.handleError(error)
                })


        })

        this.post('#/addEntry', (ctx) => {
            let type = ctx.params.type
            let quantity = ctx.params.qty
            let receiptId = sessionStorage.getItem('receiptId')
            let price = ctx.params.price
            let typeValidation = type.length > 0
            let quantityValidation = isNaN(quantity)
            let priceValidation = isNaN(price)

            if (!typeValidation) {
                authenticationService.showError('Product name cannot be empty.')
            }

            if (priceValidation) {
                authenticationService.showError('Product price must be a number.')
            }

            if (quantityValidation) {
                authenticationService.showError('Product quantity must be a number.')
            }

            

            if (typeValidation && !quantityValidation && !priceValidation) {
                salesService.addEntry(type, quantity, price, receiptId)
                    .then((data) => {
                        authenticationService.showInfo('Entry added')
                        ctx.redirect('#/editor')
                    })
                    .catch((error) => {
                        authenticationService.handleError(error)
                    })
            }
        })

        this.get('#/delete/:entryId', (ctx) => {
            salesService.deleteEntry(ctx.params.entryId.substr(1))
                .then((data) => {
                    authenticationService.showInfo('Entry removed')
                    ctx.redirect('#/editor')
                })
                .catch((error) => {
                    authenticationService.handleError(error)
                })
        })

        this.post('#/checkoutReceipt', (ctx) => {
            let receiptId = sessionStorage.getItem('receiptId')
            let productsCount = Number($('#active-entries')[0].childElementCount)
            let total = Number($('#create-receipt-form div.col')[3].innerHTML)

            if (productsCount >= 1) {
                salesService.checkoutReceipt(receiptId, productsCount, total)
                    .then((data) => {
                        authenticationService.showInfo('Receipt checked out')
                        ctx.redirect('#/createReceipt')
                    })
                    .catch((error) => {
                        authenticationService.handleError(error)
                    })
            } else {
                authenticationService.showError('Receipt must contain at least one product entry.')
            }
        })

        this.get('#/createReceipt', (ctx) => {

            salesService.createReceipt()
                .then((data) => {
                    ctx.redirect('#/editor')
                    sessionStorage.setItem('receiptId', data._id)
                })
                .catch((error) => {
                    authenticationService.handleError(error)
                })
        })

        this.get('#/overview', (ctx) => {
            checkForLoggedUser(ctx)
            salesService.getMyReceipts(sessionStorage.getItem('userId'))
                .then((receipts) => {
                    ctx.receipts = receipts
                    ctx.total = 0
                    ctx.receipts.forEach((el) => {
                        let date = el._kmd.ect.substr(0, 16).split('T')
                        el.creationDate = date.join(' ')
                        el.currentTotal = Number(el.total)
                        ctx.total += el.currentTotal
                        el.currentTotal = Number(el.total).toFixed(2)
                    })
                    ctx.total = Number(ctx.total).toFixed(2)
                    ctx.loadPartials({
                        header: './templates/global/header.hbs',
                        receipt: './templates/receipts/receipt.hbs',
                        footer: './templates/global/footer.hbs'
                    }).then(function () {
                        this.partial('./templates/receipts/allReceipts.hbs')
                    })
                })
                .catch((error) => {
                    authenticationService.handleError(error)
                })
        })

        this.get('#/details/:id', async (ctx) => {
            checkForLoggedUser(ctx)
            let receiptId = ctx.params.id.substr(1)
            let entries = await salesService.getReceiptEntries(receiptId)
            ctx.entries = entries
            ctx.entries.forEach((el) => {
                el.subTotal = Number(el.qty * el.price).toFixed(2)
                el.price = Number(el.price).toFixed(2)
            })
            ctx.loadPartials({
                header: './templates/global/header.hbs',
                entry: './templates/entries/entry.hbs',
                footer: './templates/global/footer.hbs'
            }).then(function () {
                this.partial('./templates/receipts/receiptDetails.hbs')
            })


        })
    })

    app.run();

    function checkForLoggedUser(ctx) {
        if (sessionStorage.getItem('authtoken')) {
            ctx.isLoggedIn = true
            ctx.username = sessionStorage.getItem('username')
        }
    }
})