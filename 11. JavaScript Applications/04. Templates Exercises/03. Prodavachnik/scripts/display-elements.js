function showView(viewName) {
    $('main > section').hide() // Hide all views
    $('#' + viewName).show() // Show the selected view only
}

async function showHideMenuLinks() {
    let authtoken = sessionStorage.getItem('authtoken')
    let headers = window.headers.unAuthenticatedHeaders

    if (authtoken) {
        headers = window.headers.authenticatedHeaders
    }

    let source = await $.get('./templates/header-template.hbs')
    let compiled = Handlebars.compile(source)
    let template = compiled({
        headers
    })
    $('#app header').remove()
    $('#app').prepend(template)


    attachLinksEvents()
    //attachBtnEvents()
}

function attachLinksEvents() {
    // Bind the navigation menu links
    $('#linkHome').click(showHomeView)
    $('#linkLogin').click(showLoginView)
    $('#linkRegister').click(showRegisterView)
    $('#linkLogout').click(logoutUser)
    $('#linkListAds').click(showListAddsView)
    $('#linkCreateAd').click(showCreateAdvertiseView)

    // Bind the info / error boxes

    // Attach AJAX "loading" event listener
    $(document).on({
        ajaxStart: function () { $("#loadingBox").show() },
        ajaxStop: function () { $("#loadingBox").hide() }
    })
}

function attachBtnEvents() {

    // Bind the form submit buttons
    
    
    $('#buttonEditAd').click(editAdvert)
}

function showInfo(message) {
    let infoBox = $('#infoBox')
    infoBox.text(message)
    infoBox.show()
    setTimeout(function () {
        console.log('inside')
        $('#infoBox').fadeOut()
    }, 3000)
}

function showError(errorMsg) {
    let errorBox = $('#errorBox')
    errorBox.text("Error: " + errorMsg)
    errorBox.show()
}

async function showHomeView() {
    let source = await $.get('./templates/home-template.hbs')
    let compiled = Handlebars.compile(source)
    let template = compiled({

    })

    $('#app div#content').html(template)
}

async function showLoginView() {
    let source = await $.get('./templates/login-register-template.hbs')
    let compiled = Handlebars.compile(source)
    let template = compiled({
        id: 'viewLogin',
        title: 'Please login',
        formId: 'formLogin',
        btnId: 'buttonLoginUser',
        btnValue: 'Login'
    })
    //$(template).find('#formLogin').trigger('reset')
    $('#app div#content').html(template)
    $('#buttonLoginUser').click(loginUser)
}

async function showRegisterView() {
    let source = await $.get('./templates/login-register-template.hbs')
    let compiled = Handlebars.compile(source)
    let template = compiled({
        id: 'viewRegister',
        title: 'Please register here',
        formId: 'formRegister',
        btnId: 'buttonRegisterUser',
        btnValue: 'Register'
    })
    //$(template).find('#formLogin').trigger('reset')
    $('#app div#content').html(template)
    $('#buttonRegisterUser').click(registerUser)
}

async function showCreateAdvertiseView() {
    let source = await $.get('./templates/create-edit-advert-template.hbs')
    let compiled = Handlebars.compile(source)
    let template = compiled({
        id: 'viewCreateAd',
        title: 'Create new',
        formId: 'formCreateAd',
        btnId: 'buttonCreateAd',
        btnValue: 'Create'
    })
    //$(template).find('#formLogin').trigger('reset')
    $('#app div#content').html(template)
    $('#buttonCreateAd').click(createAdvertisement)
}

function showListAddsView() {
    listAdvertises()
}