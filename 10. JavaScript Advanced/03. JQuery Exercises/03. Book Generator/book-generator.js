function createBook(selector, title, author, isbn) {

    let bookId = 1

    let div = $('<div>')
    .attr('id', 'book' + bookId++)
    .css('border', 'medium none')
    .append($('<p>').addClass('title').text(title))
    .append($('<p>').addClass('author').text(author))
    .append($('<p>').addClass('isbn').text(isbn))
    .append($('<button>').text('Select').click(function () {
        $(this).parent().css('border', '2px solid blue')
    }))
    .append($('<button>').text('Deselect').click(function () {
        $(this).parent().css('border', '')
    }))

    $(selector).append(div)
}
