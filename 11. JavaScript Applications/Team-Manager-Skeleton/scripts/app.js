$(() => {
    const app = Sammy('#main', function () {
        this.use('Handlebars', 'hbs')

        this.get('/index.html', (ctx) => {
            checkForLoggedUser(ctx)
            ctx.loadPartials({
                header: '../templates/common/header.hbs',
                footer: '../templates/common/footer.hbs'
            }).then(function () {
                this.partial('../templates/home/home.hbs')
            })
        })

        this.get('#/home', (ctx) => {
            checkForLoggedUser(ctx)
            ctx.loadPartials({
                header: '../templates/common/header.hbs',
                footer: '../templates/common/footer.hbs'
            }).then(function () {
                this.partial('../templates/home/home.hbs')
            })
        })

        this.get('#/about', (ctx) => {
            checkForLoggedUser(ctx)
            ctx.loadPartials({
                header: '../templates/common/header.hbs',
                footer: '../templates/common/footer.hbs'
            }).then(function () {
                this.partial('../templates/about/about.hbs')
            })
        })

        this.get('#/register', (ctx) => {
            ctx.loadPartials({
                header: '../templates/common/header.hbs',
                registerForm: '../templates/register/registerForm.hbs',
                footer: '../templates/common/footer.hbs'
            }).then(function () {
                this.partial('../templates/register/registerPage.hbs')
            })
        })

        this.post('#/register', (ctx) => {
            let username = ctx.params.username;
            let password = ctx.params.password;
            let repeatPassword = ctx.params.repeatPassword;

            auth.register(username, password, repeatPassword)
                .then((userData) => {
                    auth.saveSession(userData)
                    ctx.loggedIn = true
                    ctx.redirect('#/home')
                    auth.showInfo('User registered successfully.')
                })
                .catch((error) => {
                    handleError(error)
                })
        })

        this.get('#/login', (ctx) => {
            ctx.loadPartials({
                header: '../templates/common/header.hbs',
                loginForm: '../templates/login/loginForm.hbs',
                footer: '../templates/common/footer.hbs'
            }).then(function () {
                this.partial('../templates/login/loginPage.hbs')
            })
        })

        this.post('#/login', (ctx) => {
            let username = ctx.params.username;
            let password = ctx.params.password;

            auth.login(username, password)
                .then((userData) => {
                    auth.saveSession(userData)
                    ctx.redirect('#/home')
                    auth.showInfo('User logged in successfully.')
                })
                .catch((error) => {
                    handleError(error)
                });
        })

        this.get('#/logout', (ctx) => {
            auth.logout()
                .then((userData) => {
                    sessionStorage.clear()
                    ctx.redirect('#/home')
                    auth.showInfo('Logged out successfully.')
                })
                .catch((error) => {
                    handleError(error)
                });
        })

        this.get('#/catalog', (ctx) => {
            checkForLoggedUser(ctx)

            if (sessionStorage.getItem('teamId')) {
                ctx.hasNoTeam = false
            } else {
                ctx.hasNoTeam = true
            }

            teamsService.loadTeams()
                .then((teams) => {
                    ctx.teams = teams

                    ctx.loadPartials({
                        header: '../templates/common/header.hbs',
                        team: '../templates/catalog/team.hbs',
                        footer: '../templates/common/footer.hbs'
                    }).then(function () {
                        this.partial('../templates/catalog/teamCatalog.hbs')
                    })
                })


        })

        this.get('#/create', (ctx) => {
            checkForLoggedUser(ctx)
            ctx.action = 'Create'
            ctx.loadPartials({
                header: '../templates/common/header.hbs',
                createForm: '../templates/create/createForm.hbs',
                footer: '../templates/common/footer.hbs'
            }).then(function () {
                this.partial('../templates/create/createPage.hbs')
            })
        })

        this.post('#/create', (ctx) => {
            let name = ctx.params.name;
            let comment = ctx.params.comment;

            teamsService.createTeam(name, comment)
                .then((teamData) => {
                    teamsService.joinTeam(teamData._id)
                    sessionStorage.setItem('teamId', teamData._id)
                    ctx.redirect('#/catalog')
                    auth.showInfo('Team created successfully.')
                    teamsService
                        .addUserInTeam(teamData._id, sessionStorage.getItem('userId'), sessionStorage.getItem('username'))
                })
        })

        this.get('#/catalog/:teamId', (ctx) => {
            checkForLoggedUser(ctx)
            teamsService.loadTeamDetails(ctx.params.teamId.substr(1))
                .then(async (team) => {

                    await teamsService.getAllTeamsUsers().then(function (data) {
                        let teamMembers = data
                            .filter(u => u.teamId === team._id)

                        ctx.members = teamMembers
                    })

                    ctx.name = team.name
                    ctx.comment = team.comment
                    ctx.teamId = team._id

                    if (sessionStorage.getItem('teamId') === team._id) {
                        ctx.isOnTeam = true
                    } else {
                        ctx.isOnTeam = false
                    }
                    if (team._acl.creator === sessionStorage.getItem('userId')) {
                        ctx.isAuthor = true
                    } else {
                        ctx.isAuthor = false
                    }

                    ctx.loadPartials({
                        header: '../templates/common/header.hbs',
                        footer: '../templates/common/footer.hbs',
                        teamMember: '../templates/catalog/teamMember.hbs',
                        teamControls: '../templates/catalog/teamControls.hbs'
                    }).then(function () {
                        this.partial('../templates/catalog/details.hbs')
                    })
                })
        })

        this.get('#/leave', (ctx) => {
            checkForLoggedUser(ctx)

            teamsService.leaveTeam()
                .then(async () => {
                    let teamUserId
                    await teamsService.getAllTeamsUsers()
                        .then(function (data) {
                            let teamMembers = data
                                .filter(u => u.username === sessionStorage.getItem('username') && u.teamId === sessionStorage.getItem('teamId'))

                            teamUserId = teamMembers[0]._id
                        })

                    teamsService.deleteTeamUser(teamUserId)
                    sessionStorage.removeItem('teamId')
                    ctx.redirect('#/catalog')
                    auth.showInfo('You left the team.')
                })
        })

        this.get('#/join/:teamId', (ctx) => {
            checkForLoggedUser(ctx)

            teamsService.joinTeam(ctx.params.teamId.substr(1))
                .then(() => {

                    sessionStorage.setItem('teamId', ctx.params.teamId.substr(1))
                    ctx.redirect('#/catalog')
                    auth.showInfo('You joined the team successfully.')
                    teamsService
                        .addUserInTeam(ctx.params.teamId.substr(1), sessionStorage.getItem('userId'), sessionStorage.getItem('username'))
                })
        })

        this.get('#/edit/:teamId', async (ctx) => {
            checkForLoggedUser(ctx)

            let team = await teamsService.loadTeamDetails(ctx.params.teamId.substr(1))
            ctx.action = 'Edit'
            ctx.nameVal = team.name
            ctx.commentVal = team.comment
            console.log(team.comment)
            ctx.loadPartials({
                header: '../templates/common/header.hbs',
                createForm: '../templates/create/createForm.hbs',
                footer: '../templates/common/footer.hbs'
            }).then(function () {
                this.partial('../templates/create/createPage.hbs')
                $('input #name').val(team.name)
            })
        })

        this.post('#/edit/:teamId', (ctx) => {
            let name = ctx.params.name;
            let comment = ctx.params.comment;

            teamsService.edit(ctx.params.teamId, name, comment)
                .then((teamData) => {
                    ctx.redirect('#/catalog')
                    auth.showInfo('Team information edited successfully.')
                })
        })
    })

    app.run()

    function checkForLoggedUser(ctx) {
        if (sessionStorage.getItem('authtoken')) {
            ctx.loggedIn = true
            ctx.username = sessionStorage.getItem('username')
        }
    }
})