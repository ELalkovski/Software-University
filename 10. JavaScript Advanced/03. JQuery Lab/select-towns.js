function attachEvents() {
    $('#items li').click(function () {
        if ($(this).attr('data-selected')) {
            $(this).removeAttr('data-selected').css('background', '')
        } else {
            $(this).attr('data-selected', true).css('background', '#DDD')
        }        
    })

    $('#showTownsButton').click(function () {
        let selectedTowns = $('#items li[data-selected=true]').toArray()
        .map(el => el.textContent)
        $('#selectedTowns').text(`Selected towns: ${selectedTowns.join(', ')}`)
    })
}