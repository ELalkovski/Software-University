function search() {
    let searchWord = $('#searchText').val()
    let matches = 0

    $('#towns li').each((index, item) => {
        if (item.textContent.includes(searchWord)) {
            matches++
            $(item).css('font-weight', 'bold')
        } else {
            $(item).css('font-weight', '')
        }
    })

    $('#result').text(`${matches} matches found.`)
}