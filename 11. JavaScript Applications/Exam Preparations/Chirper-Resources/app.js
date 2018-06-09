$(() => {
    const app = Sammy('#main', function () {
        this.use('Handlebars', 'hbs')

        this.get('/skeleton.html', (ctx) => {
            checkForLoggedUser(ctx)
            ctx.loadPartials({
                header: './templates/global/header.hbs',
                loginForm: './templates/login/loginForm.hbs',
                footer: './templates/global/footer.hbs'
            }).then(function () {
                this.partial('./templates/login/loginPage.hbs')
            })
        })

        this.get('#/register', (ctx) => {
            checkForLoggedUser(ctx)
            ctx.loadPartials({
                header: './templates/global/header.hbs',
                registerForm: './templates/register/registerForm.hbs',
                footer: './templates/global/footer.hbs'
            }).then(function () {
                this.partial('./templates/register/registerPage.hbs')
            })
        })

        this.post('#/register', (ctx) => {
            let username = ctx.params.username;
            let password = ctx.params.password;
            let repeatPassword = ctx.params.repeatPass;
            let usernameValidation = username.length >= 5
            let passwordsLengthValidation = password.length > 0 || repeatPassword.length > 0
            let equalPasswordsValidation = password === repeatPassword

            if (!usernameValidation) {
                auth.showError('Username should be at least 5 characters long.')
            } else if (!passwordsLengthValidation) {
                auth.showError('Password and repeat password fields are required.')
            } else if (!equalPasswordsValidation) {
                auth.showError('Passwords doesn\'t match.')
            }

            if (usernameValidation && passwordsLengthValidation && equalPasswordsValidation) {
                auth.register(username, password, repeatPassword)
                    .then((userData) => {
                        ctx.redirect('/skeleton.html')
                        $('#registerForm').trigger('reset')
                        auth.showInfo('User registration successful.')
                    })
                    .catch((error) => {
                        handleError(error)
                    })
            }
        })

        this.get('#/login', (ctx) => {
            checkForLoggedUser(ctx)
            ctx.loadPartials({
                header: './templates/global/header.hbs',
                loginForm: './templates/login/loginForm.hbs',
                footer: './templates/global/footer.hbs'
            }).then(function () {
                this.partial('./templates/login/loginPage.hbs')
            })
        })

        this.post('#/login', (ctx) => {
            let username = ctx.params.username;
            let password = ctx.params.password;
            let usernameValidation = username.length >= 5
            let passwordsLengthValidation = password.length > 0

            if (!usernameValidation) {
                auth.showError('Username should be at least 5 characters long.')
            } else if (!passwordsLengthValidation) {
                auth.showError('Password field is required.')
            }

            if (usernameValidation && passwordsLengthValidation) {
                auth.login(username, password)
                    .then((userData) => {
                        auth.saveSession(userData)
                        ctx.redirect('#/home')
                        $('#loginForm').trigger('reset')
                        auth.showInfo('Login successful.')
                    })
            }
        })

        this.get('#/logout', (ctx) => {
            auth.logout()
                .then((data) => {
                    sessionStorage.clear()
                    ctx.redirect('#/login')
                    auth.showInfo('Logout successful.')
                    checkForLoggedUser(ctx)
                })
                .catch((error) => {
                    handleError(error)
                })
        })

        this.get('#/home', (ctx) => {
            checkForLoggedUser(ctx)
            let subs = sessionStorage.getItem('subs')
            let username = sessionStorage.getItem('username')
            if (subs.length > 2) {
                ctx.noSubs = false
            } else {
                ctx.noSubs = true
            }
            ctx.isMyPage = false

            chirperService.loadChirps(subs)
                .then(async (chirps) => {
                    chirps.forEach((el) => {
                        el._kmd.ect = chirperService.calcTime(el._kmd.ect)
                        el.isMyPage = false
                    })
                    
                    ctx.chirps = chirps
                    ctx.myName = sessionStorage.getItem('username')

                    ctx.chirpsCount = await chirperService.loadChirpsCount()
                    ctx.followingCount = await chirperService.loadFollowingCount()
                    ctx.followersCount = await chirperService.loadFollowersCount(username)
                    ctx.loadPartials({
                        header: './templates/global/header.hbs',
                        chirpForm: './templates/chirps/chirpForm.hbs',
                        chirp: './templates/chirps/chirp.hbs',
                        footer: './templates/global/footer.hbs'
                    }).then(function () {
                        this.partial('./templates/chirps/chirpsList.hbs')
                    })
                })
        })

        this.post('#/chirp', (ctx) => {
            let chirpText = $('textarea.chirp-input').val()
            let author = sessionStorage.getItem('username')

            chirperService.createChirp(chirpText, author)
                .then(function (data) {
                    ctx.redirect('#/me')
                    auth.showInfo('Chirp published.')
                })
                .catch(function (error) {
                    handleError(error)
                })
        })

        this.get('#/me', async (ctx) => {
            checkForLoggedUser(ctx)
    
            let subs = sessionStorage.getItem('subs')
            if (subs.length > 2) {
                ctx.noSubs = false
            } else {
                ctx.noSubs = true
            }

            await chirperService.loadMyChirps()
                .then(async (chirps) => {
                    chirps.forEach((el) => {
                        el._kmd.ect = chirperService.calcTime(el._kmd.ect)
                        el.isMyPage = true
                    })
                    ctx.chirps = chirps
                    ctx.myName = sessionStorage.getItem('username')
                    ctx.chirpsCount = await chirperService.loadChirpsCount()
                    ctx.followingCount = await chirperService.loadFollowingCount()
                    ctx.followersCount = await chirperService.loadFollowersCount()
                    ctx.params.isMyPage = true
                    await ctx.loadPartials({
                        header: './templates/global/header.hbs',
                        chirpForm: './templates/chirps/chirpForm.hbs',
                        chirp: './templates/chirps/chirp.hbs',
                        footer: './templates/global/footer.hbs'
                    }).then(function () {
                        this.partial('./templates/chirps/chirpsList.hbs')
                    })
                })
        })
    
        this.get('#/delete/:chirpId', (ctx) => {
            let id = ctx.params.chirpId.substr(1)
            
            chirperService.removeChirp(id)
                .then(function () {
                    auth.showInfo('Chirp deleted.')
                    ctx.redirect('#/me')
                })
                .catch(function (error) {
                    auth.handleError(error)
                })            
        })
    
        this.get('#/discover', (ctx) => {
            checkForLoggedUser(ctx)
            chirperService.discover()
                .then(async function (users) {
                    ctx.users = users.filter(el => el.username !== sessionStorage.getItem('username'))
                    
                    for (const user of ctx.users) {
                        user.followersCount = await chirperService.loadFollowersCount(user.username)
                    }
                    ctx.users.sort((a, b) => {
                        return b.followersCount - a.followersCount
                    })
                    ctx.loadPartials({
                        header: './templates/global/header.hbs',
                        user: './templates/discover/user.hbs',
                        footer: './templates/global/footer.hbs'
                    }).then(function () {
                        this.partial('./templates/discover/discoverPage.hbs')
                    })
                })
                .catch(function (error) {
                    auth.handleError(error)
                })
        })

        this.get('#/profile/:id', async (ctx) => {
            checkForLoggedUser(ctx)
            let user = await chirperService.getUser(ctx.params.id.substr(1))
            let subs = JSON.stringify(user.subscriptions)
            let loggedUserSubs = sessionStorage.getItem('subs')

            loggedUserSubs.includes(user.username) ? ctx.isFollowed = 'Unfollow' : ctx.isFollowed = 'Follow'
            subs.length > 2 ? ctx.noSubs = false : ctx.noSubs = true
            ctx.isMyPage = false
            ctx.userId = user._id

            chirperService.loadChirps(subs)
                .then(async (chirps) => {
                    chirps.forEach((el) => {
                        el._kmd.ect = chirperService.calcTime(el._kmd.ect)
                        el.isMyPage = false
                    })
                    
                    ctx.chirps = chirps
                    ctx.username = user.username

                    ctx.chirpsCount = await chirperService.loadChirpsCount(ctx.username)
                    ctx.followingCount = await chirperService.loadFollowingCount(ctx.username)
                    ctx.followersCount = await chirperService.loadFollowersCount(ctx.username)
                    ctx.loadPartials({
                        header: './templates/global/header.hbs',
                        chirp: './templates/chirps/chirp.hbs',
                        footer: './templates/global/footer.hbs'
                    }).then(function () {
                        this.partial('./templates/profile/profilePage.hbs')
                    })
                })
        })

        this.get('#/Follow/:id', async (ctx) => {
            let followedUserId = ctx.params.id.substr(1)
            let user = await chirperService.getUser(followedUserId)
            let id = sessionStorage.getItem('userId')
            let username = sessionStorage.getItem('username')
            let subs = JSON.parse(sessionStorage.getItem('subs'))
            subs.push(user.username)
            sessionStorage.setItem('subs', JSON.stringify(subs))
            
            chirperService.updateUser(id, username, subs)
                .then(function (userData) {
                    auth.showInfo(`Subscribed to ${user.username}`)
                    ctx.redirect(`#/profile/:${followedUserId}`)
                })
                .catch((error) => {
                    auth.handleError(error)
                })
        })

        this.get('#/Unfollow/:id', async (ctx) => {
            let followedUserId = ctx.params.id.substr(1)
            let user = await chirperService.getUser(followedUserId)
            let id = sessionStorage.getItem('userId')
            let username = sessionStorage.getItem('username')
            let subs = JSON.parse(sessionStorage.getItem('subs'))
            subs = subs.filter(u => u !== user.username)

            sessionStorage.setItem('subs', JSON.stringify(subs))
            
            chirperService.updateUser(id, username, subs)
                .then(function (userData) {
                    auth.showInfo(`Unsubscribed from ${user.username}`)
                    ctx.redirect(`#/profile/:${followedUserId}`)
                })
                .catch((error) => {
                    auth.handleError(error)
                })
        })
    })

    app.run();

    function checkForLoggedUser(ctx) {
        if (sessionStorage.getItem('authtoken')) {
            ctx.loggedIn = true
            ctx.username = sessionStorage.getItem('username')
        }
    }
})