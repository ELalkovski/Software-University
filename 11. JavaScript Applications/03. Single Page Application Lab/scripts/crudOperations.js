const BASE_URL = 'https://baas.kinvey.com/'
const APP_KEY = 'kid_rkC-XMqqG'
const APP_SECRET = 'ef9a0ff726814e42b5e30e0c8cbe9bce'
const AUTH_HEADERS = { 'Authorization': "Basic " + btoa(APP_KEY + ":" + APP_SECRET) }
const BOOKS_PER_PAGE = 10

function loginUser() {
    let username = $('#formLogin input[name=username]').val()
    let password = $('#formLogin input[name=passwd]').val()

    $.ajax({
        url: `${BASE_URL}user/${APP_KEY}/login`,
        method: 'POST',
        headers: AUTH_HEADERS,
        data: { username, password }
    })
        .then(function (response) {
            signInUser(response, 'Login successful.')
        })
        .catch(function (reason) {
            handleAjaxError(reason)
            $('#formLogin input[name=username]').val('')
            $('#formLogin input[name=passwd]').val('')
        })
}

function logoutUser() {
    sessionStorage.clear()
    showHideMenuLinks()
    showHomeView()
    showInfo('Logout successful.')
}

function registerUser() {
    let username = $('#formRegister input[name=username]').val()
    let password = $('#formRegister input[name=passwd]').val()

    $.ajax({
        url: `${BASE_URL}user/${APP_KEY}/`,
        method: 'POST',
        headers: AUTH_HEADERS,
        data: { username, password }
    })
        .then(function (response) {
            signInUser(response, 'Registration successful.')
        })
        .catch(function (reason) {
            handleAjaxError(reason)
        })
}

function signInUser(res, message) {
    saveAuthInSession(res)
    showHideMenuLinks()
    showHomeView()
    showInfo(message)
}

function saveAuthInSession(userInfo) {
    sessionStorage.setItem('username', userInfo.username)
    sessionStorage.setItem('userId', userInfo._id)
    sessionStorage.setItem('authToken', userInfo._kmd.authtoken)
}

function listBooks() {
    $.ajax({
        url: `${BASE_URL}appdata/${APP_KEY}/books`,
        headers: { 'Authorization': "Kinvey " + sessionStorage.getItem('authToken') }
    })
        .then(function (response) {
            displayPaginationAndBooks(response.reverse())
        })
        .catch(function (reason) {
            handleAjaxError(reason)
        })
}

function createBook() {
    let title = $('#formCreateBook input[name=title]').val()
    let author = $('#formCreateBook input[name=author]').val()
    let description = $('#formCreateBook textarea[name=description]').val()
    let username = sessionStorage.getItem('username')

    $.ajax({
        url: `${BASE_URL}appdata/${APP_KEY}/books`,
        method: 'POST',
        headers: { 'Authorization': "Kinvey " + sessionStorage.getItem('authToken') },
        data: { title, author, description }
    })
        .then(function (response) {
            showInfo('Book created')
            listBooks()
        })
        .catch(function (reason) {
            handleAjaxError(reason)
        })
    // TODO
    // POST -> BASE_URL + 'appdata/' + APP_KEY + '/books'
    // showInfo('Book created.')
}

function deleteBook(book) {
    let bookId = book._id

    $.ajax({
        url: `${BASE_URL}appdata/${APP_KEY}/books/${bookId}`,
        method: 'DELETE',
        headers: { 'Authorization': "Kinvey " + sessionStorage.getItem('authToken') },
    })
    .then(function (response) {
        showInfo('Book deleted.')
        listBooks()
    })
    .catch(function (reason) {
        handleAjaxError(reason)
    })
}

function loadBookForEdit(book) {
    let editForm = $('#formEditBook')

    editForm.find('input[name=id]').val(book._id)
    editForm.find('input[name=title]').val(book.title)
    editForm.find('input[name=author]').val(book.author)
    editForm.find('textarea[name=description]').val(book.description)
    showView('viewEditBook')
    editBook()
}

function editBook() {
    $('#formEditBook').find('input[type=submit]')
        .click(function () {
            let id = $('#formEditBook').find('input[name=id]').val()
            let title = $('#formEditBook').find('input[name=title]').val()
            let author = $('#formEditBook').find('input[name=author]').val()
            let description = $('#formEditBook').find('textarea[name=description]').val()

            $.ajax({
                url: `${BASE_URL}appdata/${APP_KEY}/books/${id}`,
                method: 'PUT',
                headers: { 'Authorization': "Kinvey " + sessionStorage.getItem('authToken') },
                data: { title, author, description }
            }).then(function (response) {
                listBooks()
                showInfo('Book edited.')
            })
                .catch(function (reason) {
                    handleAjaxError(reason)
                })
        })
}

function displayPaginationAndBooks(books) {
    let pagination = $('#pagination-demo')
    if (pagination.data("twbs-pagination")) {
        pagination.twbsPagination('destroy')
    }
    pagination.twbsPagination({
        totalPages: Math.ceil(books.length / BOOKS_PER_PAGE),
        visiblePages: 5,
        next: 'Next',
        prev: 'Prev',
        onPageClick: function (event, page) {
            // TODO remove old page books
            let startBook = (page - 1) * BOOKS_PER_PAGE
            let endBook = Math.min(startBook + BOOKS_PER_PAGE, books.length)
            $(`a:contains(${page})`).addClass('active')
            for (let i = startBook; i < endBook; i++) {
                // TODO add new page books
            }
        }


    })
    refreshTable()
    populateTable(books)
    showView('viewBooks')
}

function populateTable(books) {
    let userId = sessionStorage.getItem('userId')
    for (const book of books) {
        let currentRow = $('<tr>')
            .append($('<td>').text(book.title))
            .append($('<td>').text(book.author))
            .append($('<td>').text(book.description))

        if (book._acl.creator === userId) {
            currentRow
                .append($('<td>')
                    .append($('<a>').text('[Delete]').attr('href', '#').click(() => deleteBook(book)))
                    .append($('<a>').text('[Edit]').attr('href', '#').click(() => loadBookForEdit(book))))
        } else {
            currentRow
                .append($('<td>'))
        }

        $('#books table').append(currentRow)
    }
}

function refreshTable() {
    $('#books table').empty()
    $('#books table').append($('<tr>')
        .append($('<th>').text('Title'))
        .append($('<th>').text('Author'))
        .append($('<th>').text('Description'))
        .append($('<th>').text('Actions')))
}

function handleAjaxError(response) {
    let errorMsg = JSON.stringify(response)
    if (response.readyState === 0)
        errorMsg = "Cannot connect due to network error."
    if (response.responseJSON && response.responseJSON.description)
        errorMsg = response.responseJSON.description
    showError(errorMsg)
}