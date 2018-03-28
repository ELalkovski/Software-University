function increment(selector) {

    let textArea = $('<textarea>')
    .addClass('counter')
    .attr('disabled', 'disabled')
    .val(0)

    let incrBtn = $('<button>')
    .addClass('btn')
    .attr('id', 'incrementBtn')
    .text('Increment')
    .click(function () {
        $(textArea).val(Number($(textArea).val()) + 1)
    })

    let addBtn = $('<button>')
    .addClass('btn')
    .attr('id', 'addBtn')
    .text('Add')
    .click(function () {
        $(ul).append($('<li>').text($(textArea).val()))
    })

    let ul = $('<ul>')
    .addClass('results')

    $(selector)
    .append(textArea)
    .append(incrBtn)
    .append(addBtn)
    .append(ul)
}