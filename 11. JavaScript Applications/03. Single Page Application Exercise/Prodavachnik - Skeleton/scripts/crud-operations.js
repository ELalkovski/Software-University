const BASE_URL = 'https://baas.kinvey.com/'
const APP_KEY = 'kid_BkEGawj9G'
const APP_SECRET = '3b3e00f3505741d2b05669231dd534f9'
const AUTH_HEADERS = { 'Authorization': "Basic " + btoa(APP_KEY + ":" + APP_SECRET) }

function registerUser() {
    let username = $('#formRegister input[name=username]').val()
    let password = $('#formRegister input[name=passwd]').val()

    $.ajax({
        url: `${BASE_URL}user/${APP_KEY}/`,
        method: 'POST',
        headers: AUTH_HEADERS,
        data: { username, password }
    }).then(function (res) {
        signInUser(res, 'Registration successful.')
    }).catch(function (reason) {
        handleAjaxError(reason)
    })
}

function loginUser() {
    let username = $('#formLogin input[name=username]').val()
    let password = $('#formLogin input[name=passwd]').val()

    $.ajax({
        url: `${BASE_URL}user/${APP_KEY}/login`,
        method: 'POST',
        headers: AUTH_HEADERS,
        data: { username, password }
    }).then(function (res) {
        signInUser(res, 'Login successful.')
    }).catch(function (reason) {
        handleAjaxError(reason)
    })
}

function logoutUser() {
    sessionStorage.clear()
    showHideMenuLinks()
    showHomeView()
}

function signInUser(res, message) {
    saveAuthInSession(res)
    showHideMenuLinks()
    showHomeView()
    showInfo(message)
}

function listAdvertises() {
    $.ajax({
        url: `${BASE_URL}appdata/${APP_KEY}/advertisements`,
        headers: { 'Authorization': "Kinvey " + sessionStorage.getItem('authToken') },
    }).then(function (response) {
        displayAdverts(response)
    }).catch(function (reason) {
        handleAjaxError(reason)
    })
}

function displayAdverts(data) {
    refreshTable()

    for (const advert of data) {
        let currentRow = $('<tr>')
        let deleteBtn = $('<a>')
            .attr('href', '#')
            .text('[Delete] ')
            .click(function () {
                deleteAdvert(advert)
            })

        let editBtn = $('<a>')
            .attr('href', '#')
            .text('[Edit]')
            .click(function () {
                loadAdvertForEdit(advert)
            })

        let readMoreBtn = $('<a>')
            .attr('href', '#')
            .text('[Read More] ')
            .click(function () {
                loadAdvert(advert)
            })

        currentRow
            .append($('<td>').text(advert.title))
            .append($('<td>').text(advert.publisher))
            .append($('<td>').text(advert.description))
            .append($('<td>').text(advert.price))
            .append($('<td>').text(advert.datePublished))

        if (advert._acl.creator === sessionStorage.getItem('id')) {
            currentRow
                .append($('<td>')
                    .append(readMoreBtn)
                    .append(deleteBtn)
                    .append(editBtn))
        } else {
            currentRow
                .append($('<td>')
                    .append(readMoreBtn))
        }

        $('#ads table').append(currentRow)
    }
}

function deleteAdvert(advert) {
    $.ajax({
        url: `${BASE_URL}appdata/${APP_KEY}/advertisements/${advert._id}`,
        method: 'DELETE',
        headers: { 'Authorization': "Kinvey " + sessionStorage.getItem('authToken') }
    }).then(function (response) {
        showListAddsView()
        showInfo('Advertisement deleted successfully')
    }).catch(function (reason) {
        handleAjaxError(reason)
    })
}

function loadAdvertForEdit(advert) {
    $('#formEditAd input[name=id]').val(advert._id)
    $('#formEditAd input[name=publisher]').val(advert.publisher)
    $('#formEditAd input[name=title]').val(advert.title)
    $('#formEditAd textarea[name=description]').val(advert.description)
    $('#formEditAd input[name=datePublished]').val(advert.datePublished)
    $('#formEditAd input[name=price]').val(advert.price)
    $('#formEditAd input[name=image]').val(advert.image)
    showView('viewEditAd')
}

function editAdvert() {
    let id = $('#formEditAd input[name=id]').val()
    let publisher = $('#formEditAd input[name=publisher]').val()
    let title = $('#formEditAd input[name=title]').val()
    let description = $('#formEditAd textarea[name=description]').val()
    let datePublished = $('#formEditAd input[name=datePublished]').val()
    let price = $('#formEditAd input[name=price]').val()
    let image = $('#formEditAd input[name=image]').val()

    $.ajax({
        url: `${BASE_URL}appdata/${APP_KEY}/advertisements/${id}`,
        method: 'PUT',
        headers: { 'Authorization': "Kinvey " + sessionStorage.getItem('authToken') },
        data: { publisher, title, description, datePublished, price, image }
    }).then(function (response) {
        showListAddsView()
        showInfo('Advertisement edited successfully')
    }).catch(function (response) {
        handleAjaxError(response)
    })
}

function refreshTable() {
    $('#ads table tr').each((index, el) => {
        if (index > 0) {
            el.remove()
        }
    })
}

function loadAdvert(advert) {
    $('#viewAd').empty()

    let title = $('<h2>').text(advert.title)
    let description = $('<p>').text(advert.description)
    let publisher = $('<p>').text(advert.publisher)
    let date = $('<p>').text(advert.datePublished)
    let image = $('<img>').attr('src', advert.image)

    $('#viewAd')
        .append(image)
        .append($('<br />'))
        .append($('<label>').text('Title:'))
        .append(title)
        .append($('<label>').text('Description:'))
        .append(description)
        .append($('<label>').text('Publisher:'))
        .append(publisher)
        .append($('<label>').text('Date:'))
        .append(date)    

    showView('viewAd')
}

function saveAuthInSession(userInfo) {
    sessionStorage.setItem('username', userInfo.username)
    sessionStorage.setItem('id', userInfo._id)
    sessionStorage.setItem('authToken', userInfo._kmd.authtoken)
}

function createAdvertisement() {
    let title = $('#formCreateAd input[name=title]').val()
    let description = $('#formCreateAd textarea[name=description]').val()
    let datePublished = $('#formCreateAd input[name=datePublished]').val()
    let price = Number($('#formCreateAd input[name=price]').val())
    let publisher = sessionStorage.getItem('username')
    let image = $('#formCreateAd input[name=image]').val()

    $.ajax({
        url: `${BASE_URL}appdata/${APP_KEY}/advertisements`,
        method: 'POST',
        headers: { 'Authorization': "Kinvey " + sessionStorage.getItem('authToken') },
        data: { title, description, datePublished, price, publisher, image, "viewsCount": Number(0) }
    }).then(function (response) {
        showListAddsView()
        showInfo('Advertisements created successfully')
    }).catch(function (reason) {
        handleAjaxError(reason)
    })
}

function handleAjaxError(response) {
    let errorMsg = JSON.stringify(response)
    if (response.readyState === 0)
        errorMsg = "Cannot connect due to network error."
    if (response.responseJSON && response.responseJSON.description)
        errorMsg = response.responseJSON.description
    showError(errorMsg)
}