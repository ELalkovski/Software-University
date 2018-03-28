class PaymentManager {
    constructor(title) {
        this.title = title
        this.wholeHtml = this.composeBaseHtml()
    }

    composeBaseHtml() {
        let table = $('<table>')
        let caption = $('<caption>').text(`${this.title} Payment Manager`)
        let tHead = $('<thead>')
            .append($('<tr>')
                .append($('<th>').addClass('name').text('Name'))
                .append($('<th>').addClass('category').text('Category'))
                .append($('<th>').addClass('price').text('Price'))
                .append($('<th>').text('Actions')))

        let rowAddBtn = $('<button>').text('Add').click(function () {
            let name = $(this).parent().parent().find('input[name=name]').val()
            let category = $(this).parent().parent().find('input[name=category]').val()
            let price = $(this).parent().parent().find('input[name=price]').val()

            if (name.length > 0 && category.length > 0 && price.length > 0) {
                $(this).parent().parent().find('input[name=name]').val('')
                $(this).parent().parent().find('input[name=category]').val('')
                $(this).parent().parent().find('input[name=price]').val('')
                let deleteBtn = $('<button>').text('Delete').click(function () {
                    $(this).parent().remove()
                })
                $(this).parent().parent().parent().parent().find('.payments').append($('<tr>')
                    .append($('<td>').text(name))
                    .append($('<td>').text(category))
                    .append($('<td>').text(Number(price)))
                    .append(deleteBtn))
            }
        })

        let tBody = $('<tbody>')
            .addClass('payments')

        let tFoot = $('<tfoot>')
            .addClass('input-data')
            .append($('<tr>')
                .append($('<td>').append($('<input>').attr('name', 'name').attr('type', 'text')))
                .append($('<td>').append($('<input>').attr('name', 'category').attr('type', 'text')))
                .append($('<td>').append($('<input>').attr('name', 'price').attr('type', 'number')))
                .append($('<td>').append(rowAddBtn)))

        table
            .append(caption)
            .append(tHead)
            .append(tBody)
            .append(tFoot)

        return table
    }

    render(id) {
        $('#' + id).append(this.wholeHtml)
    }
}